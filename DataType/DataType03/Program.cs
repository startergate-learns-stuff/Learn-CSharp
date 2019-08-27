/*
 * 문자열 ↔ 숫자 변환
 */

using System;

namespace DataType03
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string strNum = "12345";
      int num = int.Parse(strNum);

      strNum = 12345.ToString();

      string input = Console.ReadLine();
      Console.WriteLine(input.GetType());
      int i = Convert.ToInt32(input);
      Console.WriteLine(i.GetType());
    }
  }
}