using System;

// 449p 예제
namespace Event01
{
  delegate void EventHandler(string message);

  internal class MyNotifier
  {
    public EventHandler SomethingHappened;

    public void DoSomething(int number)
    {
      int temp = number % 10;
      if (temp != 0 && temp % 3 == 0)
        SomethingHappened(String.Format("{0} : 짝", number));
    }
  }
  
  internal class Program
  {
    public static void MyHandler(string message)
    {
      Console.WriteLine(message);
    }
    
    public static void Main(string[] args)
    {
      MyNotifier notifier = new MyNotifier();
      notifier.SomethingHappened += new EventHandler(MyHandler);

      for (int i = 0; i < 30; i++)
      {
        notifier.DoSomething(i);
      }
    }
  }
}