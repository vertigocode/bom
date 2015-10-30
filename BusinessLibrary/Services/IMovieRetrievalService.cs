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
    public interface IMovieRetrievalService
    {
        IList<Movie> RetrieveTitle(string name);
    }

    public class MovieRetrievalService : IMovieRetrievalService
    {
        private const string MovieDBUrl = "http://www.omdbapi.com";

        public IList<Movie> RetrieveTitle(string name)
        {
            var result = new List<Movie>();

            var client = new RestClient(MovieDBUrl);
            var request = new RestRequest("/?", Method.GET);
            request.AddParameter("t", name);
            request.AddParameter("plot", "short");
            request.AddParameter("r", "json");

            var jsonDeserializer = new JsonDeserializer();

            var response = client.Execute(request);

            var movie = jsonDeserializer.Deserialize<Movie>(response);

            var rating = new Rating { MaxRate = 10, Rate = movie.Rating, Name = "imdb" };

            movie.Ratings.Add(rating);

            result.Add(movie);

            return result;
        }
    }
}
