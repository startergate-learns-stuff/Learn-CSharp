using System;

// 1. 클래스에서 이벤트를 제공한다.
// 2. 외부에서 자유롭게 해당 이벤트를 구독하거나 해지할 수 있다.
// 3. 외부에서 구독 해지는 가능하지만, 이벤트는 오직 클래스 내부에서만 실행된다.
// 4. 이벤트의 첫 번째 인자는 이벤트를 발생시킨 인스턴스이다.
// 5. 이벤트의 두 번째 인자는 해당 이벤트에 속한 의미 있는 값이다.

// 1 ~ n 까지의 값 중에 소수라고 판정될 때마다 콜백을 발생시키는 클래스 구현
namespace Event02_Delegate
{
  internal class CallbackArg { };

  internal class PrimeCallbackArg : CallbackArg
  {
    public int prime;

    public PrimeCallbackArg(int prime)
    {
      this.prime = prime;
    }
  }

  // 소수 생성기 클래스: 소수가 발생할 때마다 등록된 콜백 메서드 호출
  internal class PrimeGenerator
  {
    public delegate void PrimeDelegate(object sender, CallbackArg arg);

    private PrimeDelegate callbacks;

    public void AddDelegate(PrimeDelegate callback)
    {
      callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
    }

    public void RemoveDelegate(PrimeDelegate callback)
    {
      callbacks -= callback as PrimeDelegate;
    }

    public void Run(int limit)
    {
      for (int i = 2; i <= limit; i++)
      {
        if (IsPrime(i) == true && callbacks != null)
        {
          callbacks(this, new PrimeCallbackArg(i));
        }
      }
    }

    private bool IsPrime(int num)
    {
      if (num == 2) return true;
      for (int i = 2; i < num; i++)
        if (num % i == 0)
          return false;

      return true;
    }
  }
  
  internal class Program
  {
    private static int sum;
    
    static void PrintPrime(object sender, CallbackArg arg)
    {
      Console.Write((arg as PrimeCallbackArg).prime + " ");
    }

    static void SumPrime(object sender, CallbackArg arg)
    {
      sum += (arg as PrimeCallbackArg).prime;
    }
    
    public static void Main(string[] args)
    {
      PrimeGenerator gen = new PrimeGenerator();
      
      // 콜백 메소드 추가
      PrimeGenerator.PrimeDelegate callprint = PrintPrime;
      gen.AddDelegate(callprint);

      PrimeGenerator.PrimeDelegate callsum = SumPrime;
      gen.AddDelegate(callsum);
      
      // 2 ~ 10까지의 소수를 판별하면서 콜백 함수 호출
      gen.Run(10);
      Console.WriteLine($"sum: {sum}");
      
      gen.RemoveDelegate(callsum);
      gen.Run(15);
    }
  }
}