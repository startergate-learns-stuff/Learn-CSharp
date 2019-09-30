using System;

// 432p 예제
// 버블 정렬을 할 때 오름차순, 내림차순 메소드를 매개변수로 전달
namespace Delegate04_432p
{
  delegate int Compare(int a, int b);
  
  internal class Program
  {
    static int AscendCompare(int a, int b)
    {
      if (a > b)
        return 1;
      else if (a == b)
        return 0;
      else
        return -1;
    }
    
    static int DescendCompare(int a, int b)
    {
      if (a < b)
        return 1;
      else if (a == b)
        return 0;
      else
        return -1;
    }

    static void BubbleSort(int[] DataSet, Compare Comparer)
    {
      int i, j, temp;
      for (i = 0; i < DataSet.Length - 1; i++)
      {
        for (j = 0; j < DataSet.Length - (i + 1); j++)
        {
          if (Comparer(DataSet[j], DataSet[j+1]) > 0)
          {
            temp = DataSet[j + 1];
            DataSet[j + 1] = DataSet[j];
            DataSet[j] = temp;
          }
          PrintArray(DataSet);
        }
      }
    }

    private static void PrintArray(int[] array)
    {
      foreach (var item in array)
        Console.Write($"{item} ");
      Console.WriteLine();
    }

    public static void Main(string[] args)
    {
      int[] array = {25, 23, 12, 9, 7};
      Console.WriteLine("초기 상태: ");
      PrintArray(array);
      BubbleSort(array, new Compare(AscendCompare));
      
      int[] array2 = {25, 23, 12, 9, 7};
      Console.WriteLine("초기 상태: ");
      PrintArray(array2);
      BubbleSort(array2, new Compare(DescendCompare));
    }
  }
}