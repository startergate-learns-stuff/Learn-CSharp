using System;

namespace GenericHandling02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int[] source = { 1, 2, 3, 4, 5, 6 };
      int[] target = new int[source.Length];

      CopyArray<int>(source, target);
      PrintArray<int>(source);
      PrintArray<int>(target);

      string[] source2 = {"하나", "둘", "셋", "넷", "다섯", "여섯"};
      string[] target2 = new string[source2.Length];
      
      CopyArray<string>(source2, target2);
      PrintArray<string>(source2);
      PrintArray<string>(target2);
    }

    private static void CopyArray<T>(T[] source, T[] target)
    {
      for (int i = 0; i < source.Length; i++)
      {
        target[i] = source[i];
      }
    }

    private static void PrintArray<T>(T[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
      }

      Console.WriteLine('\n');
    }
  }
}