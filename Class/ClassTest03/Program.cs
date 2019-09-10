using System;

namespace ClassTest03
{
  internal class Program
  {
    public static double SumDoubleOnly(object[] arr)
    {
      double sum = 0.0;
      foreach (var obj in arr)
      {
        if (obj is double)
        {
          sum += (double) obj;
        }
      }

      return sum;
    }
    
    public static void Main(string[] args)
    {
      object[] objectArr = { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
      Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
    }
  }
}