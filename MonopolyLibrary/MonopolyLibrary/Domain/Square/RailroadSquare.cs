using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    public class Railroad : PurchasableSquare
    {
        /// <summary>
        /// Constructor, Setting the amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="bonus"></param>
        public Railroad(string name, Square next, int position, Group group) : base(name, next, position, group)
        {
            this.Price = 200;
            this.Rent = 25;
        }

        /// <summary>
        /// Rent is set by the number of railroad : Rent = 25 * RailroadCount
        /// </summary>
        /// <param name="player">the property client</param>
        protected override void Pay(Player player, int dieResult, int coef = 1)
        {
            // Number of railroads player owns
            var RailroadCount = this.Group.Squares.Count(s => s.Owner == this.Owner);

            var power = Convert.ToInt32(Math.Pow(2, RailroadCount - 1));

            base.Pay(player, dieResult, power);
        }
    }
}
