using System;
using System.Collections;
using System.Collections.Generic;

// Hashtable, Dictionary
// ( key, value ) 쌍 형태의 데이터 저장
namespace Collections04
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      #region System.Collections.Hashtable
      
      Hashtable ht = new Hashtable()
      {
        [1] = "하나",
        [2] = "둘",
        [3] = "셋"
      };
      ht.Add("Name", "아이유");
      ht["Age"] = 26;

      PrintHashtable(ht);

      if (ht.ContainsKey("Name")) ht["Name"] = "장만월";
      else ht.Add("Name", "장만월");
      
      if (ht.ContainsKey("넷")) Console.WriteLine("이미 값이 존재함");
      else ht.Add(4, "넷");
      
      PrintHashtable(ht);
      
      #endregion

      #region System.Collections.Generic.Dictionary

      Dictionary<int, string> dic = new Dictionary<int,string>()
      {
        [1] = "하나",
        [2] = "둘"
      };
      dic[3] = "셋";
      dic.Add(4, "넷");

      PrintDictionary(dic);

      #endregion
    }

    private static void PrintDictionary(Dictionary<int, string> dic)
    {
      foreach (var item in dic.Keys) Console.WriteLine(($"{item}: {dic[item]}"));
      Console.WriteLine('\n');
    }

    private static void PrintHashtable(Hashtable ht)
    {
      foreach (var item in ht.Keys) Console.WriteLine($"{ht[item]} ");
      Console.WriteLine('\n');
    }
  }
}