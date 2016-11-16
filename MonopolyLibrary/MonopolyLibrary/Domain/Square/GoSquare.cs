using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing the GO square on the gameboard
    /// </summary>
    public class Go : Square
    {
        /// <summary>
        /// Amount money earned when Landing or Passing by
        /// </summary>
        private int Bonus;

        /// <summary>
        /// Constructor, Setting the amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="bonus"></param>
        public Go(string name, Square next, int bonus) : base(name, next)
        {
            this.Bonus = bonus;
        }

        /// <summary>
        /// Landing on Start Square
        /// </summary>
        /// <param name="player"></param>
        public override void Land(Player player, int dieResult)
        {
            base.Land(player, dieResult);
            player.Amount += Bonus;
            Console.WriteLine(player.Pawn + " collects $" + Bonus);
        }

        /// <summary>
        /// Passing by Start Square
        /// </summary>
        /// <param name="player"></param>
        public override void PassBy(Player player)
        {
            base.PassBy(player);
            player.Amount += Bonus;
            Console.WriteLine(player.Pawn + " passes Go and collects $" + Bonus);
        }
    }
}
