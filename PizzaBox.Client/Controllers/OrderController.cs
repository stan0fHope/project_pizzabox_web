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
  [Route("[controller]")]
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
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Select(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();

        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Select(t => t.Name == item).First());
        }

        var newPizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };
        var store = _unitOfWork.Stores.Select(st => st.Name == order.SelectedStore).First();
        var customer = new Customer { FirstName = order.CustomerFirst, LastName = order.CustomerLast };
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza }, Customer = customer, Store = store };

        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;

        return View("checkout"); //if valid, go to this page
      }
      order.Load(_unitOfWork);

      return View("order", order);
    }

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

  }
}