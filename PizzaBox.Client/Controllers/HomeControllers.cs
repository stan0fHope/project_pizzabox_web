using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repos;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      // Weak Type view = trusting action will lead to right model
      // ^ ViewData/Viewbag(1-way flow of action to view)
      // ^ TempData (remain avaible long as same request is there) Like google login to FB
      // Strong type view: demands fro aspecfici model

      var some = new OrderViewModel();
      some.Load(_unitOfWork);
      // have the controller handle the controller
      // we dont manage/set pricing for uber, we just call it 
      // if we dont instantite homecontroler, we shouldnt for unitofwork 
      return View("index", some);
    }
  }
}