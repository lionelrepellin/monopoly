using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing the Luxury Tax square on the gameboard
    /// </summary>
    public class LuxuryTax : Square
    {
        /// <summary>
        /// Tax value when Landing on the square
        /// </summary>
        private int Tax;

        /// <summary>
        /// Constructor, Setting the tax value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="tax"></param>
        public LuxuryTax(string name, Square next, int tax) : base(name, next)
        {
            this.Tax = tax;
        }

        /// <summary>
        /// Landing on the Square, update player amount
        /// </summary>
        /// <param name="player"></param>
        public override void Land(Player player, int dieResult)
        {
            base.Land(player, dieResult);
            player.Amount -= Tax;
        }
    }
}
