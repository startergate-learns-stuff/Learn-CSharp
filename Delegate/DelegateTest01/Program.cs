using System;

namespace DelegateTest01
{
  delegate double AreaDelegate(double w, double h);

  internal class ShapeArea
  {
    public void PrintShapeArea(string name, double a, double b, AreaDelegate areaDelegate)
    {
      Console.WriteLine($"{name} 도형의 넓이: {areaDelegate(a, b)}");
    }
  }
  
  internal class Program
  {
    private static double RectangleArea(double a, double b)
    {
      return a * b;
    }
    
    private static double TriangleArea(double a, double b)
    {
      return a * b / 2;
    }
    
    public static void Main(string[] args)
    {
      ShapeArea sa = new ShapeArea();
      sa.PrintShapeArea("사각형", 30, 20, RectangleArea);
      sa.PrintShapeArea("삼각형", 30, 20, TriangleArea);
    }
  }
}