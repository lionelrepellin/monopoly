using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class representing a die
    /// </summary>
    public class Die
    {
        private static Random random = new Random();

        /// <summary>
        /// Face value of the die
        /// </summary>
        public int DieValue { get; set; }

        /// <summary>
        /// Public constructor, roll the die
        /// </summary>
        public Die()
        {
            this.Roll();
        }
        
        /// <summary>
        /// Let's roll a die
        /// </summary>
        public virtual int Roll()
        {
            this.DieValue = random.Next(1, 7);

            return this.DieValue;
        }
    }
}
