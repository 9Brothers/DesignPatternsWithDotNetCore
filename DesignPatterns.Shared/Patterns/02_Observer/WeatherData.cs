using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Shared.Patterns.Observ
{
  public class WeatherData : ISubject
  {
    private IList<IObserver> observers;
    private double temperature;
    private double humidity;
    private double pressure;

    public WeatherData()
    {
      observers = new List<IObserver>();
    }

    public void NotifyObservers()
    {
      foreach (var observer in observers)
      {
        observer.Update(temperature, humidity, pressure);
      }
    }

    public void RegisterObserver(IObserver observer)
    {
      observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
      var index = observers.IndexOf(observer);

      if (index >= 0) observers.RemoveAt(index);
    }

    public void MeasurementsChanged()
    {
      NotifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;

      MeasurementsChanged();
    }
  }
}