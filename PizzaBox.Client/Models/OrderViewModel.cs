using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repos;
// input-output model

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    // Display options
    public List<Crust> Crusts { get; set; } // fillout with repos
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }

    public List<Store> Stores { get; set; }

    // Selected option
    [Required(ErrorMessage = "ra ra ra")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "re re re")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "ri ri ri")]
    public List<string> SelectedToppings { get; set; }


    [Required(ErrorMessage = "ru ru ru")]
    public string SelectedStore { get; set; }


    [Required(ErrorMessage = "ry ry ry")]
    public string CustomerFirst { get; set; }

    [Required(ErrorMessage = "ry ry ry")]
    public string CustomerLast { get; set; }


    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Toppings = unitOfWork.Toppings.Select(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
      Stores = unitOfWork.Stores.Select(st => !string.IsNullOrWhiteSpace(st.Name)).ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("IS you crasy!", new[] { "SelectedToppings" });
      }
    }

  }
}