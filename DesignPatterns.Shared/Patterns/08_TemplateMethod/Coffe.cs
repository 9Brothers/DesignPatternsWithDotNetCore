using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public class Coffe : CaffeineBeverage {
    protected override void AddCondiments()
    {
      System.Console.WriteLine("Adding Sugar and Milk");
    }

    protected override void Brew()
    {
      System.Console.WriteLine("Dripping Coffee through filter");
    }
  }
}