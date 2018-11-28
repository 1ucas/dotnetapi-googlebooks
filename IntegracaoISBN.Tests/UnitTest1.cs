using System.Threading.Tasks;
using IntegracaoISBN.model.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace IntegracaoISBN.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string isbn = "0071807993";
            Mock<IBookSearchService> mock = new Mock<IBookSearchService>();
            mock.Setup(m => m.SearchISBN(isbn)).Returns(Task.FromResult(
                new Model.BookDTO()
                {
                    ISBN = isbn,
                    Title = "teste",
                    SaleInfo = new Model.SalesInformation()
                    {
                        Avaiable = true,
                        Link = "teste.com.br",
                        ListPrice = 10.0
                    }
                }
             ));
            
            var output =  mock.Object.SearchISBN(isbn);
            Assert.AreEqual(output.Result != null, true);

        }
    }
}
