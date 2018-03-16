using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public class Tea : CaffeineBeverage {
    protected override void AddCondiments()
    {
      System.Console.WriteLine("Adding Lemon");
    }

    protected override void Brew()
    {
      System.Console.WriteLine("Steeping the tea");
    }
  }
}