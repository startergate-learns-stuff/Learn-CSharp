using System;

namespace BreakAndContinue
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int i = 1;
      while (true)
      {
        for (int j = 0; j < 10; j++)
        {
          i++;
          if (i % 3 == 0) Console.WriteLine(i);
        }

        Console.Write("Continue?>");
        string answer = Console.ReadLine();

        if (answer == "아니오")
          break;
      }
    }
  }
}