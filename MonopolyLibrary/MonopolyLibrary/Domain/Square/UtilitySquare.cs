using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    public class Utility : PurchasableSquare
    {
        /// <summary>
        /// Constructor, Setting the amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="bonus"></param>
        public Utility(string name, Square next, int position, Group group)
            : base(name, next, position, group)
        {
            this.Price = 150;
            this.Rent = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player">the property client</param>
        protected override void Pay(Player player, int dieResult, int coef = 1)
        {
            // Number of utilities player owns
            var CompanyCount = this.Group.Squares.Count(s => s.Owner == this.Owner);

            var power = (CompanyCount == 2) ? dieResult * 100 : dieResult * 40;

            base.Pay(player, dieResult, power);
        }
    }
}