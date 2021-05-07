using System;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class StoreRepo : IRepo<AStore>
  {
    private readonly PizzaBoxContext _context;
    public StoreRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<AStore> Select(Func<AStore, bool> filter)
    {
      return _context.Stores.Where(filter);
    }
    public bool Insert(AStore entry)
    {
      throw new System.NotImplementedException();
    }

    public AStore Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}