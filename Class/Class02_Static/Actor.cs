using System;

namespace Class02_Static
{
  public class Actor
  {
    // 인스턴스 필드
    public string Name;
    public int CountOfInstance;
    
    // 정적 필드
    public static int StaticCountOfInstance;

    public Actor(string name)
    {
      this.Name = name;
      CountOfInstance++;
      StaticCountOfInstance++;
      Console.WriteLine($"{name} 객체 생성");
    }

    public void SetName(string name)
    {
      this.Name = name;
    }

    public static int GetCount()
    {
      return StaticCountOfInstance;
    }
  }
}