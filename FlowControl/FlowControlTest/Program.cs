using System;

namespace FlowControlTest
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var time = DateTime.Now;
      Console.WriteLine("현재 {0} {1}시 입니다.", time.Hour >= 12 ? "오후": "오전", time.Hour);
    }
  }
}