using System;

namespace Class04_ThisConstructor
{
  public class Class1
  {
    private int a, b, c;

    public Class1()
    {
      a = 1;
      Console.WriteLine("Class1() 생성자 호출");
    }

    public Class1(int b)
    {
      a = 1;
      this.b = b;
      Console.WriteLine($"Class1(int {b}) 생성자 호출");
    }

    public Class1(int b, int c)
    {
      a = 1;
      this.b = b;
      this.c = c;
      Console.WriteLine($"Class1(int {b}, int {c}) 생성자 호출");
    }

    public void PrintFields()
    {
      Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
  }
}