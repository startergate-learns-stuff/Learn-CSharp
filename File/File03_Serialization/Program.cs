using System;
using System.IO;

// 프로그램에서 다뤄지는 모든 데이터는 엄밀히 byte 데이터다
namespace File03_Serialization
{
  class Program
  {
    static void Main(string[] args)
    {
      // 직렬화 (기본 타입을 바이트 배열로 변환)
      // System.BitConverter
      byte[] boolBytes = BitConverter.GetBytes(true);
      byte[] shortBytes = BitConverter.GetBytes((short) 1024);
      byte[] intBytes = BitConverter.GetBytes(1024);
      
      // 역직렬화 (바이트 배열을 기본 타입으로 변환)
      bool boolData = BitConverter.ToBoolean(boolBytes, 0);
      short shortData = BitConverter.ToInt16(shortBytes, 0);
      int intData = BitConverter.ToInt32(intBytes, 0);
      
      // 바이트 배열을 16진수로 출력 (2진 데이터)
      Console.WriteLine(BitConverter.ToString(boolBytes));
      Console.WriteLine(BitConverter.ToString(shortBytes));
      Console.WriteLine(BitConverter.ToString(intBytes));
      
      // System.IO.MemoryStream: 메모리에 바이트 데이터를 쓰고/읽는 작업 수행
      MemoryStream ms = new MemoryStream();
      ms.Write(shortBytes, 0, shortBytes.Length); // 2 byte 기록
      ms.Write(intBytes, 0, intBytes.Length); // 4 byte 기록

      ms.Position = 0; // Read를 위해  스트림 position을 0으로 초기화
      
      // MemoryStream으로부터 short, int 데이터를 역직렬화
      byte[] outBytes = new byte[2];
      ms.Read(outBytes, 0, 2);
      int shortResult = BitConverter.ToInt16(outBytes, 0);
      Console.WriteLine(shortResult);
      
      outBytes = new byte[4];
      ms.Read(outBytes, 0, 2);
      int intResult = BitConverter.ToInt32(outBytes, 0);
      Console.WriteLine(intResult);
    }
  }
}