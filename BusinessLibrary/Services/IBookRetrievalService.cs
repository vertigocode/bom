using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLibrary.DTO;

using RestSharp;
using RestSharp.Deserializers;

namespace BusinessLibrary.Services
{
    public interface IBookRetrievalService
    {
        IList<Book> RetrieveTitle(string name);
    }

    public class BookRetrievalService : IBookRetrievalService
    {
        private const string BooksDBUrl = "https://www.goodreads.com";

        private const string DevApiKey = "Rp08GkL5vajjbl0a358PbQ";

        public IList<Book> RetrieveTitle(string name)
        {
            var result = new List<Book>();

            var client = new RestClient(BooksDBUrl);
            var request = new RestRequest("/search/index.xml", Method.GET);
            request.AddParameter("key", DevApiKey);
            request.AddParameter("q", name);
            request.AddParameter("search[field]", "title");
            request.RequestFormat = DataFormat.Xml;

            var response = client.Execute<GoodReads>(request);
            result.AddRange(response.Data.Search.Results.Works.Select(w => new Book { Title = w.BestBook.Title, Ratings = new List<Rating> {new Rating {Name = "GoodReads", Rate = w.Rating, MaxRate = 5}},ImageUrl = w.BestBook.ImageUrl, Author = w.BestBook.Author.Name}));

            return result;
        }
    }
}
