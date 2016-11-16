using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing the Monopoly game
    /// </summary>
    public class Monopoly
    {
        /// <summary>
        /// A collection of players
        /// </summary>
        public List<Player> Players { get; set; }

        /// <summary>
        /// The board
        /// </summary>
        public Board Board { get; set; }

        /// <summary>
        /// Number of turns to play
        /// </summary>
        public int Turns { get; private set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        public Monopoly(int turns, List<Player> players, Board board)
        {
            this.Turns = turns;
            this.Players = players;
            this.Board = board;
        }        

        /// <summary>
        /// Let's start the game !
        /// </summary>
        /// <param name="die1"></param>
        /// <param name="die2"></param>
        public void Play(Die die1, Die die2)
        {
            // Let's begin, browse turns
            for (int i = 1; i <= this.Turns; i++)
            {
                // And each players play this turn
                Console.WriteLine("-------------------");
                Console.WriteLine("----- Turn " + i.ToString().PadLeft(2, '0') + " -----");
                Console.WriteLine("-------------------");
                foreach (var player in this.Players)
                {
                    player.TakeATurn(die1, die2);
                }
                Console.WriteLine();
            }
        }        
    }
}
