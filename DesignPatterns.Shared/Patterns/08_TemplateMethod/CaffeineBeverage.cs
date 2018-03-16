using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public abstract class CaffeineBeverage {
    public void PrepareRecipe() {
      BoilWater();
      Brew();
      PourInCup();
      
      if(CustomerWantsCondiments()) {
        AddCondiments();
      }

      System.Console.WriteLine("");
    }

    public bool CustomerWantsCondiments()
    {
      string answer = GetUserInput();

      return false;
    }

    private string GetUserInput()
    {
      System.Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

      string answer = Console.ReadLine();

      if (answer.Equals(string.Empty) || !answer.Equals("y"))
      {
        return "no";
      }

      return answer;
    }

    protected abstract void AddCondiments();

    private void PourInCup()
    {
      System.Console.WriteLine("Pouring into cup");
    }

    protected abstract void Brew();

    private void BoilWater()
    {
      System.Console.WriteLine("Boiling water");
    }
  }
}