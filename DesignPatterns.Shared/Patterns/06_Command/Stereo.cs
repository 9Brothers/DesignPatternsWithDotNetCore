using System;

namespace DesignPatterns.Shared.Patterns.Command {
  public class Stereo
  {
    private string place;

    public Stereo(string place)
    {
      this.place = place;
    }

    internal void On()
    {
      throw new NotImplementedException();
    }

    internal void SetCD()
    {
      throw new NotImplementedException();
    }

    internal void SetVolume(int volume)
    {
      throw new NotImplementedException();
    }
  }
}