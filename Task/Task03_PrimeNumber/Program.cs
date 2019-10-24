using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// 649p 예제
namespace Task03_PrimeNumber
{
  class Program
  {
    static bool IsPrime(long number)
    {
      if (number == 2)
        return true;
      for (int i = 2; i < number; i++)
        if (number % i == 0)
          return false;

      return true;
    }
    
    static void Main(string[] args)
    {
      long startNum = 2, endNum = 1000000;
      int taskCount = 12;

      Func<object, List<long>> FindPrimeFunc = (objRange) =>
      {
        long[] range = (long[]) objRange;
        List<long> found = new List<long>();

        for (long i = range[0]; i < range[1]; i++)
        {
          if (IsPrime(i))
          {
            found.Add(i);
          }
        }

        return found;
      };
      
      // Task 배열
      Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
      
      // Task별 작업 숫자 지정 (첫 번째 태스크에게 줄 범위)
      long currentStartNum = startNum;
      long currentEndNum = endNum / taskCount;
      
      // 두 번째 Task부터 마지막 Task까지 숫자 범위 지정
      for (int i = 0; i < taskCount; i++)
      {
        Console.WriteLine($"Task[{i}]: {currentStartNum} ~ {currentEndNum}");
        tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] {currentStartNum, currentEndNum});

        currentStartNum = currentEndNum + 1;
        currentEndNum += (endNum / taskCount);
      }

      Console.WriteLine("Started");
      DateTime startTime = DateTime.Now;

      foreach (var task in tasks)
        task.Start();
      
      List<long> totalList = new List<long>();
      
      // 모든 작업이 종료되면 totalList로 합친다
      foreach (var task in tasks)
      {
        task.Wait(); // 모든 작업이 끝날 때까지 기다림
        totalList.AddRange(task.Result); // 리스트에 리스트를 합치는 작업
      }
      
      DateTime endTime = DateTime.Now;
      TimeSpan elapsed = endTime - startTime;  // TimeSpan은 두 날짜 간의 시간 간격을 지정
      Console.WriteLine($"{startNum} ~ {endNum} 소수 개수 = {totalList.Count}");
      Console.WriteLine($"실행 시간: {elapsed}");
    }
  }
}