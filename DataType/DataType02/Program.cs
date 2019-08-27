

/*
 * object 형식, 박싱 / 언박싱
 */

using System;

namespace DataType02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // object ----------------------------------
      object a = 100;
      object b = 3.141592;
      object c = true;
      object d = "Hello World";

      Console.WriteLine("{0, -12}: {1}", a, a.GetType());
      Console.WriteLine("{0, -12}: {1}", b, b.GetType());
      Console.WriteLine("{0, -12}: {1}", c, c.GetType());
      Console.WriteLine("{0, -12}: {1}", d, d.GetType());
      
      // boxing / unboxing -----------------------
      int i = 123;
      object o = i;
      int j = (int) o;

       // Console.WriteLine(o + j); // Error
       Console.WriteLine((int) o + j);
       
       // 언박싱 캐스트
       double e = 2.1561325632425614;
       double f = e;
       object o1 = e; // boxing
       object o2 = f;

       Console.WriteLine(f == e);
       Console.WriteLine(o1 == o2);
       Console.WriteLine((double) o1 == (double) o2);
       Console.WriteLine(o1.Equals(o2));

       int intNum = (int) (double) o1;
    }
  }
}