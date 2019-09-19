using System;

namespace AbstractClass02
{
  internal abstract class Product
  {
    private static int serial = 0;

    public string SerialID
    {
      get { return String.Format("{0:d5}", serial++); }
    }
    
    public abstract DateTime ProductDate { get; set; } // 추상 프로퍼티
  }
  
  class MyProduct : Product
  {
    public override DateTime ProductDate { get; set; }
  }

  internal class Program
  {
    public static void Main(string[] args)
    {
      Product p1 = new MyProduct()
      {
        ProductDate = new DateTime(2019, 9, 18)
      };
      Console.WriteLine("Prodect: {0}, ProductDate: {1}", p1.SerialID, p1.ProductDate);

      Product p2 = new MyProduct();
      p2.ProductDate = new DateTime(2019, 9, 18);
      Console.WriteLine($"Prodect: {p1.SerialID}, ProductDate: {p1.ProductDate}");
    }
  }
}