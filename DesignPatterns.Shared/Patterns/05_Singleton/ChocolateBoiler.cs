using System;

namespace DesignPatterns.Shared.Patterns.SingletonPattern
{
  public class ChocolateBoiler
  {
    private bool empty;
    private bool boiled;

    private ChocolateBoiler()
    {
      empty = true;
      boiled = false;
    }

    public void Fill()
    {
      if (IsEmpty())
      {
        empty = false;
        boiled = false;
      }
    }

    private bool IsEmpty()
    {
      return empty;
    }

    public void Drain()
    {
      if (!IsEmpty() && IsBoiled())
      {
        // drene o leite e o chocolate fervidos
        empty = true;
      }
    }

    private bool IsBoiled()
    {
      return boiled;
    }

    public void Boil()
    {
      if (!IsEmpty() && !IsBoiled())
      {
        // color o contepudo em ebulição
        boiled = true;
      }
    }

    
  }
}