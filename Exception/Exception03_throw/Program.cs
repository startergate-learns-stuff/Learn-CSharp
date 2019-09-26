using System;

// 409p 예제
namespace Exception03_throw
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        int? a = null;
        int b = a ?? throw new ArgumentNullException();
      }
      catch (ArgumentNullException e)
      {
        Console.WriteLine(e.Message);
      }

      try
      {
        int[] array = new[] {1, 2, 3};
        int index = 4;
        int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
      }
      catch (IndexOutOfRangeException e)
      {
        Console.WriteLine(e.Message);
      }
      
    }
  }
}