using System;

namespace Interface04
{
  internal interface ILogger
  {
    void WriteLog(string message);
  }

  internal interface IFormattableLogger : ILogger
  {
    void WriteLog(string format, params Object[] args);
  }

  internal class ConsoleLogger : IFormattableLogger
  {
    public void WriteLog(string message)
    {
      Console.WriteLine($"{DateTime.Now.ToLocalTime()} ) {message}");
    }

    public void WriteLog(string format, params object[] args)
    {
      string message = String.Format(format, args);
      Console.WriteLine($"{DateTime.Now.ToLocalTime()} ) {message}");
    }
  }
    
  internal class Program
  {
    public static void Main(string[] args)
    {
      IFormattableLogger logger = new ConsoleLogger();
      logger.WriteLog("Hello World");
      logger.WriteLog("{0} + {1} = {2}", 1, 2, 3);
    }
  }
}