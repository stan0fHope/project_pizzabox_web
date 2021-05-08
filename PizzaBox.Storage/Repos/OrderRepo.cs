using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class OrderRepo : IRepo<Order>
  {
    private readonly PizzaBoxContext _context;
    public OrderRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Order> Select(Func<Order, bool> filter)
    {
      // get ball rolling
      throw new System.NotImplementedException();
    }

    public bool Insert(Order entry)
    {
      _context.Orders.Add(entry);
      return true;
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}