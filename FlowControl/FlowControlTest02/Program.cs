using System;
using System.Text.RegularExpressions;

namespace FlowControlTest02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      char c = (char) Console.Read();
      Regex r = new Regex("[A-Za-z]");
      Console.WriteLine(r.IsMatch(c.ToString()) ? "{0}는 알파벳입니다." : "{0}는 알파벳이 아닙니다.", c);
    }
  }
}