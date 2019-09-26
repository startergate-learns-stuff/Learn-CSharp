using System;

// 412p 예제
namespace Exception04_finally
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        Console.Write("나누어지는 수를 입력하세요: ");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.Write("나누는 수를 입력하세요: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
      }
      catch (FormatException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        Console.WriteLine("프로그램 종료");
      }
    }

    private static object Divide(int dividend, int divisor)
    {
      try
      {
        Console.WriteLine("Divide() 메소드 시작");
        return dividend / divisor;
      }
      catch (DivideByZeroException e)
      {
        Console.WriteLine("Divide() 예외 발생");
        Console.WriteLine(e.Message);
        throw e;
      }
      finally
      {
        Console.WriteLine("Divide() 메소드 종료");
      }
    }
  }
}