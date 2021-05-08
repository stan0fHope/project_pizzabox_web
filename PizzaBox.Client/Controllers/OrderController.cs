using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repos;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]


    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust.Name).First();
        var size = _unitOfWork.Sizes.Select(s => s.Name == order.SelectedSize.Name).First();
        var toppings = new List<Topping>();

        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Select(t => t.Name == item.Name).First());
        }

        var newPizza = new APizza { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;

        return View("checkout"); //if valid, go to this page
      }
      return View("index", order);
    }

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }


  }
}