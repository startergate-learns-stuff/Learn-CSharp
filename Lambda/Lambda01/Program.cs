using System;

namespace Lambda01
{
  internal class Program
  {
    delegate int? CalcDelegate(int a, int b);

    delegate T Calculator2<T>(T a, T b);
    
    public static void Main(string[] args)
    {
      #region 람다 연습
      CalcDelegate calc1 = delegate(int a, int b)
      {
        return a + b;
      };
      Console.WriteLine(calc1(10,3));

      CalcDelegate calc2 = (a, b) => a + b;
      Console.WriteLine(calc2(10,3));

      CalcDelegate c2 = (a, b) =>
      {
        if (b == 0)
          return null;
        return a / b;
      };

      if (c2(10,0) == null)
      {
        Console.WriteLine("0으로 나눌 수 없습니다");
      }
      else
      {
        Console.WriteLine(c2(10,0));
      }
      #endregion

      Calc(1, 2, (a, b) => a + b);
      Calc(1.2, 2.3, (a, b) => a + b);
    }
    
    static void Calc<T>(T a, T b, Calculator2<T> CalcFunc)
    {
      Console.WriteLine(CalcFunc(a, b));
    }
  }
}