using System;

namespace Delegate06_Chain
{
  delegate void Emergency(string location);
  
  internal class Program
  {
    static void Call119(string location)
    {
      Console.WriteLine($"소방서죠? {location}에 불이 났어요!!");
    }
    
    static void Shout(string location)
    {
      Console.WriteLine($"피하세요! {location}에 불이 났어요!!");
    }
    
    static void Escape(string location)
    {
      Console.WriteLine($"{location}에서 나갑시다!!");
    }
    
    public static void Main(string[] args)
    {
      // 2. 델리게이트 인스턴스 생성
      Emergency em = new Emergency(Call119);
      // 3. 인스턴스 메소드를 연결
      em = Call119;
      em += Shout;
      em += Escape;
      // 4. 델리게이트 실행
      em("우리 집");
    }
  }
}