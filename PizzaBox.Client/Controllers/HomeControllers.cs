using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  [Route('[controllers]/[action]')]
  // [Route('[controllers]')] 

  public class HomeController : Controllers
  {
    [HttpGet]
    public IActionResult Index()
    {
      ViewBag.Order = new OrderViewmodel();
      // Weak Type view = trusting action will lead to right model
      // ^ ViewData/Viewbag(1-way flow of action to view)
      // ^ TempData (remain avaible long as same request is there) Like google login to FB

      // Strong type view: demands fro aspecfici model
      return View();
    }
  }
}