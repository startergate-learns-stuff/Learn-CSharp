/* 가변 길이 매개 변수, 명명된 매개변수 */

using System;

namespace Method04
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 명명된 매개변수
      PrintProfile("박찬호", "010-123-4567");
      PrintProfile(name: "손흥민", phone: "010-777-7777");
      
      // 선택적 매개변수
      PrintProfile("아이유");
    }

    static void PrintProfile(string name, string phone="전화번호 모름")
    {
      Console.WriteLine($"Name: {name}, Phone: {phone}");
    }
  }
}