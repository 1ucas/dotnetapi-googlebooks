using IntegracaoISBN.Services;
using IntegracaoISBN.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntegracaoISBN.Controllers
{
    [RoutePrefix("api/ISBN")]
    public class ISBNController : ApiController
    {
        [HttpGet]
        [Route("isbn")]
        public async System.Threading.Tasks.Task<BookDTO> Get(string isbn)
        {
            return await new BookSearchService().SearchISBN(isbn);
        }
    }
}
