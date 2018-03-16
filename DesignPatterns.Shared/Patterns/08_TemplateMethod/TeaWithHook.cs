using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public class TeaWithHook : CaffeineBeverageWithHook {
    protected override void AddCondiments()
    {
      System.Console.WriteLine("Adding Lemon");
    }

    protected override void Brew()
    {
      System.Console.WriteLine("Steeping the tea");
    }

    protected override bool CustomerWantsCondiments()
    {
      System.Console.WriteLine("Would you like lemon with your tea (y/n)? ");
      
      return GetUserInput();
    }
  }
}