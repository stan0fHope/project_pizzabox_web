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
      return View();
    }
  }
}