namespace DesignPatterns.Shared.Patterns.Factory {
  public class NYPizzaStore : PizzaStore
  {
    protected override Pizza CreatePizza(string type)
    {
      Pizza pizza = null;

      if (type.Equals("cheese"))
      {
        pizza = new NYCheesePizza();

      } else if (type.Equals("pepperoni"))
      {
        pizza = new NYPepperoniPizza();

      } else if (type.Equals("clam"))
      {
        pizza = new NYClamPizza();

      } else if (type.Equals("veggie"))
      {
        pizza = new NYVeggiePizza();
      }

      return pizza;
    }
  }
}