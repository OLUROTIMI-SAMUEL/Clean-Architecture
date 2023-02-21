using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{//This is a use case 
    public interface IMovieService  // so our IMovieService just dectate the contract or used cases
    {
        //So our IMovieService will dictate the logic that is needed in our application 
        List<Movie> GetAllMovies();// So the sevice here will responsible for defining the business case and also implementing how that business case 
        //should be done

        Movie CreateMovie(Movie movie); //so the interface will be our use cases. 
    }

    //So our IMovieService will be impleneted in the application layer to show us how we intead to do that use case. 
}
