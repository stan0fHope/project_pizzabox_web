using PizzaBox.Storage.Repos;

namespace PizzaBox.Storage
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;
    public CrustRepo Crusts { get; } //gets only, so only be used 
    public SizeRepo Sizes { get; }
    public ToppingRepo Toppings { get; }
    public PizzaRepo Pizzas { get; set; }
    public StoreRepo Stores { get; set; }
    public OrderRepo Orders { get; set; }


    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepo(_context);
      Sizes = new SizeRepo(_context);
      Toppings = new ToppingRepo(_context);
      Pizzas = new PizzaRepo(_context);
      Stores = new StoreRepo(_context);
      Orders = new OrderRepo(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}