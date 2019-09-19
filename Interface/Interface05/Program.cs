using System;

// 인터페이스 다중 상속
namespace Interface05
{
  internal interface IRunnable
  {
    void Run();
  }

  internal interface IFlyable
  {
    void Fly();
  }
  
  internal class FlyingCar : IRunnable, IFlyable
  {
    public void Run()
    {
      Console.WriteLine("Run Run");
    }

    public void Fly()
    {
      Console.WriteLine("Fly Fly");
    }
  }

  internal class Program
  {
    public static void Main(string[] args)
    {
      FlyingCar car = new FlyingCar();
      car.Run();
      car.Fly();

      IRunnable runnable = car;
      runnable.Run();

      IFlyable flyable = new FlyingCar();
      flyable.Fly();
      
      FlyingCar newCar = flyable as FlyingCar;
      newCar.Run();
      newCar.Fly();
    }
  }
}