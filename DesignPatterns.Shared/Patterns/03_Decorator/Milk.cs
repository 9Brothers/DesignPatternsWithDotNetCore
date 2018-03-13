namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Milk : CondimentDecorator
  {
    public Beverage beverage;

    public Milk(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double Cost()
    {
      return .1 + beverage.Cost();
    }

    public override string GetDescription()
    {
      return beverage.GetDescription() + ", Milk";
    }
  }
}