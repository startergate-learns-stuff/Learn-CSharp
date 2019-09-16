using System;
using System.Numerics;

namespace PropertiesTest02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var nameCard = new { Name = "상현", Age = 24 };
      Console.WriteLine($"이름: {nameCard.Name}, 나이: {nameCard.Age}");

      var complex = new {Real = new Complex(12, 15).Real, Imaginary = new Complex(12, 15).Imaginary};
      Console.WriteLine($"Real: {complex.Real}, Imaginary: {complex.Imaginary}");
    }
  }
}