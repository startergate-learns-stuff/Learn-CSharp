using System;
using System.Runtime.InteropServices;

namespace GenericConstraint02
{
  internal class Utility
  {
    public static T Max<T>(T item1, T item2) where T : IComparable
    {
      if (item1.CompareTo(item2) >= 0) // 양수: item1이 크다, 0: 같다, 음수: item1이 작다
        return item1;

      return item2;
    }

    public static int GetSize<T>(T item) where T : struct
    {
      return Marshal.SizeOf(item);
    }

    public static void CheckNull<T>(T item) where T : class
    {
      if (item == null)
        Console.WriteLine("null 값임.");
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(Utility.Max(5, 6));
      Console.WriteLine(Utility.Max(3.14, 9.87));
      Console.WriteLine(Utility.Max('Z', 'A'));
      Console.WriteLine(Utility.Max("ABC", "DEF"));

      int num = 5;
      string str = "abc";
      Console.WriteLine(Utility.GetSize<int>(num));
      Console.WriteLine(Utility.GetSize<decimal>(3.14m));
      // Console.WriteLine(Utility.GetSize<string>(str));

      string str2 = null;
      Utility.CheckNull<string>(str2);
      // Utility.CheckNull<int>(num);

      int? num2 = null;
      // Utility.CheckNull<int?>(num2);
    }
  }
}