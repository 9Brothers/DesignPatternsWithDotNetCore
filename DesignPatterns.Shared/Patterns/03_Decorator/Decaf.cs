namespace DesignPatterns.Shared.Patterns.Decorator
{
  public class Decaf : Beverage
  {
    public Decaf()
    {
      description = "Descafeinado";
    }

    public override double Cost()
    {
      return 1.05;
    }
  }
}