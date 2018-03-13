namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Mocha : CondimentDecorator
  {
    private Beverage beverage;

    public Mocha(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double Cost()
    {
      return .2 + beverage.Cost();
    }

    public override string GetDescription()
    {
      return beverage.GetDescription() + ", Mocha";
    }
  }
}