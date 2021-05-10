using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Customer : Entity
  {
    public List<Order> Order { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

  }
}