using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BusinessLibrary.DTO;

namespace BomWeb.Models
{
    public class TitleVM
    {
        public string Title { get; set; }
        public IList<Movie> Movies { get; set; }
        public IList<Book> Books { get; set; }
    }
}