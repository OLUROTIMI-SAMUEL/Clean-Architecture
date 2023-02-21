using CleanMovieDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure;

    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
            
        }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //One to Many relationship Linking (Member and Rentals)
        modelBuilder.Entity<Member>().HasOne<Rental>(s => s.Rental).WithMany(r => r.Members).HasForeignKey(s => s.RentalId);

        //Many to Many (Rental and Movie)
        modelBuilder.Entity<MovieRental>().HasKey(g => new { g.RentalId, g.MovieId });

        //Handle Decimals to avoid precition loss 
        modelBuilder.Entity<Rental>().Property(p => p.TotalCost).HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Movie>().Property(p => p.RentalCost).HasColumnType("decimal(18,2)");
    }

    //so our migration will go through the data base context and see if there are any classes for it to create a table if there is it will create it
    public DbSet<Movie>Movies { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MovieRental> MoviesRentals { get; set; }
}

