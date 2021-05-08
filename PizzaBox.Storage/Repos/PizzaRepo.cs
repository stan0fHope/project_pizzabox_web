using System;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;


namespace PizzaBox.Storage.Repos
{
  public class PizzaRepo : IRepo<Pizza>
  {
    private readonly PizzaBoxContext _context;
    public PizzaRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Pizza> Select(Func<Pizza, bool> filter)
    {
      return _context.Pizzas.Where(filter);
    }
    public bool Insert(Pizza entry)
    {
      throw new System.NotImplementedException();
    }

    public Pizza Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

  }
}