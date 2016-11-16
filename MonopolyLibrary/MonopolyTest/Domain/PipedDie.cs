using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonopolyLibrary.Domain;

namespace MonopolyTest.Domain
{
    /// <summary>
    /// A public class representing a die
    /// </summary>
    public class PipedDie : Die
    {
        /// <summary>
        /// Face value of the die
        /// </summary>
        public int PipedValue { get; set; }

        /// <summary>
        /// Public constructor, roll the die
        /// </summary>
        public PipedDie(int pipedValue)
        {
            this.PipedValue = pipedValue;
            this.Roll();
        }

        /// <summary>
        /// Let's roll a die
        /// </summary>
        public override int Roll()
        {
            this.DieValue = this.PipedValue;

            return this.DieValue;
        }
    }
}
