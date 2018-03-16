using System;
using DesignPatterns.Shared.Patterns.Adapter;
using DesignPatterns.Shared.Patterns.Command;
using DesignPatterns.Shared.Patterns.Decorator;
using DesignPatterns.Shared.Patterns.Factory;
using DesignPatterns.Shared.Patterns.Observ;
using DesignPatterns.Shared.Patterns.SingletonPattern;
using DesignPatterns.Shared.Patterns.Strategy;
using DesignPatterns.Shared.Patterns.TemplateMethod;

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

      #region Command
      // var remote = new SimpleRemoteControl();

      // var light = new Light();

      // ICommand lightOn = new LightOnCommand(light);

      // remote.SetCommand(lightOn);
      // remote.ButtonWasPressed();

      // var remoteControl = new RemoteControl();

      // var livingRoomLight = new Light("Living Room");
      // var kitchenLight = new Light("Kitchen");
      
      // var stereo = new Stereo("Living Room");

      // ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
      // ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

      // ICommand kitchenLightOn = new LightOnCommand(kitchenLight);
      // ICommand kitchenLightOff = new LightOffCommand(kitchenLight);

      // remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
      // remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);

      // System.Console.WriteLine(remoteControl);

      // remoteControl.OnButtonWasPushed(0);
      // remoteControl.OffButtonWasPushed(0);

      // remoteControl.OnButtonWasPushed(1);
      // remoteControl.OffButtonWasPushed(1);
      #endregion

      #region Adapter and Facade
      // MallardDuck duck = new MallardDuck();
      
      // WildTurkey turkey = new WildTurkey();
      // Duck turkeyAdapter = new TurkeyAdapter(turkey);

      // System.Console.WriteLine("The Turkey says...");
      // turkey.Gobble();
      // turkey.Fly();
      #endregion

      #region TemplateMethod
      // CaffeineBeverage tea = new Tea();
      // tea.PrepareRecipe();

      // CaffeineBeverage coffe = new Coffe();
      // coffe.PrepareRecipe();

      CaffeineBeverageWithHook coffeeWithHook = new CoffeWithHook();
      coffeeWithHook.PrepareRecipe();

      CaffeineBeverageWithHook teaWithHook = new TeaWithHook();
      teaWithHook.PrepareRecipe();
      #endregion
    }
  }
}
