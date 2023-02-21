namespace CleanMovieDomain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public decimal TotalCost { get; set; }

        //Linking One to many Relationship to Menber class which has the "Many Property"
        public ICollection<Member> Members { get; set; }

        //So here we are having Many to many relationship with the Movie class & this Rental class as well
        public IList<MovieRental> MovieRentals { get; set; }

    }
}