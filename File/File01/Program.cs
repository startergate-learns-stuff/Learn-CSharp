using System;
using System.IO;

namespace File01
{
  class Program
  {
    static void Main(string[] args)
    {
      // CreateDirectoryUsingDirectory();
      CreateDirectoryUsingDirectoryInfo();
    }

    #region Directory, File 클래스

    private static void CreateDirectoryUsingDirectory()
    {
      string path = @"D:\CodingData\Learn-CSharp\TestDirectory";

      if (Directory.Exists(path))
      {
        DeleteFileUsingFile(path);
        Directory.Delete(path);
        Console.WriteLine($"Directory {path} Deleted");
      }
      else
      {
        Directory.CreateDirectory(path);
        Console.WriteLine($"Directory {path} Created");
        CreateFileUsingFile(path);
      }
    }

    private static void DeleteFileUsingFile(string path)
    {
      path += @"\Test.txt";
      if (File.Exists(path)) 
      {
        File.Delete(path); 
        Console.WriteLine($"File Deleted at {path}");
      }
    }

    private static void CreateFileUsingFile(string path)
    {
      path += @"\Test.txt";
      if (!File.Exists(path))
      {
        FileStream fs = File.Create(path);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Hello");
        sw.WriteLine("File");
        sw.Close();
        Console.WriteLine($"File Created at {path}");
      }
    }

    #endregion

    #region DirectoryInfo, FileInfo 클래스

    
    private static void CreateDirectoryUsingDirectoryInfo()
    {
      string dirPath = @"D:\CodingData\Learn-CSharp\TestDirectoryInfo";
      string filePath = dirPath + @"\TestInfo.txt";
      
      DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
      FileInfo fileInfo = new FileInfo(filePath);

      if (dirInfo.Exists)
      {
        DeleteFileUsingFileInfo(fileInfo);
        dirInfo.Delete();
        Console.WriteLine($"Directory Deleted. {dirPath}");
      }
      else
      {
        dirInfo.Create();
        Console.WriteLine($"Directory Created. {dirPath}");
        CreateFileUsingFileInfo(fileInfo);
        ReadFileUsingFileInfo(fileInfo);
      }
    }

    private static void ReadFileUsingFileInfo(FileInfo fileInfo)
    {
      StreamReader sr = fileInfo.OpenText();
      string s;
      while ((s = sr.ReadLine()) != null)
      {
        Console.WriteLine(s);
      }
      sr.Close();
      Console.WriteLine($"File has been read. {fileInfo.FullName}");
    }

    private static void DeleteFileUsingFileInfo(FileInfo fileInfo)
    {
      fileInfo.Delete();
      Console.WriteLine($"File Deleted. {fileInfo.FullName}");
    }

    private static void CreateFileUsingFileInfo(FileInfo fileInfo)
    {
      StreamWriter sw = fileInfo.CreateText();
      sw.WriteLine("안녕하세요");
      sw.WriteLine("내일은 축제");
      sw.Close();
      Console.WriteLine($"File Created. {fileInfo.FullName}");
    }

    #endregion
  }
}