using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repos
{
    public class ToppingRepo : IRepo<Topping> 
    {
      public IEnumerable<Topping> Select()
      {
        // get ball rolling
        return new List<Topping> {new Topping(), new Topping()};
      }

      public bool Insert()
      {
        throw new System.NotImplementedException();
      }      
      
      public IEnumerable<Topping> Update()
      {
        throw new System.NotImplementedException();
      }      

      public bool Delete()
      {
        throw new System.NotImplementedException();
        
      }

    }
}