namespace DesignPatterns.Shared.Patterns.Strategy
{
  public class ModelDuck : Duck
  {
    public ModelDuck()
    {
      flyBehavior = new FlyNoWay();
      quackBehavior = new Quack();
    }
    public override void Display()
    {
      System.Console.WriteLine("I1m a model duck");
    }
  }
}