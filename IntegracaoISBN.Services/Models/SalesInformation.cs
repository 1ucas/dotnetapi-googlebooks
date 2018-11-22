using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Books.v1.Data;

namespace IntegracaoISBN.Services.Models
{
    public class SalesInformation
    {
        public string Link { get; set; }
        public double ListPrice { get; set; }
        public bool Avaiable { get; set; }

        public static SalesInformation From(Volume.SaleInfoData saleInfo)
        {
            return new SalesInformation
            {
                Link = saleInfo.BuyLink,
                ListPrice = saleInfo.Saleability == "FOR_SALE" ? saleInfo.ListPrice.Amount.Value : 0,
                Avaiable = saleInfo.Saleability == "FOR_SALE"
            };
        }
    }
}
