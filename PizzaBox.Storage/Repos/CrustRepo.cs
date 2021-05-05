using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Storage.Repos
{
    public class CrustRepo<T> : IRepo<T> where T : Crust
    {
      public IEnumerable<Crust> Select()
      {
        // get ball rolling
        return new List<Crust> {new Crust(), new Crust()};
      }

      public bool Insert()
      {
        throw new System.NotImplementedException();
      }      
      
      public IEnumerable<Crust> Update()
      {
        throw new System.NotImplementedException();
      }      

      public bool Delete()
      {
        throw new System.NotImplementedException();
        
      }

    }
}