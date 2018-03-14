using System;

namespace DesignPatterns.Shared.Patterns.Command {
  public class Light
  {
    string place;
    public Light(string place)
    {
      this.place = place;
    }

    public void On()
    {
      System.Console.WriteLine($"Acender luz - {place}");
    }

    internal void Off()
    {
      System.Console.WriteLine($"Apagar luz - {place}");
    }
  }
}