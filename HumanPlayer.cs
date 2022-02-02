using System;
namespace ShootingDice
{

    //* A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
      public override int Roll()
      {
        Console.WriteLine("Enter a number for you roll! Aren't you lucky!");
        try
        {
          return Int32.Parse(Console.ReadLine());
        } catch (Exception)
        {
          Console.WriteLine("That's too bad...");
          return 0;
        }
      }
    }
}