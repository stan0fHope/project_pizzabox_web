using System;
using System.Linq;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class ToppingRepo : IRepo<Topping>
  {
    private readonly PizzaBoxContext _context;
    
    public ToppingRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Topping> Select(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
    }
    public bool Insert(Topping entry)
    {
      throw new System.NotImplementedException();
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();

    }

  }
}