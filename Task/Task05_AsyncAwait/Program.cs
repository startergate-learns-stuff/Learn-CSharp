﻿using System;
using System.Threading;
using System.Threading.Tasks;

// 656p 예제
// async 한정자: 비동기임을 나타내는 한정자
// await 연산자: 비동기 코드
// async 한정자를 사용하는 메소드는 반환 형식이 void, Task, Task<>이어야 함
namespace Task05_AsyncAwait
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("A");
      Console.WriteLine("B");

      MyMethodAsync(3);
      
      Console.WriteLine("E");
      Console.WriteLine("F");

      Console.ReadLine();
    }

    private static async void MyMethodAsync(int count)
    {
      Console.WriteLine("C");
      Console.WriteLine("D");

      await Task.Run(() =>
      {
        for (int i = 1; i < count; i++)
        {
          Thread.Sleep(1000);
          Console.WriteLine($"{i}/{count}");
        }
      });

      Console.WriteLine("G");
      Console.WriteLine("H");
    }
  }
}