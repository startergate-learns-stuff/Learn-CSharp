using System;

namespace MethodTest02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(FullSequenceOfLetters("ds"));
      Console.WriteLine(FullSequenceOfLetters("or"));
    }

    static string FullSequenceOfLetters(string s)
    {
      char[] arr = s.ToCharArray();
      string output = "";
      for (var i = Convert.ToUInt16(arr[0]); i < Convert.ToUInt16(arr[1] + 1); i++)
      {
        output += ((char) i).ToString();
      }

      return output;
    }
  }
}