﻿using System;

namespace AbstractClass01
{
  internal abstract class AbstractBase
  {
    protected void PrivateMethod()
    {
      Console.WriteLine("AbstractBase.PrivateMethod()");
    }

    public void PublicMethod()
    {
      Console.WriteLine("AbstractBase.PublicMethod()");
    }
      
    public abstract void AbstractMethod(); // 추상 메소드
  }

  class Derived : AbstractBase
  {
    public override void AbstractMethod()
    {
      Console.WriteLine("Derived.AbstractMethod()");
      PrivateMethod();
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      AbstractBase obj = new Derived();
      obj.AbstractMethod();
      obj.PublicMethod();
    }
  }
}