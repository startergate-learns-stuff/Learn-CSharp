using System;

// 자동 구현 프로퍼티
namespace Properties03
{
  class NameCard1
  {
    private string name;
    private string phoneNum;

    public string Name
    {
      get => name;
      set => name = value;
    }

    public string PhoneNum
    {
      get => phoneNum;
      set => phoneNum = value;
    }
  }

  class NameCard2 // 자동 구현 프로퍼티
  {
    public string Name { get; set; }
    public string PhoneNum { get; set; }
  }

  class NameCard3 // 자동 구현 프로퍼티
  {
    public string Name { get; set; } = "UnKnown";
    public string PhoneNum { get; set; } = "000-0000-0000";
  }  
  internal class Program
  {
    public static void Main(string[] args)
    {
      NameCard1 n1 = new NameCard1();
      n1.Name = "박보검";
      Console.WriteLine(n1.Name);
      
      NameCard2 n2 = new NameCard2();
      n2.Name = "장만월";
      Console.WriteLine(n2.Name);
      
      NameCard3 n3 = new NameCard3();
      Console.WriteLine(n3.Name);
      
      NameCard2 n4 = new NameCard2()
      {
        Name = "아이유",
        PhoneNum = "010-111-2222"
      };
      Console.WriteLine(n4.Name);
    }
  }
}