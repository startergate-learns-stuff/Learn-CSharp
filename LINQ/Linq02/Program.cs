using System;
using System.Linq;

namespace Linq02
{
  internal class Profile
  {
    public string Name { get; set; }
    public int Height { get; set; }
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 1. 데이터 소스 (Profile 객체 배열)
      Profile[] arrProfiles =
      {
        new Profile() {Name = "정우성", Height = 186},
        new Profile() {Name = "감태희", Height = 158},
        new Profile() {Name = "고현정", Height = 172},
        new Profile() {Name = "이문세", Height = 178},
        new Profile() {Name = "하동훈", Height = 171} 
      };

      #region 단순 추출

      // 2. 쿼리 만들기 (키 순서대로 오름차순 정렬된 이름만 추출
      var profileList1 = from profile in arrProfiles orderby profile.Height select profile.Name;

      foreach (var item in profileList1) Console.WriteLine($"Name: {item}");

      Console.WriteLine();

      #endregion

      #region 키 175 미만 데이터만 오름차순 정렬하여 추출

      var profileList2 = from profile in arrProfiles where profile.Height < 175 select profile;
      
      foreach (var item in profileList2) Console.WriteLine($"Name: {item.Name}, Height: {item.Height}");

      Console.WriteLine();

      #endregion
      
      #region 무명 객체 수행

      var profileList3 = from profile in arrProfiles where profile.Height < 175 select new { Name = profile.Name, centiHeight = profile.Height, inchHeight = profile.Height * 0.393};
      
      foreach (var item in profileList3) Console.WriteLine($"Name: {item.Name}, centiHeight: {item.centiHeight}, inchHeight: {item.inchHeight}");

      Console.WriteLine();

      #endregion
    }
  }
}