using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models.Pizzas
{
  /// <summary>
  /// 
  /// </summary>
  public class MeatPizza : APizza
  {
    /// <summary>
    /// 
    /// </summary>
    public override void AddCrust(Crust crust)
    {
      Crust = new Crust() { Name = "Stuffed", Price = 5.00M };
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddSize(Size size)
    {
      Size = new Size() { Name = "Medium", Price = 10.00M };
    }

    /// <summary>
    /// 
    /// </summary>
    public override void AddToppings(params Topping[] toppings)
    {
      Toppings = new List<Topping>()
      {
        new Topping() { Name = "Ricotta", Price = 1.00M},
        new Topping() { Name = "Bolognese", Price = 1.00M}
      };
    }
  }
}
