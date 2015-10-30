using BusinessLibrary.DTO;

namespace BusinessLibrary.Services
{
    public interface ITitleRetrieveService
    {
        TitleSearchResult RetrieveTitle(string title);
    }

    public class TitleRetrieveService : ITitleRetrieveService
    {
        private readonly IBookRetrievalService bookRetrievalService;

        private readonly IMovieRetrievalService movieRetrievalService;

        public TitleRetrieveService(IBookRetrievalService bookRetrievalService, IMovieRetrievalService movieRetrievalService)
        {
            this.bookRetrievalService = bookRetrievalService;
            this.movieRetrievalService = movieRetrievalService;
        }

        public TitleSearchResult RetrieveTitle(string title)
        {
            var result = new TitleSearchResult();

            result.Movies = movieRetrievalService.RetrieveTitle(title);
            result.Books = bookRetrievalService.RetrieveTitle(title);

            return result;
        }
    }


}