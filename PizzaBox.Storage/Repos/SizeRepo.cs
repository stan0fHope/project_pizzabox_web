using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class SizeRepo : IRepo<Size>
  {
    private readonly PizzaBoxContext _context;
    public SizeRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
    }

    public bool Insert(Size entry)
    {
      throw new System.NotImplementedException();
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();

    }

  }
}