using DesignPatterns.Shared.Patterns.Strategy;

namespace DesignPatterns.Shared.Patterns.Adapter {
  public class TurkeyAdapter : Duck, IQuackBehavior, IFlyBehavior
  {
    ITurkey turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
      this.turkey = turkey;
    }

    public override void Display()
    {
      throw new System.NotImplementedException();
    }

    public void Fly()
    {
      for (int i = 0; i < 5; i++)
      {
        turkey.Fly();
      }
    }

    public void Quack()
    {
      turkey.Gobble();
    }
  }
}