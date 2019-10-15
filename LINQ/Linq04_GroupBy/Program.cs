using System;
using System.Linq;

// group by into 로 데이터 분류하기 (494p 예제)
namespace Linq04_GroupBy
{
  internal class Profile
  {
    public string Name { get; set; }
    public int Height { get; set; }
    public string Gender { get; set; }
    
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      // 1. 데이터 소스 (Profile 객체 배열)
      Profile[] arrProfiles =
      {
        new Profile() {Name = "정우성", Height = 186, Gender = "남성"},
        new Profile() {Name = "감태희", Height = 158, Gender = "여성"},
        new Profile() {Name = "고현정", Height = 172, Gender = "여성"},
        new Profile() {Name = "이문세", Height = 178, Gender = "남성"},
        new Profile() {Name = "하동훈", Height = 171, Gender = "남성"} 
      };

      #region 성별로 분류
      // 2. 쿼리 만들기
      var profileList1 = from profile in arrProfiles group profile by profile.Gender;

      foreach (var Group in profileList1)
      {
        Console.WriteLine($"그룹 이름: {Group.Key}");
        foreach (var item in Group)
        {
          Console.WriteLine($"{item.Name}, {item.Height}, {item.Gender}");
        }
      }
      // 3. 쿼리 실행
      #endregion
      
      #region 키로 분류
      // 2. 쿼리 만들기 (키 175 이상과 미만으로 그룹 분류)
      // group A by B into C => A를 B에 따라 분류하여 C에 저장
      var profileList2 = from profile in arrProfiles group profile by profile.Height < 175 into g where g.Count() >= 3 select g;

      // 3. 쿼리 실행
      foreach (var Group in profileList2)
      {
        Console.WriteLine($"그룹 이름: {Group.Key}");
        foreach (var item in Group)
        {
          Console.WriteLine($"{item.Name}, {item.Height}, {item.Gender}");
        }
      }
      #endregion

      #region 키로 분류
      // 2. 쿼리 만들기 (키 175 이상과 미만으로 그룹 분류)
      // group A by B into C => A를 B에 따라 분류하여 C에 저장
      var profileList4 = from profile in arrProfiles
                         group new {Name = profile.Name,
                             centiHeight = profile.Height,
                             inchHeight = profile.Height * 0.393} by profile.Height < 175;

      // 3. 쿼리 실행
      foreach (var Group in profileList4)
      {
        Console.WriteLine($"175 미만인가요? {Group.Key}");
        foreach (var item in Group)
          Console.WriteLine($"{item.Name}, {item.centiHeight}, {item.inchHeight}");

        Console.WriteLine();
      }
      #endregion

    }
  }
}