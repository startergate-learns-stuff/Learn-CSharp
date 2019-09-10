using System;

namespace ClassTest02
{
  internal class Computer
  {
    protected string name;
    protected bool powerOn;

    public Computer(string name)
    {
      this.name = name;
    }
    
    public void Boot()
    {
      Console.WriteLine($"{name} is now Booting...");
      powerOn = true;
    }

    public void Shutdown()
    {
      Console.WriteLine($"{name} is Shutting Down...");
      powerOn = false;
    }

    public void Reset()
    {
      Console.WriteLine($"{name} is Restarting...");
    }
  }

  internal class Notebook : Computer
  {
    private int touchpadSize;
    
    public Notebook(string name, int touchpadSize) : base(name)
    {
      this.touchpadSize = touchpadSize;
    }

    public int GetTouchpadSize() => touchpadSize;

    public void useTouchpad()
    {
      Console.WriteLine($"{name}'s Touchpad Used.");
    }
  }

  internal class Desktop : Computer
  {
    public Desktop(string name) : base(name)
    {
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Notebook nb = new Notebook("상성 노트북 9 메탈", 13);
      nb.Boot();
      nb.Reset();
      Console.WriteLine($"Size: {nb.GetTouchpadSize()}");
      nb.useTouchpad();
      nb.Shutdown();
    }
  }
}