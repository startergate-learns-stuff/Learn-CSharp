using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task04_Parallel
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
      long startNum = 2, endNum = 100000;

      Console.WriteLine("Started");
      DateTime startTime = DateTime.Now;
      
      List<long> totalList = new List<long>();

      Parallel.For(startNum, endNum, (long i) =>
      {
        if (IsPrime(i))
        {
          lock (totalList)
          {
            totalList.Add(i);
          }
        }
      });
      
      DateTime endTime = DateTime.Now;
      TimeSpan elapsed = endTime - startTime;  // TimeSpan은 두 날짜 간의 시간 간격을 지정
      Console.WriteLine($"{startNum} ~ {endNum} 소수 개수 = {totalList.Count}");
      Console.WriteLine($"실행 시간: {elapsed}");
    }
  }
}