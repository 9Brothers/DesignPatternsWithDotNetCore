using System;
using DesignPatterns.Shared.Patterns.Decorator;
using DesignPatterns.Shared.Patterns.Factory;
using DesignPatterns.Shared.Patterns.Observ;
using DesignPatterns.Shared.Patterns.SingletonPattern;
using DesignPatterns.Shared.Patterns.Strategy;

namespace DesignPatterns.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Strategy
      // Duck mallard = new MallardDuck();
      // mallard.PerformQuack();
      // mallard.PerformFly();

      // Duck model = new ModelDuck();
      // model.PerformFly();
      // model.SetFlyBehavior(new FlyRocketPowered());
      // model.PerformFly();
      #endregion

      #region Observer
      // var weatherData = new WeatherData();

      // var currentDisplay = new CurrentConditions(weatherData);

      // weatherData.SetMeasurements(80, 65, 30.4);
      // weatherData.SetMeasurements(82, 70, 29.2);
      // weatherData.SetMeasurements(78, 90, 29.2);
      #endregion

      #region Decorator
      // var beverage = new Espresso();
      // System.Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}\n");

      // Beverage beverage2 = new DarkRoast();
      // beverage2 = new Mocha(beverage2);
      // beverage2 = new Mocha(beverage2);
      // beverage2 = new Whip(beverage2);        
      // System.Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}\n");

      // Beverage beverage3 = new HouseBlend();
      // beverage3 = new Soy(beverage3);
      // beverage3 = new Mocha(beverage3);
      // beverage3 = new Whip(beverage3);        
      // System.Console.WriteLine($"{beverage3.GetDescription()} ${beverage3.Cost()}\n");
      #endregion

      #region Factory
      // PizzaStore nyPizzaStore = new NYPizzaStore();
      // Pizza pizza = nyPizzaStore.OrderPizza("cheese");

      // System.Console.WriteLine($"Ethan ordered a {pizza.Name}");
      #endregion

      #region Singleton
      // var singleInstance = Singleton.GetInstance();

      // var testNewInstance = Singleton.GetInstance();
      #endregion
    }
  }
}
