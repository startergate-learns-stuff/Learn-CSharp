using System;
using System.IO;

namespace Interface03
{
  internal class Program
  {
    internal interface ILogger
    {
      void WriteLog(string message);
    }

    internal class ConsoleLogger : ILogger
    {
      public void WriteLog(string message)
      {
        Console.WriteLine($"{DateTime.Now.ToLocalTime()} ) {message}");
      }
    }

    internal class FileLogger : ILogger
    {
      private StreamWriter writer;

      public FileLogger(string path)
      {
        writer = File.CreateText(path);
        writer.AutoFlush = true;
      }
      
      public void WriteLog(string message)
      {
        writer.WriteLine($"{DateTime.Now.ToLocalTime()} ) {message}");
      }
    }

    class ClimateMonitor
    {
      private ILogger logger;

      public ClimateMonitor(ILogger logger)
      {
        this.logger = logger;
      }

      public void start()
      {
        while (true)
        {
          Console.Write("Enter a temperature> ");
          string temperature = Console.ReadLine();
          if (temperature == "") break;
          logger.WriteLog($"현재 온도: {temperature}");
        }
      }
    }
    
    public static void Main(string[] args)
    {
      // 콘솔에 로그 출력
      ClimateMonitor cMonitor = new ClimateMonitor(new ConsoleLogger());
      cMonitor.start();
      
      // 파일에 로그 출력
      ClimateMonitor fMonitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
      fMonitor.start();
    }
  }
}