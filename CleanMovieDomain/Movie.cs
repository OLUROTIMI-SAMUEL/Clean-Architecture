using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieDomain
{
     public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        //So here we are having Many to many relationship with the Member class & this Movie class
        public IList <MovieRental> MovieRentals { get; set; }
       
        //so this simply means that at our core domain evrey system is going to have this characteristics 
    }
    //Whatis a domain in a clean archictecture design
    //Domain are the things we can do with or without software. Domain does not depend on any other project 
}


//In a Clean Architecture design, a domain refers to the core business logic of an application. It represents the most fundamental and
//important part of the application, as it defines the rules and behavior of the system.
//The domain layer is isolated from the technical details and concerns of the rest of the application,such as the user interface or the infrastructure
//used to store data. This separation allows the domain to be developed and tested independently of other parts of the system.
//The domain layer typically consists of entities, which represent the core concepts of the business domain, as well as use cases, which define the
//actions that can be performed on those entities. The domain layer is responsible for enforcing the business rules and ensuring the consistency
//and integrity of the data.
//In a Clean Architecture design, the domain layer is the most important and complex part of the system, and it is usually the part that changes the least over time.
//This is because the business rules and logic are usually stable, while the technical details and requirements of the system may change more frequently.





//An appliction is the layer where we have the bussiness logic. But at the domain level every business logic use the same domain 
//So an application lager is that layer that dictate how the bussiness logic of an application should be, and an application layer depends only on the domain
//Layer. 