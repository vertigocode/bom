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
    public class MovieRetrievalServiceTests
    {
        private IMovieRetrievalService service = new MovieRetrievalService();

        [Test]
        public void RetrieveMovieShouldPass()
        {
            var result = service.RetrieveTitle("Forrest Gump");
            Assert.IsTrue(result != null);
            Assert.IsTrue(result.First().Title == "Forrest Gump");
        }
    }
}
