/* ref, out을 이용한 메서드 구현 */

using System;

namespace Method03
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // ref를 이용한 참조에 의한 매개변수 전달
      int x = 3, y = 4;
      Console.WriteLine("x: {0}, y: {1}", x, y);
      // Swap() 메서드를 만들어 ref로 x와 y의 값이 바뀌도록 하시오.
      Swap(ref x, ref y);
      Console.WriteLine("x: {0}, y: {1}", x, y);
      
      // out을 이용한 몫과 나머지 구하기
      int a = 20, b = 3;
      // Divide() 함수 구현
      Divide(a, b, out int q, out int r);
      Console.WriteLine($"a: {a}. b: {b}. a / b: {q}, a % b: {r}");
    }

    static void Swap(ref int x, ref int y)
    {
      int temp = x;
      x = y;
      y = temp;
    }

    static void Divide(int x, int y, out int quotient, out int remainder)
    {
      quotient = x / y;
      remainder = x % y;
    }
  }
}