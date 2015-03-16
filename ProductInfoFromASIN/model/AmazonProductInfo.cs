using System.Xml.Linq;
namespace ProductInfoFromASIN.model
{
    internal class AmazonProductInfo
    {

        internal string ASIN = null;
        internal string imageURL = null;
        internal string AmazonSiteURL = null;
        internal string productName = null;
        internal double price = -1;

        internal XDocument matchingProduct = null;
        internal XDocument competitivePricing = null;
        internal XDocument lowestOfferListings = null;
        internal XDocument myPrice = null;
        internal XDocument productCategories = null;
    }
}