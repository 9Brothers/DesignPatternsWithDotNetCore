using System.Collections.Generic;

namespace DesignPatterns.Shared.Patterns.Factory {
  public class Pizza : IPizza
  {
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public IList<object> Toppings = new List<object>();
    public void Bake()
    {
      System.Console.WriteLine("Bake fir 25 minutes at 350");
    }

    public void Box()
    {
      System.Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public void Cut()
    {
      System.Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Prepare()
    {
      System.Console.WriteLine($"Preparing {Name}");
      System.Console.WriteLine("Tossing dough...");
      System.Console.WriteLine("Adding sauce...");
      System.Console.WriteLine("Adding toppings: ");

      for (int i = 0; i < Toppings.Count; i++)
      {
        System.Console.WriteLine($" {Toppings[i]}");
      }
    }
  }
}