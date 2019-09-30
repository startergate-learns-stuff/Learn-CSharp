using System;

namespace Delegate03_Callback
{
  internal class Program
  {
    delegate void CalcDelegateType(int a, int b);
    
    public static void Main(string[] args)
    {
      void Add(int a, int b)
      {
        Console.WriteLine($"{a} + {b} = {a + b}");
      }
      
      void Subtract(int a, int b)
      {
        Console.WriteLine($"{a} + {b} = {a - b}");
      }
      
      void Multiply(int a, int b)
      {
        Console.WriteLine($"{a} * {b} = {a * b}");
      }
      
      void Divide(int a, int b)
      {
        Console.WriteLine($"{a} / {b} = {a / b}");
      }

      CalcDelegateType calcFunc;
      calcFunc = Add;
      Arithmetic(3, 4, calcFunc);
      
      calcFunc = Subtract;
      Arithmetic(3, 4, calcFunc);

      calcFunc = Add;
      calcFunc += Subtract;
      calcFunc += Multiply;
      calcFunc += Divide;
      Arithmetic(5, 7, calcFunc);
    }

    static void Arithmetic(int a, int b, CalcDelegateType calcFunc)
    {
      calcFunc(a, b);
      Console.WriteLine();
    }
  }
}