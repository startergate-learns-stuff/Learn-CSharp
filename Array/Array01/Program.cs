using System;

namespace Array01
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 방법 1: 코드를 읽기 좋음
      string[] array1 = new string[3] {"안녕", "Hello", "World"};
      foreach (string s in array1)
      {
        Console.Write($"{s} ");
      }
      Console.WriteLine('\n');
      
      // 방법 2
      string[] array2 = new string[] {"안녕", "Hello", "World"};
      foreach (string s in array2)
      {
        Console.Write($"{s} ");
      }
      Console.WriteLine('\n');

      // 방법 3: 코드가 짧음
      string[] array3 = {"안녕", "Hello", "World"};
      foreach (string s in array3)
      {
        Console.Write($"{s} ");
      }
      Console.WriteLine('\n');

      Console.WriteLine(array1.GetType());
      Console.WriteLine(array1.GetType().BaseType);
    }
  }
}