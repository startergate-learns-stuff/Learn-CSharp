using System;

namespace ClassTest01
{
  internal class Cube
  {
    private int x, y, z;

    public static int countOfInstance = 0;
    
    public Cube(int x, int y, int z)
    {
      this.x = x;
      this.y = y;
      this.z = z;
      countOfInstance++;
    }

    public int GetVolume()
    {
      return x * y * z;
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Cube cube1 = new Cube(10, 20, 30);
      Cube cube2 = new Cube(20, 40, 60);

      Console.WriteLine($"cube1: {cube1.GetVolume()}, cube2: {cube2.GetVolume()}");

      Console.WriteLine($"total count: {Cube.countOfInstance}");
    }
  }
}