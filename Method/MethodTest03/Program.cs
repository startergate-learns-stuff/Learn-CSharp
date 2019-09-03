using System;

namespace MethodTest03
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter Number > ");
      int n = int.Parse(Console.ReadLine());
      FibonacciLoop(n);
      Console.WriteLine();
      for (int i = 0 ; i <= n ; i++ ){
        Console.WriteLine("FibonacciRecursive({0, 2}): {1}", i, FibonacciRecursive(i));
      }
    }

    static void FibonacciLoop(int index)
    {
      int n = 0, m = 1;
      
      Console.WriteLine("FibonacciLoop({0, 2}): {1}", 0, 0);
      Console.WriteLine("FibonacciLoop({0, 2}): {1}", 1, 1);
      
      for (int i = 2; i <= index; i++)
      {
        int t = m;
        m = t + n;
        n = t;
        Console.WriteLine("FibonacciLoop({0, 2}): {1}", i, m);
      }
    }
    
    
    static int FibonacciRecursive(int index)
    {
      if (index == 0)
        return 0;

      if (index == 1)
        return 1;

      return FibonacciRecursive(index - 1) + FibonacciRecursive(index - 2);
    }
  }
}