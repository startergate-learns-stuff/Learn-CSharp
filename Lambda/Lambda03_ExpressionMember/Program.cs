using System;
using System.Collections.Generic;

// 476p 예제
namespace Lambda03_ExpressionMember
{
  internal class FriendList
  {
    private List<string> list = new List<string>();

    public void Add(string name) => list.Add(name);
    public void Remove(string name) => list.Remove(name);

    public void PrintAll()
    {
      foreach (var item in list) Console.WriteLine(item);
    }

    public FriendList() => Console.WriteLine("FriendList()");
    ~FriendList() => Console.WriteLine("~FriendList()");

    // public int Capacity => list.Capacity; // 프로퍼티를 식으로 표현
    public int Capacity
    {
      get => list.Capacity;
      set => list.Capacity = value;
    }

    // public string this[int index] => list[index];
    public string this[int index]
    {
      get => list[index];
      set => list[index] = value;
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      FriendList obj = new FriendList();
      obj.Add("아이유");
      obj.Add("장만월");
      obj.Add("이선균");
      obj.Add("문재인");
      obj.Remove("장만월");
      obj.PrintAll();

      Console.WriteLine(obj.Capacity);
      obj.Capacity = 10;
      Console.WriteLine(obj.Capacity);

      Console.WriteLine(obj[0]);

      obj[2] = "조국";
      obj.PrintAll();
    }
  }
}