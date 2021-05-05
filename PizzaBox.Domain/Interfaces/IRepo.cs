using System.collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepo <T> where T : class      
  { 
    public T Select(); 

    public T Update();

    public T Insert(); 

    public T Delete();       
  }
}