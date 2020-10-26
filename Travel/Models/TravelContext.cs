using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Review>()
              .HasData(
                  new Review { ReviewId = 1, ReviewDetails = "Eh", Country = "USA", City = "Seattle", Rating = 3 },
                  new Review { ReviewId = 2, ReviewDetails = "Crazy people", Country = "USA", City = "Portland", Rating = 3 },
                  new Review { ReviewId = 3, ReviewDetails = "Fun", Country = "USA", City = "Hawaii", Rating = 5 },
                  new Review { ReviewId = 4, ReviewDetails = "Nice", Country = "South Africa", City = "Cape Town", Rating = 4 },
                  new Review { ReviewId = 5, ReviewDetails = "Ugh", Country = "China", City = "Beijing", Rating = 1 }
              );
        }
    }
}