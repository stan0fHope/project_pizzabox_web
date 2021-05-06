using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
  public class OrderRepo : IRepo<Order>
  {
    public IEnumerable<Order> Select()
    {
      return new List<Order> { new Order(), new Order() };
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
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