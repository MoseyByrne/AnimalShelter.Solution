using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
      : base (options)
      {
      }
    public DbSet<Animal> Animals { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Matilda", Species = "Cat", Age = 7, Gender = "Female" },
              new Animal { AnimalId = 2, Name = "Rexie", Species = "Dog", Age = 10, Gender = "Female" },
              new Animal { AnimalId = 3, Name = "Matilda", Species = "Dog", Age = 2, Gender = "Female" },
              new Animal { AnimalId = 4, Name = "Pip", Species = "Cat", Age = 4, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Turtle", Age = 22, Gender = "Male" }
          );
    }
  }
}