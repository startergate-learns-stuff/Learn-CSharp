using System;
using System.Collections;

namespace Operator01
{
  class Foo
  {
    public int Member { get; } = 100;
  }
  
  internal class Program
  {
    
    public static void Main(string[] args)
    {
      // Null 조건부 연산자
      Foo foo = new Foo();

      int? bar;
      //if (foo == null)
      //  bar = null;
      //else
      //  bar = foo.Member;

      bar = foo?.Member;

      Console.WriteLine(bar);

      ArrayList arr = null;
      arr?.Add("야구");
      arr?.Add("축구");

      Console.WriteLine(arr?.Count);
      Console.WriteLine(arr?[0]);
      Console.WriteLine(arr?[1]);
      
      arr = new ArrayList();
      arr?.Add("야구");
      arr?.Add("축구");

      Console.WriteLine(arr?.Count);
      Console.WriteLine(arr?[0]);
      Console.WriteLine(arr?[1]);
    }
  }
}