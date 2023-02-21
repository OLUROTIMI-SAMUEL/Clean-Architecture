using CleanMovie.Application;
using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        //So here we will just have a list that will have the movies
        //So infrastructure will now be responsible for how data is retrieved form & how data is done
        //so INFRASTRUCUTRE WILL find a way to find the needs of the appliction.
        //So our infrastructure project is now responsible for the external implenentation. 

        //public static List<Movie> movies = new List<Movie>()
        //{
        //  new Movie {Id = 1, Name = "The Lord's Choosen", Cost = 2 },
        //  new Movie {Id = 2, Name = "The Advengers", Cost = 1 }
        //};
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext) // so here our repository depends on the "MovieDbContext"
        {
            _movieDbContext = movieDbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);//so get me the movie Db Context then go to movies and Add then specifically add for me the "movie"
            _movieDbContext.SaveChanges();
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return  _movieDbContext.Movies.ToList();// get me all movies in list format
        }
    }
}


//So we want the domain to be independent so that we can remove the domain and put into other application
//So our our Infrastructure here Is where we are doing the actual operation where we talk to the data base, talk to another API,
//Taking to file system.Any thing external to your domin will be done in your infrastructure.

//Also note the Domain does not depend on anything,
//The Application Depends on the domain.
//The Infrastructure depends on the application , So this means that ther domain only talks to the appliction will the rest could talk through 
//transeint dependency.
