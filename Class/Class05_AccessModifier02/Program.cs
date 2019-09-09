using System;

namespace Class05_AccessModifier02
{
  internal class WaterHeater
  {
    protected int temperature;

    public void SetTemperature(int temperature)
    {
      if (temperature < -5 || temperature > 42)
      {
        throw new Exception("Temperature Out Of Range");
      }

      this.temperature = temperature;
    }

    internal void TurnOnWater()
    {
      Console.WriteLine($"물이 나옴. 현재 온도: {temperature}");
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      WaterHeater heater = new WaterHeater();
      try
      {
        heater.SetTemperature(200);
        heater.TurnOnWater();
      
        heater.SetTemperature(-2);
        heater.TurnOnWater();
      
        heater.SetTemperature(50);
        heater.TurnOnWater();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        throw;
      }
    }
  }
}