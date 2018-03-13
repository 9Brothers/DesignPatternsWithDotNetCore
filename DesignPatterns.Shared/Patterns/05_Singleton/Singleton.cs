using System.Runtime.CompilerServices;

namespace DesignPatterns.Shared.Patterns.SingletonPattern {
  public class Singleton {
    private static Singleton uniqueInstance;

    private Singleton() {}

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static Singleton GetInstance() {
      if(uniqueInstance == null) {
        uniqueInstance = new Singleton();
      }

      return uniqueInstance;
    }
  }
}