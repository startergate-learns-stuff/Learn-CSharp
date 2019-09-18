using System;

namespace ClassTest05
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
      Cube cube1 = new Cube(1, 2, 3);
      Cube cube2 = new Cube(10, 20, 30);

      Console.WriteLine(cube1.GetVolume());
      Console.WriteLine(cube2.GetVolume());

      Console.WriteLine(Cube.countOfInstance);
    }
  }
}