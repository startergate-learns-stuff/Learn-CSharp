using System;

// Getter, Setter와 Properties 비교
namespace Properties01
{
  class Person_GetSet
  {
    private string name;

    public string GetName()
    {
      return name;
    }

    public void SetName(string name)
    {
      this.name = name;
    }
  }

  class Person_Prop
  {
    private string name;
    public string Name
    {
      get { return name;}
      set { name = value; } // 암묵적 매개 변수
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Person_GetSet p1 = new Person_GetSet();
      p1.SetName("장만월");
      Console.WriteLine(p1.GetName());
      
      Person_Prop p2 = new Person_Prop();
      p2.Name = "아이유";
      Console.WriteLine(p2.Name);
      
      int[] nums = new int[5];
    }
  }
}