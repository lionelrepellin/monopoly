using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyLibrary.Domain
{
    /// <summary>
    /// A public class to represent the board of the game
    /// </summary>
    public class Board
    {
        /// <summary>
        /// A collection of squares on the gameboard
        /// </summary>
        public List<Square> Squares { get; set; }

        /// <summary>
        /// A collection of squares on the gameboard
        /// </summary>
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        public Board()
        {
            // Declare squares and groups
            Squares = new List<Square>();
            Groups = new List<Group>();

            var Brun = new Group("Brun");
            var BleuCiel = new Group("BleuCiel");
            var Violet = new Group("Violet");
            var Orange = new Group("Orange");
            var Rouge = new Group("Rouge");
            var Jaune = new Group("Jaune");
            var Vert = new Group("Vert");
            var BleuFonce = new Group("BleuFonce");
            var Utilities = new Group("Utilities");
            var Railroad = new Group("Railroad");
            Groups.Add(Brun);
            Groups.Add(BleuCiel);


            // Attribute specials squares and name
            for (int i = 0; i < 40; i++)
            {
                if (i == 0)
                    Squares.Add(new Go("GO", null, 200));
                else if (i == 4)
                    Squares.Add(new IncomeTax("Income Tax", null, 200, 10));
                else if (i == 5)
                    Squares.Add(new Railroad("Gare Montparnasse", null, 5, Railroad));
                else if (i == 12)
                    Squares.Add(new Utility("Compagnie d'Électricité", null, 12, Utilities));
                else if (i == 15)
                    Squares.Add(new Railroad("Gare de Lyon", null, 15, Railroad));
                else if (i == 25)
                    Squares.Add(new Railroad("Gare du Nord", null, 25, Railroad));
                else if (i == 28)
                    Squares.Add(new Utility("Compagnie des Eaux", null, 28, Utilities));
                else if (i == 35)
                    Squares.Add(new Railroad("Gare Saint Lazare", null, 35, Railroad));
                else if (i == 38)
                    Squares.Add(new LuxuryTax("Luxury Tax", null, 75));
                else if (i == 1 || i == 3)
                    Squares.Add(new Property("Lot number " + i, null, i, Brun));
                else if (i == 6 || i == 8 || i == 9)
                    Squares.Add(new Property("Lot number " + i, null, i, BleuCiel));
                else if (i == 11 || i == 13 || i == 14)
                    Squares.Add(new Property("Lot number " + i, null, i, Violet));
                else if (i == 16 || i == 18 || i == 19)
                    Squares.Add(new Property("Lot number " + i, null, i, Orange));
                else if (i == 21 || i == 23 || i == 24)
                    Squares.Add(new Property("Lot number " + i, null, i, Rouge));
                else if (i == 26 || i == 27 || i == 29)
                    Squares.Add(new Property("Lot number " + i, null, i, Jaune));
                else if (i == 31 || i == 32 || i == 34)
                    Squares.Add(new Property("Lot number " + i, null, i, Vert));
                else if (i == 37 || i == 39)
                    Squares.Add(new Property("Lot number " + i, null, i, BleuFonce));
                else
                    Squares.Add(new Square("Lot number " + i, null));
            }

            // Let's link the square
            for (int i = 0; i < Squares.Count; i++)
            {
                // Last element case
                if (i + 1 == Squares.Count)
                {
                    Squares[i].Next = Squares[0];
                }
                // Normal case
                else
                {
                    Squares[i].Next = Squares[i + 1];
                }
            }
        }
    }
}
