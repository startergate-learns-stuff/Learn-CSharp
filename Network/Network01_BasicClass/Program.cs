using System;
using System.Net;

namespace Network01_BasicClass
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1. IPAddress 클래스: IP 주소 <-> long형 값 변환
      IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
      Console.WriteLine($"IPAddress.Address: {ipAddress.Address}");
      Console.WriteLine($"IPAddress.ToString(): {ipAddress}");

      Console.WriteLine();
      
      // 2. DNS 클래스
      Console.WriteLine($"Dns.GetHostName(): {Dns.GetHostName()}");
      IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
      foreach (var ip in ips)
      {
        Console.WriteLine(ip); // [0] => IPv6, [1] => IPv6
      }

      Console.WriteLine();
      
      IPAddress[] ips2 = Dns.GetHostAddresses("www.naver.com");
      foreach (var ip in ips2)
      {
        Console.WriteLine(ip); // [0] => IPv6, [1] => IPv6
      }

      Console.WriteLine();
      
      // 3. IPHostEntry: 인터넷 호스트 주소 정보에 대한 컨테이너 클래스
      IPHostEntry host = Dns.GetHostEntry("www.donote.co");
      foreach (var ip in host.AddressList)
      {
        Console.WriteLine(ip);
      }
      
      Console.WriteLine($"host.HostName: {host.HostName}");

      Console.WriteLine();
      
      IPHostEntry myIPHost = Dns.GetHostEntry(Dns.GetHostName());
      foreach (var ip in myIPHost.AddressList)
      {
        Console.WriteLine(ip);
      }

      Console.WriteLine($"myIPHost.HostName: {myIPHost.HostName}");
      
      // 4. IPEndPoint: 목적지 IP 주소, 포트 번호 저장
      IPAddress ipAddress2 = IPAddress.Parse("127.0.0.1");
      IPEndPoint ipEndPoint = new IPEndPoint(ipAddress2, 3000);
      Console.WriteLine($"ipEndPoint.Address: {ipEndPoint.Address}");
      Console.WriteLine($"ipEndPoint.Port: {ipEndPoint.Port}");
      Console.WriteLine($"ipEndPoint.ToString(): {ipEndPoint}");
      
    }
  }
}