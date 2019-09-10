using System;

namespace Class11_Tuple
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 명명되지 않은 튜플
      var tuple = (100, 3.14f);
      Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
      
      // 명명된 튜플
      var tuple2 = (Name: "아이유", Age: 26);
      Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");
      
      // 분해
      var (name, age) = tuple2;
      Console.WriteLine($"{name}, {age}");

      var (name2, _) = tuple2;
      Console.WriteLine($"{name2}");
      
      // 명명된 튜플 = 명명되지 않은 튜플
      tuple2 = ("이지홍", 17);
      Console.WriteLine($"{tuple2.Name}, {tuple2.Age}");
    }
  }
}