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
    public class ISBNController : ApiController
    {
        // GET: api/ISBN
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ISBN/5
        public async System.Threading.Tasks.Task<BookDTO> Get(string isbn)
        {
            return await new BookSearchService().SearchISBN(isbn);
        }

        // POST: api/ISBN
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ISBN/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ISBN/5
        public void Delete(int id)
        {
        }
    }
}
