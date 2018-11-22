using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using IntegracaoISBN.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegracaoISBN.Services
{
    public class BookSearchService
    {
        private BooksService bookService { get; }

        public BookSearchService()
        {
            bookService = new BooksService(new BaseClientService.Initializer
            {
                ApplicationName = "ISBNBookSearch",
                ApiKey = "",
            });
        }

        public async Task<BookDTO> SearchISBN(string isbn)
        {
            Debug.WriteLine("Executing a book search request for ISBN: {0} ...", isbn);
            var result = await bookService.Volumes.List(isbn).ExecuteAsync();

            if (result != null && result.Items != null)
            {
                Volume item = result.Items.FirstOrDefault();
                BookDTO dto = BookDTO.From(item);
                return dto;
            }
            return null;
        }
    }
}
