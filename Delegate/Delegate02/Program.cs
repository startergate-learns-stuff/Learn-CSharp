using System;
using System.IO;

// 1급 함수 (first class function)로서의 델리게이트
namespace Delegate02
{
  // 델리게이트 선언
  delegate void PrintStr(string s);

  internal class PrintString
  {
    public static void sendString(string str, PrintStr ps)
    {
      ps(str);
    }
  }
  
  internal class Program
  {
    private static StreamWriter sw;
    
    // 콘솔 출력 메소드
    public static void WriteToScreen(string str)
    {
      Console.WriteLine("public static void WriteToScreen(string str)");
      Console.WriteLine("The String is {0}", str);
    }
    
    // 파일 출력 메소드
    public static void WriteToFile(string str)
    {
      Console.WriteLine("public static void WriteToFile(string str)");
      sw = File.CreateText("MyLog.txt");
      sw.WriteLine($"The String is {str}");
      sw.Flush();
      sw.Close();
    }
    
    public static void Main(string[] args)
    {
      PrintStr ps1 = new PrintStr(WriteToScreen);
      PrintString.sendString("Hello World", ps1);
      
      
      PrintStr ps2 = new PrintStr(WriteToFile);
      PrintString.sendString("Hello World", ps2);
    }
  }
}