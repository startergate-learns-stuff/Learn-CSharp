using System;
using System.IO;
using System.Linq;

namespace File02
{
  class Program
  {
    static void Main(string[] args)
    {
      string directory;

      directory = args.Length < 1 ? "." : args[0];

      Console.WriteLine($"{directory} directory info");
      Console.WriteLine("- Directories: ");

      foreach (var item in Directory.GetDirectories(directory))
      {
        Console.WriteLine(item);
      }
      
      var directories = (from dir in Directory.GetDirectories(directory)
        let info = new DirectoryInfo(dir)
        select new {Name = info.Name, Attribute=info.Attributes}).ToList();


      foreach (var dir in directories)
      {
        Console.WriteLine($"{dir.Name}: {dir.Attribute}");
      }

      Console.WriteLine("- Files: ");
      // 쿼리 만들기
      var files = from file in Directory.GetFiles(directory)
        let info = new FileInfo(file)
        select new {Name = info.Name, FileSize = info.Length, Attribute = info.Attributes};

      foreach (var item in files)
      {
        Console.WriteLine($"{item.Name}, {item.FileSize}, {item.Attribute}");
      }
    }
  }
}