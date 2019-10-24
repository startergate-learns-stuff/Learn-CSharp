using System;
using System.Threading;

namespace Thread04_Abort
{
  class SideTask
  {
    private int count;

    public SideTask(int count)
    {
      this.count = count;
    }

    public void KeepAlive()
    {
      try
      {
        while (count > 0)
        {
          Console.WriteLine($"{count--} left.");
          Thread.Sleep(10);
        }
      }
      catch (ThreadAbortException e)
      {
        Console.WriteLine("ThreadAbortException: " + e.Message);
      }
      finally
      {
        Console.WriteLine("Clearing resources");
      }
    }
  }
  
  class Program
  {
    static void Main(string[] args)
    {
      SideTask task = new SideTask(100);
      Thread t = new Thread(task.KeepAlive);

      Console.WriteLine("Starting Thread...");
      t.Start();
      Thread.Sleep(100);

      Console.WriteLine("스레드 중지 메소드 실행");
      t.Abort(); // 스레드 취소 메소드 실행

      Console.WriteLine("메인 스레드 종료");
    }
  }
}