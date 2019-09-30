using System;

namespace ExceptionTest01
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int[] arr = new int[10];

      for (int i = 0; i < 10; i++) arr[i] = i;

      for (int i = 0; i < 11; i++)
      {
        try
        {
          Console.WriteLine(arr[i]);
        }
        catch (IndexOutOfRangeException e)
        {
          Console.WriteLine(e.Message);
        }
      }
    }
  }
}