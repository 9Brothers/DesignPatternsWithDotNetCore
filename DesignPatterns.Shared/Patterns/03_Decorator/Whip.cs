namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Whip : CondimentDecorator
  {
    public Beverage beverage;

    public Whip(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double Cost()
    {
      return .1 + beverage.Cost();
    }

    public override string GetDescription()
    {
      return $"{beverage.GetDescription()}, Whip";
    }
  }
}