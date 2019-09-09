using System;

namespace Class06_Inheritance
{
  internal class Base
  {
    public Base()
    {
      Console.WriteLine("Base()");
    }

    ~Base()
    {
      Console.WriteLine("~Base()");
    }
  }

  internal class Derived : Base
  {
    public Derived()
    {
      Console.WriteLine("Derived()");
    }

    ~Derived()
    {
      Console.WriteLine("~Derived()");
    }
  }
}