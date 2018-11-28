using System;
using Google.Apis.Books.v1.Data;
using Newtonsoft.Json;

namespace IntegracaoISBN.Model
{
    public class BookDTO
    {
        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        [JsonProperty("SaleInfo")]
        public SalesInformation SaleInfo { get; set; }

        public string Title { get; set; }

        public static BookDTO From(Volume volume)
        {
            return new BookDTO
            {
                ISBN = volume.Id,
                SaleInfo = SalesInformation.From(volume.SaleInfo),
                Title = volume.VolumeInfo.Title
            };
        }
    }
}
