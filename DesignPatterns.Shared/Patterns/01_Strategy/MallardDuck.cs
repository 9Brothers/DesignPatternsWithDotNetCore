namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      quackBehavior = new Quack();
      flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
      System.Console.WriteLine("I'm a real Mallard Duck");
    }
  }
}