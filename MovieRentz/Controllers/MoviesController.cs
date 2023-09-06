using Microsoft.AspNetCore.Mvc;
using MovieRentz.Models;
using MovieRentz.ViewModels;

namespace MovieRentz.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "RRR" };
            var customers = new List<Customer>()
            {
                new Customer{Name="Sri"},
                new Customer{Name="Sai"},
                new Customer{Name="Maddy"}

            };

            var randomMovieViewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovieViewModel);
        }



        //public ActionResult Edit(int movieId)
        //{
        //    return Content($"Id: {movieId}");
        //}

        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if(!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
        //    return Content( $"pageIndex: {pageIndex} sortBy:{sortBy}" );
        //}
        //[Route("movies/released/{year}/{month}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);  
        //}
    }
}
