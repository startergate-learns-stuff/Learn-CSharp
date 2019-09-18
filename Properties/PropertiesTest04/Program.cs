using System;

namespace PropertiesTest04
{
  class NameCard
  {
    public int Age { get; set; }
    public string Name { get; set; }
  }
  internal class Program
  {
    public static void Main(string[] args)
    {
      NameCard MyCard = new NameCard();

      MyCard.Age = 24;
      MyCard.Name = "상현";

      Console.WriteLine($"나이: {MyCard.Age}");
      Console.WriteLine($"이름: {MyCard.Name}");
    }
  }
}