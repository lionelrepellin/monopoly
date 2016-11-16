using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing a square on the gameboard
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Square title or name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Next square on the gameboard
        /// </summary>
        public Square Next { get; set; }

        /// <summary>
        /// Public constructir, Setting name and next square
        /// </summary>
        /// <param name="name"></param>
        /// <param name="next"></param>
        public Square(string name, Square next)
        {
            this.Name = name;
            this.Next = next;
        }

        /// <summary>
        /// Landing on a square
        /// </summary>
        /// <param name="player"></param>
        public virtual void Land(Player player, int dieResult)
        {
        }

        /// Passing by a square
        public virtual void PassBy(Player player)
        {
        }
    }
}
