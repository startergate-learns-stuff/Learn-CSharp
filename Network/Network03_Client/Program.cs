using System;
using System.IO;
using System.Net.Sockets;

namespace Network03_Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("클라이언트");
      
      TcpClient tcpClient = new TcpClient("127.0.0.1", 3000);

      using (NetworkStream ns = tcpClient.GetStream())
      {
        using (StreamReader sr = new StreamReader(ns))
        {
          string str = "";
          while (str != "exit")
          {
            str = sr.ReadLine();
            Console.WriteLine(str);
          }
        }
      }

      Console.WriteLine("클라이언트 종료");
      tcpClient.Close();
    }
  }
}