using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    // Cover by the Injection, same as project0
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<Order> Orders { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }
    // ^ configs can be injected in
    protected override void OnModelCreating(ModelBuilder builders)
    {
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<APizza>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }
    private void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityId = 1, Name = "original" },
        new Crust() { EntityId = 2, Name = "stuffed" },
        new Crust() { EntityId = 3, Name = "flatbread" },
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "small" },
        new Size() { EntityId = 2, Name = "medium" },
        new Size() { EntityId = 3, Name = "large"}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "pepperoni" },
        new Topping() { EntityId = 2, Name = "pineapple" },
        new Topping() { EntityId = 3, Name = "ham" },
        new Topping() { EntityId = 4, Name = "green peppers" },
        new Topping() { EntityId = 5, Name = "black olives" }
      });
    }
  }
}