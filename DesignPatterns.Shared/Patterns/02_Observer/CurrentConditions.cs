namespace DesignPatterns.Shared.Patterns.Observ
{
  public class CurrentConditions : IObserver, IDisplayElement
  {
    private double temperature;
    private double humidity;
    private ISubject weatherData;

    public CurrentConditions(ISubject weatherData)
    {
      this.weatherData = weatherData;

      this.weatherData.RegisterObserver(this);
    }

    public void Display()
    {
      System.Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
    }

    public void Update(double temperature, double humidity, double pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;

      Display();
    }
  }
}