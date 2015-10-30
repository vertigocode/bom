using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.DTO
{
    public class TitleSearchResult
    {
        public IList<Movie> Movies { get; set; }
        public IList<Book> Books { get; set; }
    }
}
