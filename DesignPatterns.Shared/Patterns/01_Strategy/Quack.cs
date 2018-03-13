namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class Quack : IQuackBehavior
  {
    void IQuackBehavior.Quack()
    {
      System.Console.WriteLine("Quack");
    }
  }
}