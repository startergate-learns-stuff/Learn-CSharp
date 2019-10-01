using System;

namespace DelegateTest02
{
  internal class Hero
  {
    public delegate void HeroMoveDelegate();

    private HeroMoveDelegate movements;

    public void AddMovement(HeroMoveDelegate movement)
    {
      movements += movement;
    }
    // public void AddMovements
    public void Move()
    {
      movements();
    }
  }
  
  internal class Program
  {
    static void moveRight()
    {
      Console.WriteLine("move right");
    }
    
    static void moveLeft()
    {
      Console.WriteLine("move left");
    }
    
    static void moveUp()
    {
      Console.WriteLine("move up");
    }
    
    static void moveDown()
    {
      Console.WriteLine("move down");
    }
    
    public static void Main(string[] args)
    {
      Hero h = new Hero();
      h.AddMovement(moveRight);
      h.AddMovement(moveUp);
      h.AddMovement(moveRight);
      h.AddMovement(moveDown);
      h.AddMovement(moveRight);
      
      h.Move();
    }
  }
}