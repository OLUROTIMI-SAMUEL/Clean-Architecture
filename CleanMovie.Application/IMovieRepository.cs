using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();// So this is where we get our Data

        Movie CreateMovie(Movie movie); //So here we also create a movie 
    }
}

//So this repository will be concerned with your data access. 
//Note interfaces do not have access modifiers implemented in them so they do not have public or private in them