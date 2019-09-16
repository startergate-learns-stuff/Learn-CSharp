using System;

// 이것이 C#이다 310p
namespace Properties02
{
  class BirthdayInfo
  {
    private string name;
    private DateTime birthday;

    public string Name
    {
      get => name;
      set => name = value;
    }

    public DateTime Birthday
    {
      get => birthday;
      set => birthday = value;
    }

    public int Age => new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
  }
  
  internal class Program
  {
    public static void Main(string[] args)
    {
      BirthdayInfo birth = new BirthdayInfo();
      birth.Name = "서현";
      birth.Birthday = new DateTime(1993, 5, 16);

      Console.WriteLine($"Name: {birth.Name}");
      Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
      Console.WriteLine($"Age: {birth.Age}");
    }
  }
}