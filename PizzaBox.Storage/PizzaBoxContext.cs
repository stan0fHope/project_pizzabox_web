using System;
using System.Collections;
using System.Collections.Generic;
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

    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }
    // ^ configs can be injected in
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);
      builder.Entity<Pizza>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Store>().HasKey(e => e.EntityId);
      builder.Entity<Customer>().HasKey(e => e.EntityId);

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

      builder.Entity<Store>().HasData(new[]
      {
        new Store() { EntityId = 1, Name = "NYCheesy"},
        new Store() { EntityId = 2, Name = "Detriot City Slice"},
        new Store() { EntityId = 3, Name = "Chicago Gettas"},
        new Store() { EntityId = 4, Name = "Pizzaria Nuevo"}
      });

      builder.Entity<Customer>().HasData(new[]
      {
        new Customer() { EntityId = 1, FirstName = "Fabio", LastName = "Santigo"},
        new Customer() { EntityId = 2, FirstName = "Shantel", LastName = "Okinawa"},
        new Customer() { EntityId = 3, FirstName = "Marshall", LastName = "Brickbend"},
        new Customer() { EntityId = 4, FirstName = "Bobby", LastName = "Holland"}
      });
    }
  }
}