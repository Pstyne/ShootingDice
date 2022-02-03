using System;

namespace ShootingDice
{

    //* A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
      public override int Roll()
      {
        return new Random().Next((DiceSize / 2) + 1, DiceSize);
      }
    }
}