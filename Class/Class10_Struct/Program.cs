﻿using System;

namespace Class10_Struct
{
  struct Point3D
  {
    public int x, y, z;

    public Point3D(int x, int y, int z)
    {
      this.x = x;
      this.y = y;
      this.z = z;
    }
    
    public string ToString()
    {
      return $"{x}, {y}, {z}";
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Point3D p1 = new Point3D(10, 20, 30);
      Console.WriteLine(p1.ToString());
      
      Point3D p2 = new Point3D(100, 200, 300);

      Point3D p3 = p2;
      p3.z = 500;

      Console.WriteLine(p2.ToString());
      Console.WriteLine(p3.ToString());
    }
  }
}