using System;

namespace ClassTest06
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
      Console.WriteLine($"{name} is booting...");
      powerOn = true;
    }

    public void Shutdown()
    {
      Console.WriteLine($"{name} is shutting down...");
      powerOn = false;
    }

    public void Reset()
    {
      Console.WriteLine($"{name} is resetting...");
    }
  }
  
  internal class Desktop {}

  internal class Notebook : Computer
  {
    public Notebook(string name, int touchpadSize) : base(name)
    {
      this.touchpadSize = touchpadSize;
    }

    public int touchpadSize;

    public void useTouchpad()
    {
      Console.WriteLine($"{name}'s touchpad was used.'");
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
    }
  }
}