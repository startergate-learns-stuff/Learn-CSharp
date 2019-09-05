namespace Class04_ThisConstructor
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 기본 생성자 사용
      {
        Class1 a1 = new Class1();
        a1.PrintFields();
      
        Class1 a2 = new Class1();
        a2.PrintFields();
      
        Class1 a3 = new Class1();
        a3.PrintFields();
      }
      
      // this() 생성자 사용
      {
        Class1 a1 = new Class1();
        a1.PrintFields();
      
        Class1 a2 = new Class1();
        a2.PrintFields();
      
        Class1 a3 = new Class1();
        a3.PrintFields();
      }
    }
  }
}