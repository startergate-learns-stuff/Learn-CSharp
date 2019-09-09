using System;

namespace Class07_IsAs
{
  public class Mammal
  {
    protected string name;

    public Mammal(string name)
    {
      this.name = name;
      Console.WriteLine($"생성자 호출: {name}.Mammal()");
    }

    public string GetName()
    {
      return name;
    }
  }

  public class Dog : Mammal
  {
    public Dog(string name) : base(name)
    {
      Console.WriteLine($"생성자 호출: {name}.Dog()");
    }

    public void Bark()
    {
      Console.WriteLine($"{name} Barked.");
    }
  }

  public class Cat : Mammal
  {
    public Cat(string name) : base(name)
    {
      Console.WriteLine($"생성자 호출: {name}.Cat()");
    }

    public void Meow()
    {
      Console.WriteLine($"{name} Meowed.");
    }
  }
}