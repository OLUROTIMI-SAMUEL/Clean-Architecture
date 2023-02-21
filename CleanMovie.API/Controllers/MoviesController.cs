using CleanMovie.Application;
using CleanMovieDomain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanMovie.API.Controllers //So our API does not care about the Infrastructure Program it onlt cares about the services it is the service(Application Program) 
    //that will care about the Infrastructure Program
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;
        public MoviesController(IMovieService service)
        {
           _service = service;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult <List<Movie>> Get() // The ActionResult class is a generic class that allows for returning different types of results
                                                // from an action, including HTTP status codes, error messages, and content. The lack of any parameters
                         // in the method signature(Get() ) suggests that this endpoint will return a full list of all movies available in the system.
        {
            var moviesFromService = _service.GetAllMovies();//so this line of code means This code suggests that there is an object called "service"
            //that has a method called "GetAllMovies()" which returns a collection of movies. The code is assigning the collection of movies returned by
   //"GetAllMovies()" to a variable called "moviesFromService". "Service" refers to an instance of a class that implements the "IMovieService" interface.
            return Ok(moviesFromService);
        }
        [HttpPost]
        public ActionResult <Movie> PostMovie (Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(movie);
        }

        
    }
}

//So our controller here does not depend on the repository in this case rather it depends on the IMovieService which is uder the application layer 
//and the movie service dictate a bussiness logic. So for us to Invoke this bussiness logic via the API then it has to go to the application layer 
//
