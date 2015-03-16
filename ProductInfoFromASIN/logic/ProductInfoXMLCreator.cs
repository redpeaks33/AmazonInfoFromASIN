using MarketplaceWebServiceProducts;
using MarketplaceWebServiceProducts.Model;
using ProductInfoFromASIN.model;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ProductInfoFromASIN
{
    internal class ProductInfoXMLCreator
    {
        private MarketplaceWebServiceProductsClient client;
        private string accessKey = null;
        private string secretKey = null;
        private string sellerId = null;
        private string marketplaceId = null;

        internal List<AmazonProductInfo> Start(IEnumerable<string> ASINList, IEnumerable<string> AmazonIDList)
        {
            SetAmazonID(AmazonIDList);

            string appName = "CSharpSampleCode";
            string appVersion = "1.0";
            string serviceURL = "https://mws.amazonservices.jp";
            MarketplaceWebServiceProductsConfig config = new MarketplaceWebServiceProductsConfig();
            config.ServiceURL = serviceURL;
            var client = new MarketplaceWebServiceProductsClient(appName, appVersion, accessKey, secretKey, config);
            this.client = client;
            var XmlList = new List<XDocument>();
            var amazonProductInfoList = new List<AmazonProductInfo>();

            foreach (var ASINCode in ASINList)
            {
                if (ASINCode == null || ASINCode == "")
                {
                    continue;
                }
                try
                {
                    amazonProductInfoList.Add(new AmazonProductInfo()
                    {
                        matchingProduct = XDocument.Parse(InvokeGetMatchingProduct(ASINCode).ToXML()),
                        competitivePricing = XDocument.Parse(InvokeGetCompetitivePricingForASIN(ASINCode).ToXML()),
                        //lowestOfferListings = XDocument.Parse(InvokeGetLowestOfferListingsForASIN(ASINCode).ToXML()),
                        //myPrice = XDocument.Parse(InvokeGetMyPriceForASIN(ASINCode).ToXML()),
                        productCategories = XDocument.Parse(InvokeGetProductCategoriesForASIN(ASINCode).ToXML()),
                    });
                }
                catch (MarketplaceWebServiceProductsException ex)
                {
                    // Exception properties are important for diagnostics.
                    ResponseHeaderMetadata rhmd = ex.ResponseHeaderMetadata;
                    Console.WriteLine("Service Exception:" + rhmd.ToString());
                    if (rhmd != null)
                    {
                        Console.WriteLine("RequestId: " + rhmd.RequestId);
                        Console.WriteLine("Timestamp: " + rhmd.Timestamp);
                    }
                    Console.WriteLine("Message: " + ex.Message);
                    Console.WriteLine("StatusCode: " + ex.StatusCode);
                    Console.WriteLine("ErrorCode: " + ex.ErrorCode);
                    Console.WriteLine("ErrorType: " + ex.ErrorType);
                    continue;
                }
            }

            return amazonProductInfoList;
        }

        private void SetAmazonID(IEnumerable<string> AmazonIDList)
        {
            var list = (List<string>)(AmazonIDList);
            accessKey = list[0];
            secretKey = list[1];
            sellerId = list[2];
            marketplaceId = list[3];
        }

        #region From ASIN Code

        public GetMatchingProductResponse InvokeGetMatchingProduct(string asinCode)
        {
            var request = new GetMatchingProductRequest();
            request.SellerId = sellerId;
            request.MWSAuthToken = "";
            request.MarketplaceId = marketplaceId;

            request.ASINList = new ASINListType();
            request.ASINList.ASIN.Add(asinCode);

            return this.client.GetMatchingProduct(request);
        }

        public GetCompetitivePricingForASINResponse InvokeGetCompetitivePricingForASIN(string asinCode)
        {
            var request = new GetCompetitivePricingForASINRequest();
            request.SellerId = this.sellerId;
            request.MWSAuthToken = "";
            request.MarketplaceId = this.marketplaceId;

            request.ASINList = new ASINListType();
            request.ASINList.ASIN.Add(asinCode);

            return this.client.GetCompetitivePricingForASIN(request);
        }

        public GetLowestOfferListingsForASINResponse InvokeGetLowestOfferListingsForASIN(string asinCode)
        {
            var request = new GetLowestOfferListingsForASINRequest();
            request.SellerId = this.sellerId;
            request.MWSAuthToken = "";
            request.MarketplaceId = this.marketplaceId;
            request.ItemCondition = "example";
            request.ExcludeMe = true;

            request.ASINList = new ASINListType();
            request.ASINList.ASIN.Add(asinCode);

            return this.client.GetLowestOfferListingsForASIN(request);
        }

        public GetMyPriceForASINResponse InvokeGetMyPriceForASIN(string asinCode)
        {
            var request = new GetMyPriceForASINRequest();
            request.SellerId = sellerId;
            request.MWSAuthToken = "";
            request.MarketplaceId = marketplaceId;

            request.ASINList = new ASINListType();
            request.ASINList.ASIN.Add(asinCode);

            return this.client.GetMyPriceForASIN(request);
        }

        public GetProductCategoriesForASINResponse InvokeGetProductCategoriesForASIN(string asinCode)
        {
            var request = new GetProductCategoriesForASINRequest();
            request.SellerId = sellerId;
            request.MWSAuthToken = "";
            request.MarketplaceId = marketplaceId;

            request.ASIN = asinCode;
            return this.client.GetProductCategoriesForASIN(request);
        }

        #endregion From ASIN Code
    }
}