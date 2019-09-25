using System;

namespace GenericHandling01
{
  internal class Program
  {
    class OverrideMethod
    {
      public void Print(int value)
      {
        Console.WriteLine(value);
      }
      
      public void Print(double value)
      {
        Console.WriteLine(value);
      }
    }

    class GenericMethod
    {
      public void Print<T>(T value)
      {
        Console.WriteLine(value);
      }
    }
    
    public static void Main(string[] args)
    {
      OverrideMethod om = new OverrideMethod();
      om.Print(100);
      om.Print(3.14);
      
      GenericMethod gm = new GenericMethod();
      gm.Print<int>(100);
      gm.Print<double>(3.14);
      gm.Print<string>("ABC");


    }
  }
}