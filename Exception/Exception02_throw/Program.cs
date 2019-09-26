﻿using System;

// 407p 예제
namespace Exception02_throw
{
  internal class Program
  {
    static void DoSomething(int arg)
    {
      if (arg < 10)
      {
        Console.WriteLine($"arg: {arg}");
      }
      else
      {
        throw new Exception("arg가 10보다 크네");
      }
    }
    
    public static void Main(string[] args)
    {
      try
      {
        DoSomething(5);
        DoSomething(11);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      Console.WriteLine("프로그램 종료");
    }
  }
}