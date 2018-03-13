namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class Squeak : IQuackBehavior
  {
    public void Quack()
    {
      System.Console.WriteLine("Squeak");
    }
  }
}