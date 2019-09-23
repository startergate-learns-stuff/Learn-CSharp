﻿using System;

// Indexer (객체를 배열처럼 사용)
namespace Indexer
{
  internal class MyList
  {
    private int[] arr = new int[5];
    
    public int this[int index]
    {
      get { return arr[index]; }
      set
      {
        if (index >= arr.Length)
          Console.WriteLine("index가 범위를 벗어남");
        else
          arr[index] = value;
      }
    }

    public int Length
    {
      get { return arr.Length; }
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      MyList myList = new MyList();
      // list.arr[0] = 10;
      myList[0] = 100;
      myList[1] = 200;

      for (int i = 0; i < 6; i++)
        myList[i] = (i + 1) * 100;
      for (int i = 0; i < myList.Length; i++)
        Console.WriteLine(myList[i]);
    }
  }
}