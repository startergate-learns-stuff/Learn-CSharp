using System;
using System.IO;

namespace File01
{
  class Program
  {
    static void Main(string[] args)
    {
      CreateDirectoryUsingDirectory();
    }

    private static void CreateDirectoryUsingDirectory()
    {
      string path = @"D:\CodingData\Learn-CSharp\TestDirectory";

      if (Directory.Exists(path))
      {
        Directory.Delete(path);
        Console.WriteLine($"Directory {path} Deleted");
      }
      else
      {
        Directory.CreateDirectory(path);
        Console.WriteLine($"Directory {path} Created");
      }
    }
  }
}