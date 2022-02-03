using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer butthole = new SmackTalkingPlayer();
            butthole.Name = "Guy's a dick";
            butthole.Taunt = "You're face looks like a nut sack";

            large.Play(butthole);

            Console.WriteLine("-------------------");

            OneHigherPlayer oneHigherPlayer = new OneHigherPlayer();
            oneHigherPlayer.Name = "Oneupper McUpper";

            butthole.Play(oneHigherPlayer);

            Console.WriteLine("-------------------");

            HumanPlayer humanPlayer = new HumanPlayer();
            humanPlayer.Name = "Thomas Anderson";

            oneHigherPlayer.Play(humanPlayer);

            Console.WriteLine("-------------------");

            CreativeSmackTalkingPlayer creativeSmackTalkingPlayer = new CreativeSmackTalkingPlayer();
            creativeSmackTalkingPlayer.Name = "Shifty Eyes";

            humanPlayer.Play(creativeSmackTalkingPlayer);

            Console.WriteLine("-------------------");

            SoreLoserPlayer soreLoserPlayer = new SoreLoserPlayer();
            soreLoserPlayer.Name = "Donald";

            try
            {
              soreLoserPlayer.Play(creativeSmackTalkingPlayer);
            } catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------");

            UpperHalfPlayer upperHalfPlayer = new UpperHalfPlayer();
            upperHalfPlayer.Name = "High roller";

            try
            {
              upperHalfPlayer.Play(soreLoserPlayer);
            } catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                player1, player2, player3, large, butthole, oneHigherPlayer, humanPlayer, creativeSmackTalkingPlayer, soreLoserPlayer, upperHalfPlayer
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                try
                {
                  player1.Play(player2);
                } 
                catch (Exception ex)
                {
                  Console.WriteLine(ex.Message);
                }
            }
        }
    }
}