using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public abstract class representing the squares to purchase
    /// </summary>
    public abstract class PurchasableSquare : Square
    {
        /// <summary>
        /// Owner
        /// </summary>
        public Player Owner { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Price { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        public int Rent { get; protected set; }


        public Group Group { get; set; }


        /// <summary>
        /// Constructor, Setting the amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        /// <param name="bonus"></param>
        public PurchasableSquare(string name, Square next, int position, Group group)
            : base(name, next)
        {
            this.Position = position;
            this.Owner = null;

            // Link Square and group
            this.Group = group;
            this.Group.Squares.Add(this);
        }

        /// <summary>
        /// Landing on the Square, update player amount
        /// </summary>
        /// <param name="player"></param>
        public override void Land(Player player, int dieResult)
        {
            base.Land(player, dieResult);

            // Buy the property
            if (this.Owner == null)
            {
                if (player.Amount >= this.Price)
                {
                    this.Owner = player;
                    player.Amount -= this.Price;
                    Console.WriteLine(player.Pawn + " buys " + this.Name + " for $" + this.Price);
                }
                else
                {
                    // no owner on this square and no enought found
                    Console.WriteLine(player.Pawn + " can't buy " + this.Name + " and do nothing....");
                }
            }
            // Pay a rent to the owner
            else if (this.Owner != null && this.Owner != player)
            {
                this.Pay(player, dieResult);
            }
        }

        /// <summary>
        /// Player sleeps a night in Owner's property
        /// </summary>
        /// <param name="player"></param>
        protected virtual void Pay(Player player, int dieResult, int coef = 1)
        {
            player.Amount -= this.Rent * coef;
            this.Owner.Amount += this.Rent * coef;
            Console.WriteLine(player.Pawn + " pays $" + this.Rent * coef + " to " + this.Owner.Pawn);
        }
    }
}