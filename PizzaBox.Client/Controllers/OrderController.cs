using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models.\;


namespace PizzaBox.Client.Controllers
{
  [Route("[controller")]
  public class OrderController : Controllers
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]

    public string Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return order.SelectedCrust;
        return View("checkout"); //if valid, go to this page
      }
      return View("index", order)
    }      

    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return order.SelectedCrust;
        return View("checkout"); //if valid, go to this page
      }
      return View("index", order)
    }
    
  }
}