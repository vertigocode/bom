using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp.Deserializers;

namespace BusinessLibrary.DTO
{
    public class Movie
    {
        public Movie()
        {
            Ratings = new List<Rating>();
        }

        [DeserializeAs(Name = "Title")]
        public string Title { get; set; }

        [DeserializeAs(Name = "imdbRating")]
        public double Rating { get; set; }

        [DeserializeAs(Name = "Poster")]
        public string ImageUrl { get; set; }

        public string Director { get; set; }

        public IList<Rating> Ratings { get; set; } 
    }
}
