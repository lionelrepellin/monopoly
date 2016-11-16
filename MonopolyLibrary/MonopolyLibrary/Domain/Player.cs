using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing a player and his position on the gameboard
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The chosen pawn
        /// </summary>
        public Pawn Pawn { get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Current position
        /// </summary>
        public Square CurrentSquare { get; set; }

        /// <summary>
        /// Current cash
        /// </summary>
        public int Amount { get; set; }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pawn"></param>
        public Player(string name, Pawn pawn, int cash, Square startSquare)
        {
            this.Name = name;
            this.Pawn = pawn;
            this.Amount = cash;
            this.CurrentSquare = startSquare;            
        }

        /// <summary>
        /// Player turn, rolls the dice and move the pawn on the board
        /// </summary>
        /// <param name="die1"></param>
        /// <param name="die2"></param>
        public void TakeATurn(Die die1, Die die2)
        {
            // Let's roll the dice
            var dieResult = die1.Roll() + die2.Roll();
            Console.WriteLine(this.Pawn + " rolls " + dieResult);

            // Pass by squares
            for (int i = 0; i < dieResult-1; i++)
            {
                this.CurrentSquare = this.CurrentSquare.Next;
                this.CurrentSquare.PassBy(this);
            }

            // Lands on a square
            this.CurrentSquare = this.CurrentSquare.Next;
            Console.WriteLine(this.Pawn + " lands on " + this.CurrentSquare.Name);
            this.CurrentSquare.Land(this, dieResult);            

            // Write amount player
            Console.WriteLine(this.Pawn + " has $" + this.Amount);

            // Replay if double
            if (die1.DieValue == die2.DieValue)
            {
                Console.WriteLine(this.Pawn + " has made a double, let's play again !");
                this.TakeATurn(die1, die2);
            }
        }
    }
}
