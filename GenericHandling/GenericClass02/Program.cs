using System;

// 교재 379p 예제
namespace GenericClass02
{
  internal class MyList<T>
  {
    private T[] array;

    public MyList()
    {
      array = new T[3];
    }

    public T this[int index]
    {
      get { return array[index]; }
      set
      {
        if (index >= array.Length)
        {
          Array.Resize(ref array, index + 1);
          Console.WriteLine($"Array Resized: {array.Length}");
        }

        array[index] = value;
      }
    }
    
    public int Length
    {
      get { return array.Length; }
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      MyList<string> strList = new MyList<string>();
      strList[0] = "abc";
      strList[1] = "abc";
      strList[2] = "abc";
      strList[3] = "abc";
      strList[4] = "abc";
      strList[5] = "abc";

      for (int i = 0; i < strList.Length; i++)
      {
        Console.Write($"{strList[i]} ");
      }

      Console.WriteLine('\n');
      
      MyList<int> intList = new MyList<int>();
      intList[0] = 100;
      intList[1] = 100;
      intList[2] = 100;
      intList[3] = 100;
      intList[4] = 100;
      intList[5] = 100;
      
      PrintArray<int>(intList);
    }
    
    public static void PrintArray<T>(MyList<T> array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write($"{array[i]} ");
      }

      Console.WriteLine('\n');
    }
  }
}