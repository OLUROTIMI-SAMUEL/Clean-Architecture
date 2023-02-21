using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public class MovieService : IMovieService  //So our MovieService will do the actual implenentation but for thinds like Data access which are not
    //handled by the Application Program they will be handled by the Infrastucture Program. So our Movieservice will call the infrastrucure to that
    {
        private readonly IMovieRepository _movieRepository;

        //The "readonly" keyword indicates that the value of "movieRepository" cannot be changed after it is initialized. The use of the "readonly"
        //keyword suggests that the "movieRepository" field is set once and used throughout the class, and that its value should not be changed during
        //the lifetime of the object. Also this code suggests that the class using this field is dependent on the functionality provided by the
        //"IMovieService" interface, and that the concrete implementation of the service is injected into the class through this field.


        //So here we create a Constructor Dependency Injection
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
          //  This code suggests that the "MovieService" class is designed to depend on an implementation of the "IMovieService" interface,
          //  and that this implementation is injected into the class through the constructor parameter.The use of constructor injection allows
          //  the class to be easily tested and decoupled from the specific implementation of the service it depends on.
        }

        public Movie CreateMovie(Movie movie)
        {
            //So we make use of the movieRepository which is in the infrastructure 
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        //So our MovieService CLass Implemented "The use case" from the IMovieService Class. So instead of the MoviesSevice class goiing it self to the
        //Data base to fetch data it has deligated, or made an Interface to do that on it behalf which is the IMovieService.
        public List<Movie> GetAllMovies()
        {
            //so for us to get all movie we say
            var movies = _movieRepository.GetAllMovies();
            return movies;
            //The code is assigning the collection of movies returned by "GetAllMovies()" to a variable called "movies".



        }
    }
}
