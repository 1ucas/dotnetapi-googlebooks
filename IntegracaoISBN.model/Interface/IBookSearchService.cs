using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IntegracaoISBN.Model;

namespace IntegracaoISBN.model.Interface
{
    public interface IBookSearchService
    {
        Task<BookDTO> SearchISBN(string isbn);
    }
}