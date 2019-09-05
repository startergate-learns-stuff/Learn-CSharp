using System;

namespace Class01
{
  public class Cat
  {
    public string name = "야옹이";
    public string color;

    public Cat()
    {
      
    }
    
    public Cat(string name, string color)
    {
      this.name = name;
      this.color = color;
    }
    
    public void Meow()
    {
      Console.WriteLine($"{name} Meowed.");
    }
  }
}