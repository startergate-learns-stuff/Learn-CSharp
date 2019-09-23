﻿using System;
using System.Collections;
using System.Collections.Generic;

// Stack (First In Last Out)
namespace Collections03
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      #region System.Collections.Stack
      
      Stack s = new Stack();
      s.Push(1);
      s.Push(3.14);
      s.Push('A');
      s.Push("Stack");
      
      while(s.Count > 0) Console.Write($"{s.Pop()} ");
      Console.WriteLine('\n');
      
      #endregion
      
      #region System.Collections.Generic.Stack
      
      Stack<char> s2 = new Stack<char>();
      string str = "Stack";
      foreach (var item in str)
      {
        s2.Push(item);
      }

      PrintStack(s2);

      Stack<int> s3 = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });
      
      while (s3.Count > 0) Console.Write($"{s3.Pop()} ");
      Console.WriteLine('\n');
      
      #endregion
    }

    private static void PrintStack(Stack<char> s2)
    {
      while (s2.Count > 0) Console.Write($"{s2.Pop()} ");
      Console.WriteLine('\n');
    }
  }
}