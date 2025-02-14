using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MRent.Models;

namespace MRent.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customer {  get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<RentalDetail> RentalDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>().ToTable(nameof(Customer));
            builder.Entity<Movie>().ToTable(nameof(Movie));
            builder.Entity<Rental>().ToTable(nameof(Rental));
            builder.Entity<RentalDetail>().ToTable(nameof(RentalDetail));

            builder.Entity<Rental>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Rental)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Rental>()
                .HasMany(r => r.RentalDetail)
                .WithOne(rd => rd.Rental)
                .HasForeignKey(rd => rd.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Rental>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Rental)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<RentalDetail>()
               .HasOne(rd => rd.Rental)
               .WithMany(r => r.RentalDetail)
               .HasForeignKey(rd => rd.MovieId)
               .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
