using System;

namespace Class02_Static
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Actor a1 = new Actor("아이유");
      Actor a2 = new Actor("박보검");
      Actor a3 = new Actor("정해인");
      
      // 인스턴스 필드 출력
      Console.WriteLine(a1.CountOfInstance);
      Console.WriteLine(a2.CountOfInstance);
      
      // 정적 필드 출력
      Console.WriteLine(Actor.StaticCountOfInstance);
      
      a1.SetName("이지은");
      Console.WriteLine(a1.Name);

      Console.WriteLine($"생성된 객체 숫자: {Actor.GetCount()}");
      
    }
  }
}