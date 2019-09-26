using System;

namespace GenericHandlingTest01
{
  internal class Program
  {
    public static void Swap<T>(ref T obj1, ref T obj2)
    {
      T temp = obj1;
      obj1 = obj2;
      obj2 = temp;
    }
    
    public static void Main(string[] args)
    {
      int n1 = 10, n2 = 20;
      char c1 = 'A', c2 = 'B';
      string s1 = "Hello", s2 = "World";

      Console.WriteLine($"n1: {n1}, n2: {n2}");
      Swap<int>(ref n1, ref n2);
      Console.WriteLine($"n1: {n1}, n2: {n2}");
      Console.WriteLine($"c1: {c1}, c2: {c2}");
      Swap<char>(ref c1, ref c2);
      Console.WriteLine($"c1: {c1}, c2: {c2}");
      Console.WriteLine($"s1: {s1}, s2: {s2}");
      Swap<string>(ref s1, ref s2);
      Console.WriteLine($"s1: {s1}, s2: {s2}");
    }
  }
}