using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
    public long CustomerEntityID { get; set; }
    public Store Store { get; set; }
    public long StoreEntityID { get; set; }
    public decimal TotalCost
    {
      get
      {
        return Pizzas.Sum(t => t.TotalPrice);
      }
    }


  }
}