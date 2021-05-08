using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public List<Pizza> Pizzas { get; set; }
    // not ICollection<> because: 
    public decimal TotalCost
    {
      get
      {
        return Pizzas.Sum(t => t.TotalPrice);
      }
    }
  }
}