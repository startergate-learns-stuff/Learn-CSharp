using System;
using System.Linq;

// group by into 로 데이터 분류하기 (494p 예제)
namespace Linq04_GroupBy
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
      
      #region 키로 분류
      // 2. 쿼리 만들기 (키 175 이상과 미만으로 그룹 분류)
      // group A by B into C => A를 B에 따라 분류하여 C에 저장
      var profileList1 = from profile in arrProfiles group profile by profile.Height < 175 into g select new { GroupKey = g.Key, Profiles = g };

      // 3. 쿼리 실행
      foreach (var Group in profileList1)
      {
        Console.WriteLine($"Name: {Group.GroupKey}");
      }
      #endregion

      #region 이름으로 분류


      #endregion

      #region 그룹 조건 사용


      #endregion

    }
  }
}