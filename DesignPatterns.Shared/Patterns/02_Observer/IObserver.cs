namespace DesignPatterns.Shared.Patterns.Observ
{
  public interface IObserver
  {
    void Update(double temp, double humidity, double pressure);
  }
}