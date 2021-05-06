using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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



    public OrderViewModel(UnitOfWork unitOfWork)
    {
      // Crusts = crustRepo.Select(); doesnt work. Select is IEnum<Crust>
      Crusts = unitOfWork.Crusts.Select().ToList(); // make into List(LINQ), from IEnum<Class> to List<Cr
                                                    // follow on the rest
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
      var validResults = new List<ValidationResult>();
      // actually valid errors
      // buy car, waiting for use

      // var ctx = validationContext.Items.
      if (SelectedCrust == SelectedSize)
      {
        validResults.Add(new ValidationResult("IS you crasy!", new string[] { "SelectedCrust", "SelectedSize" }));
        // Asking the properties if they invalid/erros
        // like a catch 

        // or return instance of collection if 1+ causes(If statement)
        yield return new ValidationResult("IS you crasy!", new string[] { "SelectedCrust", "SelectedSize" });
        // call an uber, yield brings records at end
      }

      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        validResults.Add(new ValidationResult("IS you crasy!", new string[] { "SelectedToppings" }));
      }


      // if (SelectedCrust.Contains("Org"))

      return validResults;
    }



  }
}