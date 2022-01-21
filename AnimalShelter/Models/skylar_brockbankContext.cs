using Microsoft.EntityFrameworkCore;
namespace AnimalShelter.Models
{
  public class skylar_brockbankContext : DbContext
  {
    public skylar_brockbankContext(DbContextOptions<skylar_brockbankContext> options): base(options)
    {}

    public DbSet<Animal> Animals {get;set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>().HasData(
        new Animal {AnimalId = 1, Name = "Doug The Dog", Sex="M", Age=6, Type = "cat"},
        new Animal {AnimalId = 2, Name = "Cleocatra", Sex="F", Age=4, Type = "cat"},
        new Animal {AnimalId = 3, Name = "Barkus Aurelius", Sex="M", Age=8, Type = "dog"},
        new Animal {AnimalId = 4, Name = "Droolius Caeser", Sex="M", Age=5, Type = "dog"},
        new Animal {AnimalId = 1, Name = "Ada Loves-Laces", Sex="F", Age=6, Type = "cat"}
      );
    }
  }
}