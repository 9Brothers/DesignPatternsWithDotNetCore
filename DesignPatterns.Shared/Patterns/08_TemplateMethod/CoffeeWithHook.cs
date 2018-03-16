using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public class CoffeWithHook : CaffeineBeverageWithHook {
    protected override void AddCondiments()
    {
      System.Console.WriteLine("Adding Sugar and Milk");
    }

    protected override void Brew()
    {
      System.Console.WriteLine("Dripping Coffee through filter");
    }

    protected override bool CustomerWantsCondiments()
    {
      System.Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
      
      return GetUserInput();
    }
  }
}