using ProductInfoFromASIN.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProductInfoFromASIN
{
    internal class ProductInfoTableCreator
    {
        private XNamespace ns = "http://mws.amazonservices.com/schema/Products/2011-10-01";
        private XNamespace ns2 = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd";

        internal void Start(ProductInfoDataGridView productInfoDataGridView, List<AmazonProductInfo> productInfoList)
        {
            //productInfoDataGridView.BeginEdit(true);
            productInfoDataGridView.Rows.Clear();

            foreach (var productInfo in productInfoList)
            {
                try
                {
                    var row = new DataGridViewRow();

                    row.CreateCells(productInfoDataGridView);

                    row.Cells[0].Value = productInfo.matchingProduct.Descendants(ns + "ASIN").SingleOrDefault().Value;
                    row.Cells[2].Value = productInfo.matchingProduct.Descendants(ns2 + "URL").SingleOrDefault().Value; //Image URL
                    row.Cells[3].Value = "http://www.amazon.co.jp/o/ASIN/" + row.Cells[0].Value + "/"; //Product URL
                    row.Cells[4].Value = productInfo.productCategories.Descendants(ns + "ProductCategoryName").FirstOrDefault().Value;    //Category
                    row.Cells[5].Value = productInfo.matchingProduct.Descendants(ns + "Rank").FirstOrDefault().Value;    //Amazon Ranking
                    row.Cells[6].Value = productInfo.competitivePricing.Descendants(ns + "Amount").FirstOrDefault().Value.ToString().Split('.')[0];    //Price in Japan

                    row.Height = 100;

                    productInfoDataGridView.Rows.Add(row);
                }
                catch (Exception e)
                {
                    continue;
                }
            }
            productInfoDataGridView.Configuration();
            //productInfoDataGridView.Columns[2].Visible = false;
        }

        //private List<AmazonProductInfo> CreateProductInfoList(List<AmazonProductInfo> productInfoList)
        //{
        //    XNamespace ns = "http://mws.amazonservices.com/schema/Products/2011-10-01";
        //    XNamespace ns2 = "http://mws.amazonservices.com/schema/Products/2011-10-01/default.xsd";

        //    var amazonProductInfoList = new List<AmazonProductInfo>();

        //    foreach (var product in amazonProductInfoList)
        //    {
        //        var productInfo = new AmazonProductInfo();
        //        productInfo.ASIN = xml.Descendants(ns + "ASIN").SingleOrDefault().Value;
        //        productInfo.imageURL = xml.Descendants(ns2 + "URL").SingleOrDefault().Value;
        //        productInfoList.Add(productInfo);
        //    }

        //    return productInfoList;
        //}
    }
}