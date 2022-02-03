using System;

namespace ShootingDice
{

    //* A Player who always rolls in the upper half of their possible roll and
    //* who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : SoreLoserPlayer
    {
      public override int Roll()
      {
        return new Random().Next((DiceSize / 2) + 1, DiceSize);
      }
    }
}