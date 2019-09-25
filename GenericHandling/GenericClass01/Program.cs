using System;

// 일반화 클래스 (데이터 형식을 일반화한 클래스)
namespace GenericClass01
{
  class Array_int
  {
    private int[] array = new int[5];

    public int this[int index]
    {
      get { return array[index]; }
      set { array[index] = value; }
    }
  }
  
  class Array_double
  {
    private double[] array = new double[5];

    public double this[int index]
    {
      get { return array[index]; }
      set { array[index] = value; }
    }
  }
  
  class Array_generic<T>
  {
    private T[] array = new T[5];

    public T this[int index]
    {
      get { return array[index]; }
      set { array[index] = value; }
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      Array_int arr1 = new Array_int();
      arr1[0] = 100;
      Console.WriteLine(arr1[0]);
      
      Array_double arr2 = new Array_double();
      arr2[0] = 3.14;
      Console.WriteLine(arr2[0]);
      
      Array_generic<int> arr3 = new Array_generic<int>();
      arr3[0] = 100;
      Console.WriteLine(arr3[0]);
      
      Array_generic<string> arr4 = new Array_generic<string>();
      arr4[0] = "Generic Class";
      Console.WriteLine(arr4[0]);
    }
  }
}