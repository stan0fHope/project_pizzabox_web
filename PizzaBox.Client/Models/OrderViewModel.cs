// input-output model
namespace PizzaBox.Client.Models
{
    public class OrderViewmodel
    {
      // Display options
      // strings are placeholder for test-running
      public List<string> Crusts{get; set;}
      public List<string> Sizes{get; set;}
      public List<string> Toppings{get; set;}

      // Selected option
      public string SelectedCrust{get; set;}
      public string SelectedSize{get; set;}
      public List<string> SelectedToppings{get; set;}


    }
}