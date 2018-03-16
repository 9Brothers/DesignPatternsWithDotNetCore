using System;

namespace DesignPatterns.Shared.Patterns.TemplateMethod {
  public abstract class CaffeineBeverageWithHook {
    public void PrepareRecipe() {
      BoilWater();
      Brew();
      PourInCup();
      
      if(CustomerWantsCondiments()) {
        AddCondiments();
      }

      System.Console.WriteLine("");
    }

    protected abstract bool CustomerWantsCondiments();

    protected bool GetUserInput()
    {
      string answer = Console.ReadLine();

      if(answer.ToLower().StartsWith("y")) return true;

      return false;
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