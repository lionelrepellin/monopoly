using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    public class Group
    {
        public string Name { get; private set; }

        public List<PurchasableSquare> Squares { get; set; }

        public Group(string name)
        {
            this.Name = name;
            this.Squares = new List<PurchasableSquare>();
        }

        public bool IsFullOwner(Player player)
        {
            return this.Squares.Count == this.Squares.Count(s => s.Owner == player);
        }
    }
}
