using System;
using System.Collections.Generic;
using System.Linq;
namespace ShootingDice
{
    //* A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
      public override string Taunt 
      {
        get{
          Random generator = new Random();
          return Taunts.OrderBy(t => generator.Next()).First();
        }
      }
      public List<string> Taunts = new List<string>(){
        "Your face looks like a ball sack",
        "My Handless grandma shoots better dice",
        "I hope you didn't plan on winning",
        "Don't worry I'll take good care of the winnings"
      };
    }
}