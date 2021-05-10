using System;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class CustomerRepo : IRepo<Customer>
  {
    private readonly PizzaBoxContext _context;
    public CustomerRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Customer> Select(Func<Customer, bool> filter)
    {
      return _context.Customers.Where(filter);
    }

    public bool Insert(Customer entry)
    {
      throw new System.NotImplementedException();
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}