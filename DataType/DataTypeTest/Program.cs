using System;

namespace DataTypeTest
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      double a, b;
      Console.WriteLine("2개의 실수를 입력하세요");
      a = double.Parse(Console.ReadLine());
      b = double.Parse(Console.ReadLine());

      Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
    }
  }
}