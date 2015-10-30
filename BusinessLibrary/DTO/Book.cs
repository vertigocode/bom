using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp.Deserializers;

namespace BusinessLibrary.DTO
{
    public class GoodReads
    {
        public Search Search { get; set; }
    }

    public class Search
    {
        public Results Results { get; set; }
    }

    public class Results
    {
        public List<Work> Works { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class BestBook
    {
        [DeserializeAs(Name = "title")]
        public string Title { get; set; }

        [DeserializeAs(Name = "image_url")]
        public string ImageUrl { get; set; }

        public Author Author { get; set; }
    }

    public class Work
    {
        [DeserializeAs(Name = "average_rating")]
        public double Rating { get; set; }

        public BestBook BestBook { get; set; }
    }

    public class Book
    {
        public Book()
        {
            Ratings = new List<Rating>();
        }

        public string Title { get; set; }

        public IList<Rating> Ratings { get; set; } 

        public string ImageUrl { get; set; }

        public string Author { get; set; }
    }
}
