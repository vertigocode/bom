using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BomWeb.Models;

using BusinessLibrary.Services;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BomWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRetrievalService movieRetrievalService;

        private readonly IBookRetrievalService bookRetrievalService;

        public HomeController(IMovieRetrievalService movieRetrievalService, IBookRetrievalService bookRetrievalService)
        {
            this.movieRetrievalService = movieRetrievalService;
            this.bookRetrievalService = bookRetrievalService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchTitle(string title)
        {
            var books = bookRetrievalService.RetrieveTitle(title);
            var movies = movieRetrievalService.RetrieveTitle(title);

            var result = new TitleVM { Movies = movies, Books = books, Title = title};

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var jsonResult = new ContentResult
                                 {
                                     Content = JsonConvert.SerializeObject(result, camelCaseFormatter),
                                     ContentType = "application/json"
                                 };

            return jsonResult;
        }
    }
}