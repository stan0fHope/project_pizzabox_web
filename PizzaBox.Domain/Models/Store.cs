using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Store : Entity
  {
    public List<Order> Orders { get; set; }
    public string Name { get; set; }
  }
}