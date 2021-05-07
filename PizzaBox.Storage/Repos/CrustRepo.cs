using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class CrustRepo : IRepo<Crust>
  {
    private readonly PizzaBoxContext _context;
    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      // get ball rolling
      return _context.Crusts.Where(filter);
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();

    }

  }
}