using System;

namespace Properties04
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 무명 형식: 선언과 동시에 인스턴스 생성, 읽기 전용
      var a = new {Name = "아이유", Age = 27};
      Console.WriteLine($"{a.Name}, {a.Age}");

      var b = new {Subject = "수학", Score = new int[] {90, 80, 70, 60}};
      Console.Write($"{b.Subject} ");

      foreach (var sc in b.Score)
      {
        Console.Write($"{sc} ");
      }
      Console.WriteLine();
    }
  }
}