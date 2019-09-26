﻿using System;

// 형식 매개 변수 제약시키기
// 교재 384p 예제
namespace GenericConstraint
{
  internal class StructArray<T> where T : struct // 값 형식이어야 한다
  {
    public T[] Array { get; set; }

    public StructArray(int size)
    {
      Array = new T[size];
    }
  }
  
  internal class RefArray<T> where T : class // 참조 형식이어야 한다
  {
    public T[] Array { get; set; }

    public RefArray(int size)
    {
      Array = new T[size];
    }
  }
  
  internal class Base {}
  class Derived : Base {}

  class BaseArray<U> where U : Base // U는 Base 이거나 Base의 파생 클래스여야 함
  {
    public U[] Array { get; set; }

    public BaseArray(int size)
    {
      Array = new U[size];
    }

    public void CopyArray<T>(T[] source) where T : U // T는 U로부터 상속받은 클래스여야 함
    {
      source.CopyTo(Array, 0);
    }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      #region T에 대한 값 형식, 참조 형식 제약 조건
      
      StructArray<int> a = new StructArray<int>(3);
      a.Array[0] = 0;
      a.Array[1] = 1;
      a.Array[2] = 2;
      
      // StructArray<RefArray<int>> b = new StructArray<RefArray<int>>(3);
      
      RefArray<StructArray<int>> b = new RefArray<StructArray<int>>(3);
      b.Array[0] = new StructArray<int>(3);
      b.Array[1] = new StructArray<int>(6);
      b.Array[2] = new StructArray<int>(9);
      
      // RefArray<int> c = new RefArray<int>(3);
      #endregion
      
      BaseArray<Base> c = new BaseArray<Base>(3);
      c.Array[0] = new Base();
      c.Array[1] = new Derived();
      c.Array[2] = CreateInstance<Base>();
      
      BaseArray<Derived> d = new BaseArray<Derived>(2);
      d.Array[0] = new Derived();
      d.Array[1] = CreateInstance<Derived>();

      BaseArray<Derived> e = new BaseArray<Derived>(2);
      e.CopyArray<Derived>(d.Array);
    }

    public static T CreateInstance<T>() where T : new() // 기본 생성자가 있어야 함
    {
      return new T();
    }
  }
}