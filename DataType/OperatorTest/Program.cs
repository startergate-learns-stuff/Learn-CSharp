using System;

namespace OperatorTest
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int a;
      Console.WriteLine("정수를 입력하세요");
      a = int.Parse(Console.ReadLine());

      Console.WriteLine(a % 2 == 0 ? "짝수" : "홀수");
    }
  }
}