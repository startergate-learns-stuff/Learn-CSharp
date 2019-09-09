namespace Class08_Polymorphism
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Mammal one = new Mammal();
      one.Move();
      
      Lion lion = new Lion();
      lion.Move();
      /* 자식이 부모 타입으로 암시적으로 형변환된 경우 */
      one = lion;
      one.Move();
      
      Mammal two = new Human();
      two.Move();
    }
  }
}