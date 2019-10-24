using System;
using System.Threading;

// Thread (명령어를 실행하기 위한 스케줄링 단위로 프로세스 내부에서 생성 가능)
namespace Thread01
{
  class Program
  {
    // 메인 스레드
    static void Main(string[] args)
    {
      // 스레드의 존재 확인
      Thread thread = Thread.CurrentThread; // 현재 실행 중인 스레드
      Console.WriteLine(thread.ThreadState);
      
      // Thread.Sleep() : Running 상태인 스레드를 지정된 시간만큼 중지
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine(DateTime.Now);
        Thread.Sleep(1000);
      }
      
      // 새로운 스레드 생성
      Thread t = new Thread(ThreadFunc);
      // t.IsBackground = true; // 메인이 끝나면 종료됨
      t.Start();
      t.Join(); // 스레드가 완료될 때까지 다른 스레드들은 대기
      
      Console.WriteLine("하아하아 죽여버렸어");
    }

    private static void ThreadFunc()
    {
      Thread.Sleep(1000);
      Console.WriteLine("하아하아 죽어버릴것만 같아");
    }
  }
}