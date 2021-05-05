using PizzaBox.Storage.Repos;

namespace PizzaBox.Storage
{
    public class UnitOfWork
    {
      public CrustRepo Crusts{get;} //gets only, so only be used 

      public UnitOfWork()
      {
        // initaliza within constrcutor
        Crusts = new CrustRepo();
      }
    }
}