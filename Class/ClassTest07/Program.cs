using System;

namespace ClassTest07
{
  internal class Program
  {
    public static double SumDoubleOnly(object[] arr)
    {
      double sum = 0;

      foreach (var val in arr)
      {
        if (val is double)
        {
          sum += (double) val;
        }
      }
      
      return sum;
    }
    
    public static void Main(string[] args)
    {
      object[] objectArr = new object[] { 8.9, "dog", 6, 'c', null, 15.99, 745, true };
      Console.WriteLine(SumDoubleOnly(objectArr)); // 24.89
    }
  }
}