using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    public class Property : PurchasableSquare
    {
        public Property(string name, Square next, int position, Group group)
            : base(name, next, position, group)
        {
            this.Price = 40 + position * 10;
            this.Rent = position;
        }

        /// <summary>
        /// Rent is set by the number of railroad : Rent = 25 * RailroadCount
        /// </summary>
        /// <param name="player">the property client</param>
        protected override void Pay(Player player, int dieResult, int coef = 1)
        {
            // Number of railroads player owns
            var fullOwner = this.Group.IsFullOwner(this.Owner);

            // If more than one, pay double rent
            if (fullOwner)
                base.Pay(player, dieResult, 2);

            base.Pay(player, dieResult);            
        }
    }
}
