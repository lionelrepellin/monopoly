using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing the GO square on the gameboard
    /// </summary>
    public class IncomeTax : Square
    {
        /// <summary>
        /// Tax value when Landing on the square
        /// </summary>
        private int Tax;

        /// <summary>
        /// Percent of player amount when Landing on the square
        /// </summary>
        private int Percent;

        /// <summary>
        /// Constructor, Setting the tax and percent
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="tax"></param>
        /// <param name="percent"></param>
        public IncomeTax(string name, Square next, int tax, int percent) : base(name, next)
        {
            this.Tax = tax;
            this.Percent = percent;
        }

        /// <summary>
        /// Landing on the Square, update player amount
        /// </summary>
        /// <param name="player"></param>
        public override void Land(Player player, int dieResult)
        {
            base.Land(player, dieResult);

            var shouldPay = player.Amount * Percent / 100;
            if (shouldPay > Tax)
                player.Amount -= shouldPay;
            else
                player.Amount -= Tax;
        }
    }
}
