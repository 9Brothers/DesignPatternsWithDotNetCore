namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class MuteQuack : IQuackBehavior
  {
    public void Quack()
    {
      System.Console.WriteLine("<< Silence >>");
    }
  }
}