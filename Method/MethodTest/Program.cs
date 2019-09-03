using System;

namespace MethodTest
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      SumAndOutput(11, 66);
    }

    static void SumAndOutput(int n, int m)
    {
      int sum = 0;
      int avg = 0;
      for (int i = n; i <= m; i++)
      {
        sum += i;
      }

      Console.WriteLine("Sum: {0}, Average: {1}", sum, (double) sum / (m - n + 1));
    }
  }
}