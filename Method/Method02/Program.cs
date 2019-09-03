/*
 * 참조에 의한 매개변수 전달 : in, ref, out
 */

using System;

namespace Method02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // params -------------------------------

      int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      UseParams(myIntArray);
      UseParams(9, 8, 7, 6, 5, 4, 3, 2, 1);

      void UseParams(params int[] intArr)
      {
        for (int j = 0; j < intArr.Length; j++)
        {
          Console.Write(intArr[j] + " ");
        }
        Console.WriteLine();
      }
      
      // in -----------------------------------

      int i = 44;
      InArgExample(i); // 44
      Console.WriteLine(i); // 44

      void InArgExample(in int inArg)
      {
        Console.WriteLine(inArg);
      }
      
      // ref : 참조에 의한 인수 전달 --------------

      int r = 90;
      Console.WriteLine(r); // 90
      RefArgExample(ref r);
      Console.WriteLine(r); // 100

      void RefArgExample(ref int refArg)
      {
        refArg += 10;
      }

      int x = 100, y = 3, q = 0, re = 0;
      Divide(x, y, ref q, ref re);
      Console.WriteLine("몪 {0}, 나머지 {1}", q, re);

      void Divide(int a, int b, ref int quofient, ref int remainder)
      {
        quofient = a / b;
        remainder = a % b;
      }
      
      // out : 참조에 의한 인수 전달 --------------

      int outVar;
      OutArgExample(out outVar);
      Console.WriteLine(outVar);
      
      void OutArgExample(out int outArg)
      {
        outArg = 999;
      }

      string s = "1234";
      if (int.TryParse(s, out int result))
      {
        Console.WriteLine("result: {0}", result);
      }
      Console.WriteLine("result: {0}", result);

      x = 100;
      y = 7;
      OutDivide(x, y, out q, out re);
      Console.WriteLine("몪 {0}, 나머지 {1}", q, re);
      void OutDivide(int a, int b, out int quofient, out int remainder)
      {
        quofient = a / b;
        remainder = a % b;
      }
    }
  }
}