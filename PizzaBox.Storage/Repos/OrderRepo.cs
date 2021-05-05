using PizzaBox.Domain.Interfaces;

namespace PizzaBox.Storage.Repos
{
    public class OrderRepo<T> : IRepo<T> where T : Order
    {
      public IEnumerable<Order> Select()
      {
        throw new System.NotImplementedException();
      }

      public bool Insert()
      {
        throw new System.NotImplementedException();
      }      
      
      public IEnumerable<Order> Update()
      {
        throw new System.NotImplementedException();
      }      

      public bool Delete()
      {
        throw new System.NotImplementedException();
        
      }

    }
}