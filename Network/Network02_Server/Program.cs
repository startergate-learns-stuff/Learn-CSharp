using System;
using System.IO;
using System.Net.Sockets;

namespace Network02_Server
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("서버");
      
      TcpListener tcpListener = new TcpListener(3000);
      tcpListener.Start(); // 수신 대기 시작
      TcpClient tcpClient = tcpListener.AcceptTcpClient();
      Console.WriteLine($"클라이언트 연결: {tcpClient.Client.RemoteEndPoint}");
      
      using (NetworkStream ns = tcpClient.GetStream())
      {
        using (StreamWriter sw = new StreamWriter(ns))
        {
          sw.AutoFlush = true;
          string str = "";
          while ((str = Console.ReadLine()) != "exit")
          {
            sw.WriteLine(str);
          }
          sw.WriteLine("exit");
        }
      }

      Console.WriteLine("End of Transmission");
      tcpClient.Close();
      tcpListener.Stop();
    }
  }
}