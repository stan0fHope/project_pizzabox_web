using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    public static IEnumerable<object[]> crusts = new List<object[]>()
    {
      new Crust() { EntityId = 1, Name = "original", Price = 5.00M },
      new Crust() { EntityId = 2, Name = "stuffed", Price = 7.00M },
      new Crust() { EntityId = 3, Name = "flatbread", Price = 6.50M}
    };
    public static IEnumerable<object[]> sizes = new List<object[]>()
    {
      new Size() { EntityId = 1, Name = "small", Price = 7.00M },
      new Size() { EntityId = 2, Name = "medium", Price = 10.00M},
      new Size() { EntityId = 3, Name = "large", Price = 14.00M}
    };
    public static IEnumerable<object[]> toppings = new List<object[]>()
    {
      new Topping() { EntityId = 1, Name = "pepperoni", Price = 1.50M},
      new Topping() { EntityId = 2, Name = "pineapple", Price = 2.50M},
      new Topping() { EntityId = 3, Name = "ham", Price = 1.50M },
      new Topping() { EntityId = 4, Name = "green peppers", Price = 1.25M},
      new Topping() { EntityId = 5, Name = "black olives", Price = 1.75M}
    };

    [Fact]
    public void Test_PizzaConstructor()
    {
      var sut = new Pizza();

      Assert.NotNull(sut);
    }

    [Theory]
    [MemberData(nameof(crusts))]
    public void TestCrust(Crust crust)
    {
      Assert.NotNull(crust);
      Assert.Equal(crust.Name, crust.ToString());
    }

    [Theory]
    [MemberData(nameof(sizes))]
    public void TestSizes(Size size)
    {
      Assert.NotNull(size);
      Assert.Equal(size.Name, size.ToString());
    }

    [Theory]
    [MemberData(nameof(toppings))]
    public void TestTopping(Topping topping)
    {
      Assert.NotNull(topping);
      Assert.Equal(topping.Name, topping.ToString());
    }

    [Theory]

    [MemberData(nameof(toppings))]
    [MemberData(nameof(sizes))]
    [MemberData(nameof(crusts))]
    public void TestPizzaPrice(Topping topping, Size size, Crust crust)
    {
      var p = new Pizza() { crust, size, topping };
      Assert.NotNull(p);
      Assert.NotNull(p.TotalPrice);

      Assert.GreaterOrEqual(p.TotalPrice, 8.00MM);
    }


  }
}