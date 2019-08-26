using System;

namespace Chapter01
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int num = 1234567;
      float num2 = 3.141592f;
      float f1 = new System.Single();
      Console.WriteLine(f1);
      Console.WriteLine(num.GetType());
      Console.WriteLine(num2.GetType());

      Console.WriteLine("num1: {0, 10}, num2: {1,2:F}", num, num2);
    }
  }
}