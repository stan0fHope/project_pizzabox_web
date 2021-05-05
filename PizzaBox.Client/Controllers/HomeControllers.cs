using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage.Repos;

namespace PizzaBox.Client.Controllers
{
  [Route('[controllers]/[action]')]
  // [Route('[controllers]')] 

  public class HomeController : Controllers
  {
    private readonly UnitOfWork _unitOfWork = new UnitOfWork();
    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      ViewBag.Order = new OrderViewModel();
      // Weak Type view = trusting action will lead to right model
      // ^ ViewData/Viewbag(1-way flow of action to view)
      // ^ TempData (remain avaible long as same request is there) Like google login to FB
      // Strong type view: demands fro aspecfici model

      var view = View("index", new OrderViewModel(_unitOfWork));
      // have the controller handle the controller
      // we dont manage/set pricing for uber, we just call it 
      // if we dont instantite homecontroler, we shouldnt for unitofwork 
      return View();
    }
  }
}