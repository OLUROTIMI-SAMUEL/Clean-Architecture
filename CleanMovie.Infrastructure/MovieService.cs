//using cleanmoviedomain;
//using system;
//using system.collections.generic;
//using system.componentmodel.design;
//using system.linq;
//using system.reflection.metadata;
//using system.text;
//using system.threading.channels;
//using system.threading.tasks;

//namespace cleanmovie.application
//{
//    public class movieservice : imovieservice



//    //so our movieservice will do the actual implenentation but for thinds like data access which are not
//    //handled by the application program they will be handled by the infrastucture program.so our movieservice will call the infrastrucure to that
//    {
//        private readonly imovierepository movierepository;

//        //the "readonly" keyword indicates that the value of "movierepository" cannot be changed after it is initialized.the use of the "readonly"
//        //keyword suggests that the "movierepository" field is set once and used throughout the class, and that its value should not be changed during
//        //  the lifetime of the object. also this code suggests that the class using this field is dependent on the functionality provided by the
//        // "imovieservice" interface, and that the concrete implementation of the service is injected into the class through this field.


//        //so here we create a constructor dependency injection
//        public movieservice(imovierepository movierepository)
//        {
//            this.movierepository = movierepository;
//            // this code suggests that the "movieservice" class is designed to depend on an implementation of the "imovieservice" interface,
//            //  and that this implementation is injected into the class through the constructor parameter.the use of constructor injection allows
//            // the class to be easily tested and decoupled from the specific implementation of the service it depends on.
//        }

//        public movie createmovie(movie movie)
//        {
//            //so we make use of the movierepository which is in the infrastructure
//            movierepository.createmovie(movie);
//            return movie;
//        }

//        //so our movieservice class implemented "the use case" from the imovieservice class. so instead of the moviessevice class goiing it self to the
//        // data base to fetch data it has deligated, or made an interface to do that on it behalf which is the imovieservice.
//        public list<movie> getallmovies(list<movie> movies)
//        {
//            // so for us to get all movie we say
//            var movies = movierepository.getallmovies();//the code is assigning the collection of movies returned by "getallmovies()" to a variable called "movies".
//            return movies;

//        }
//    }
//}
