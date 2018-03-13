namespace DesignPatterns.Shared.Patterns.Strategy
{
  public abstract class Duck
  {
    protected IQuackBehavior quackBehavior;
    protected IFlyBehavior flyBehavior;

    public abstract void Display();

    public void PerformQuack()
    {
      quackBehavior.Quack();
    }

    public void PerformFly()
    {
      flyBehavior.Fly();
    }

    public void Swin() {
      System.Console.WriteLine("All ducks float, ever decoys!");
    }

    public void SetFlyBehavior(IFlyBehavior flyBehavior) {
      this.flyBehavior = flyBehavior;
    }

    public void SetQuackBehavior(IQuackBehavior quackBehavior) {
      this.quackBehavior = quackBehavior;
    }
  }
}