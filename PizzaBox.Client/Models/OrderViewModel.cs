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
    // strings are placeholder for test-running
    public List<Crust> Crusts { get; set; } // fillout with repos
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Toppings = unitOfWork.Toppings.Select(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
    }

    // Selected option
    [Required(ErrorMessage = "ra ra ra")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "ri ri ri")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "ru ru ru")]
    [Range(2, 5)]
    public List<string> SelectedToppings { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      // var validResults = new List<ValidationResult>();
      if (SelectedCrust == SelectedSize)
      {
        yield return new ValidationResult("IS you crasy!", new string[] { "SelectedCrust", "SelectedSize" });
        // call an uber, yield brings records at end
      }

      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("IS you crasy!", new[] { "SelectedToppings" });
      }

    }
  }
}