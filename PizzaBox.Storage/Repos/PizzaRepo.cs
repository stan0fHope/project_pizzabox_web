using System;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storage.Repos
{
  public class PizzaRepo : IRepo<APizza>
  {
    private readonly PizzaBoxContext _context;
    public PizzaRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<APizza> Select(Func<APizza, bool> filter)
    {
      return _context.Pizzas.Where(filter);
    }
    public bool Insert(APizza entry)
    {
      throw new System.NotImplementedException();
    }

    public APizza Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}