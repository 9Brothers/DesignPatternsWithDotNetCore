namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class FlyNoWay : IFlyBehavior
  {
    public void Fly()
    {
      System.Console.WriteLine("I can't fly");
    }
  }
}