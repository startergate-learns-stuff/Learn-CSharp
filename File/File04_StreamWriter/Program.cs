﻿using System;
using System.IO;
using System.Text;


// Stream에 문자열 데이터를 기록하려면 반드시 그 전에 바이트 배열로 변환해야 한다.
namespace File04_StreamWriter
{
  class Program
  {
    static void Main(string[] args)
    {
      string path1 = @"D:\CodingData\Learn-CSharp\TestDirectoryStreamWriter\Text1.txt";
      string path2 = @"D:\CodingData\Learn-CSharp\TestDirectoryStreamWriter\Text2.txt";

      #region FileStream으로 데이터 쓰고 읽기

      // FileStream으로 데이터 쓰기
      FileStream fs1 = new FileStream(path1, FileMode.Create);
      byte[] buf = Encoding.UTF8.GetBytes("Hello World\n");
      fs1.Write(buf, 0, buf.Length);
      buf = Encoding.UTF8.GetBytes(32000.ToString());
      fs1.Write(buf, 0, buf.Length);

      Console.WriteLine($"fs1.Position: {fs1.Position}");

      // FileStream으로 데이터 읽기
      byte[] readBytes = new byte[fs1.Position];
      fs1.Position = 0;
      fs1.Read(readBytes, 0, readBytes.Length);
      UTF8Encoding temp = new UTF8Encoding();
      Console.WriteLine(temp.GetString(readBytes));
      fs1.Close();

      #endregion

      #region StreamWriter/StreamReader 사용 (문자 스트림 도우미)

      // StreamWriter로 문자 쓰기
      FileStream fs2 = new FileStream(path2, FileMode.Create);
      StreamWriter sw = new StreamWriter(path2);
      sw.WriteLine("Hello World");
      sw.WriteLine(32000);

      // StreamWriter로 문자 읽기
      StreamReader sr = new StreamReader(new FileStream(path2, FileMode.Open));
      Console.WriteLine(sr.Read());
      sr.Close();
      #endregion
    }
  }
}