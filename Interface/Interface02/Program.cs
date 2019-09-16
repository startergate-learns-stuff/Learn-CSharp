using System;

namespace Interface02
{
  internal interface IProduct
  {
    string ProductName { get; set; }
    int Price { get; set; }
  }

  internal class Product : IProduct
  {
    private string productName;

    public string ProductName
    {
      get => productName;
      set => productName = value;
    }

    public int Price { get; set; }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Product p = new Product();
      p.ProductName = "노트북";
      p.Price = 2_000_000;
      Console.WriteLine($"{p.ProductName}, {p.Price}");
    }
  }
}