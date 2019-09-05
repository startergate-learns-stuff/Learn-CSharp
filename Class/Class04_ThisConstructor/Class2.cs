﻿using System;

namespace Class04_ThisConstructor
{
  public class Class2
  {
    private int a, b, c;

    public Class2()
    {
      a = 1;
      Console.WriteLine("Class1() 생성자 호출");
    }

    public Class2(int b) : this()
    {
      this.b = b;
      Console.WriteLine($"Class1(int {b}) 생성자 호출");
    }

    public Class2(int b, int c) : this(b)
    {
      this.c = c;
      Console.WriteLine($"Class1(int {b}, int {c}) 생성자 호출");
    }

    public void PrintFields()
    {
      Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
  }
}