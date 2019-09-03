using System;

namespace Method01
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int x = Plus(3, 4);
      int y = Plus(5, 6);
      Console.WriteLine(x);
      Console.WriteLine(y);
    }

    static int Plus(int a, int b)
    {
      return a + b;
    }
  }
}