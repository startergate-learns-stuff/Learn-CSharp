using System;

namespace Lambda02_FuncAction
{
  internal class Program
  {
    delegate void AddDelegate<T1, T2>(T1 a, T2 b); // 사용자 정의 델리게이트

    delegate TResult SubtractDelegate<T1, T2, TResult>(T1 a, T2 b);
    
    public static void Main(string[] args)
    {
      // 기존 방식
      AddDelegate<int, int> addDel = (a, b) => Console.WriteLine(a + b);
      addDel(3, 4);

      SubtractDelegate<int, int, int> subDel = (a, b) => a - b;
      Console.WriteLine(subDel(3, 4));
      
      // Action 델리게이트 활용
      Action<int, int> actionDel = (a, b) => Console.WriteLine(a + b);
      actionDel(3, 4);

      Func<double, double, double> func = (a, b) => a + b;
      Console.WriteLine(func(3.14, 1651356468));
    }
  }
}