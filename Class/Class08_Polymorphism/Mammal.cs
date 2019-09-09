using System;

namespace Class08_Polymorphism
{
  public class Mammal
  {
    virtual public void Move()
    {
      Console.WriteLine("Mammal Moved.");
    }
  }

  class Lion : Mammal
  {
    override public void Move()
    {
      Console.WriteLine("Lion Moved.");
    }
  }

  class Whale : Mammal
  {
    override public void Move()
    {
      Console.WriteLine("Whale Swim.");
    }
  }

  class Human : Mammal
  {
    override public void Move()
    {
      Console.WriteLine("Human Walked.");
    }
  }
}