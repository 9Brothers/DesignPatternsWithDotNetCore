namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Espresso : Beverage
  {
    public Espresso()
    {
      description = "Expresso";
    }

    public override double Cost()
    {
      return 1.99;
    }
  }
}