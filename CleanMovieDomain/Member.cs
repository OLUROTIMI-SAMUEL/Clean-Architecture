using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovieDomain
{
    public class Member
    {

        public int MemberId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //Linking One to Many Relationship
        public int RentalId {get; set;}

        public Rental Rental { get; set; } //So the class Rental is the one relationship while class "member" is the many to 
        //many relationship. 
    }
}
