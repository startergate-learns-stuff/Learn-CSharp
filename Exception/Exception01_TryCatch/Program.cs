using System;

namespace Exception01_TryCatch
{
  internal class Program
  {
    private static int[] arr = {1, 2, 3};

    static void ExceptionMethod() // 배열 출력
    {
      for (int i = 0; i < 5; i++)
        Console.Write(arr[i]);
      Console.WriteLine("ExceptionMethod() 종료");
    }

    static void TryCatchMethod()
    {
      try
      {
        for (int i = 0; i < 5; i++)
          Console.WriteLine(arr[i]);
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine("예외가 발생함");
        Console.WriteLine($"에러 메시지: {e.Message}");
      }
      Console.WriteLine("TryCatchMethod() 종료");
    }
    
    public static void Main(string[] args)
    {
      // ExceptionMethod();
      TryCatchMethod();
    }
  }
}