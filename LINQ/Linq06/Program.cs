using System;
using System.Collections;
using System.Linq;

namespace Linq06
{
  internal class Program
  {
    static int[] GenerateIntegerNum(int length)
    {
      int[] numbers = new int[length];
      Random random = new Random();
      for (int i = 0; i < length; i++)
      {
        numbers[i] = random.Next(1, 100);
      }
      return numbers;
    }
    
    public static void Main(string[] args)
    {
      int[] numbers = GenerateIntegerNum(20);

      #region Query 구문 사용
      // 배열의 초기 상태 출력
      PrintArray(numbers);

      // 2. 쿼리 만들기 (짝수만 오름차순 정렬하는 쿼리)
      var numList1 = from num in numbers where num % 2 == 0 orderby num select num;

      PrintArray(numList1);
      #endregion

      #region Method 구문 사용
      // 2. 메서드로 쿼리 만들기
      var numList2 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

      PrintArray(numList2);
      #endregion

      int itemCount = (from num in numbers where num % 2 == 0 orderby num select num).Count();
      Console.WriteLine(itemCount);

      double itemAvg = (from num in numbers where num % 2 == 0 orderby num select num).Average();
      Console.WriteLine(itemAvg);
    }

    private static void PrintArray<T>(T numbers) where T : IEnumerable
    {
      foreach (var item in numbers) 
        Console.Write(item + " ");
      Console.WriteLine();
    }
  }
}