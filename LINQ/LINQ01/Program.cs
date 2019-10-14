using System;
using System.Collections.Generic;
using System.Linq;

// LINQ (Language Integrated Query)
// 컬렉션을 대상으로 쿼리를 수행할 수 있음
namespace LINQ01
{
  internal class Program
  {
    // 랜덤 숫자 생성 메서드
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
      // 1. 데이터 소스 (자연수 20개를 저장한 배열)
      int[] numbers = GenerateIntegerNum(20);
      
      // numbers 배열에서 2로 나누어지는 숫자만 새로운 리스트에 저장하고 오름차순 정렬하여 출력
      #region LINQ를 사용하지 않은 경우
      // 2. List 생성
      List<int> newN = new List<int>();

      // 3. numbers 배열에서 짝수만 추출하여 List에 저장
      foreach (var number in numbers)
        if (number % 2 == 0)
          newN.Add(number);

      // 4. List를 오름차순으로 정렬
      newN.Sort();

      // 5. 출력
      foreach (var number in newN) Console.Write(number + " ");
      Console.WriteLine('\n');

      #endregion

      #region LINQ를 사용한 경우
      // 2. 쿼리 만들기 (짝수만 오른차순으로 남기는 쿼리)
      var linqList = from num in numbers where num % 2 == 0 orderby num select num;

      
      // 3. 쿼리 실행
      foreach (var number in newN) Console.Write(number + " ");
      Console.WriteLine('\n');
      #endregion
      
      // 2. 쿼리 만들기 (2와 3의 공배수만 오른차순으로 남기는 쿼리)
      var linqList2 = from num in numbers where num % 2 == 0 && num % 3 == 0 orderby num select num;
      foreach (var number in linqList2) Console.Write(number + " ");
    }
  }
}