using System.Threading.Tasks;
using System.Web.Http;
using IntegracaoISBN.model.Interface;
using IntegracaoISBN.Model;

namespace IntegracaoISBN.Controllers
{
    [RoutePrefix("api/private/v1")]
    public class ISBNController : ApiController
    {
        private readonly IBookSearchService _bookSearchService;
        public ISBNController(IBookSearchService bookSearchService)
        {
            _bookSearchService = bookSearchService;
        }
        [HttpGet]
        [Route("Isbn")]
        public async Task<BookDTO> Get(string isbn)
        {
            return await _bookSearchService.SearchISBN(isbn);
        }
    }
}
