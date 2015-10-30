using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLibrary.Services;

using NUnit.Framework;

namespace BusinessLibrary.Tests.IntegrationTests
{
    [TestFixture]
    public class BookRetrievalServiceTests
    {
        private IBookRetrievalService service = new BookRetrievalService();

        [Test]
        public void RetrieveBookShouldPass()
        {
            var result = service.RetrieveTitle("Forrest Gump");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.First().Title.Contains("Forrest Gump"));
        }
    }
}
