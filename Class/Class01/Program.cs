using System;

namespace Class01
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Cat kitty = new Cat();
      kitty.name = "키티";
      kitty.color = "하얀색";
      kitty.Meow();
      Console.WriteLine($"{kitty.color} {kitty.name}가 울부짖었다");
      
      Cat nero = new Cat();
      nero.name = "네로";
      nero.color = "검정색";
      nero.Meow();
      Console.WriteLine($"{nero.color} {nero.name}가 울부짖었다");
      
      Cat nabi = new Cat("나비", "갈색");
      nabi.Meow();
      Console.WriteLine($"{nabi.color} {nabi.name}가 울부짖었다");
    }
  }
}