﻿using System;

namespace Goto
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      for (int i = 0; i < 100; i++)
      {
        for (int j = 0; j < 200; j++)
        {
          for (int k = 0; k < 300; k++)
          {
            if (k >= 10)
              goto EXIT_FOR;
            Console.WriteLine(k);
          }
        }
      }
      EXIT_FOR:
      Console.WriteLine("EXIT");
    }
  }
}