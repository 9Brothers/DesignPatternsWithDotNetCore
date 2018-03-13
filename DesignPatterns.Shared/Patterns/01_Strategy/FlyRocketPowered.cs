namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class FlyRocketPowered : IFlyBehavior
  {
    public void Fly()
    {
      System.Console.WriteLine("I'm flying with a rocket!");
    }
  }
}