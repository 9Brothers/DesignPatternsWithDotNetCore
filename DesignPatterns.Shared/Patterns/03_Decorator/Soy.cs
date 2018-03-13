namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Soy : CondimentDecorator
  {
    public Beverage beverage;

    public Soy(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double Cost()
    {
      return .15 + beverage.Cost();
    }

    public override string GetDescription()
    {
      return $"{beverage.GetDescription()}, Soy";
    }
  }
}