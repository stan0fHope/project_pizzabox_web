using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    public DbSet<APizza> Pizzas { get; set; }
    public DbSet<AStore> Stores { get; set; }

    public DbSet<Order> Orders { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }
    // ^ configs can be injected in
    protected override void OnModelCreating(ModelBuilder builder)
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
        new Crust() { EntityId = 1, Name = "original", Price = 5.00M },
        new Crust() { EntityId = 2, Name = "stuffed", Price = 7.00M },
        new Crust() { EntityId = 3, Name = "flatbread", Price = 6.50M}
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "small", Price = 7.00M },
        new Size() { EntityId = 2, Name = "medium", Price = 10.00M},
        new Size() { EntityId = 3, Name = "large", Price = 14.00M}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "pepperoni", Price = 1.50M},
        new Topping() { EntityId = 2, Name = "pineapple", Price = 2.50M},
        new Topping() { EntityId = 3, Name = "ham", Price = 1.50M },
        new Topping() { EntityId = 4, Name = "green peppers", Price = 1.25M},
        new Topping() { EntityId = 5, Name = "black olives", Price = 1.75M}
      });
    }
  }
}