using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;

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
        return order.SelectedCrust;
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