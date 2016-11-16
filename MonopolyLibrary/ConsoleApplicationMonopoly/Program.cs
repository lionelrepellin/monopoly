using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonopolyLibrary.Domain;

namespace ConsoleApplicationMonopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init Board (squares)
            var board = new Board();

            // Init Start Cash
            var startCash = 1500;

            // Declare players
            var players = new List<Player> {
                new Player("Lionel", Pawn.Horse, startCash, board.Squares[0]),
                new Player("Benoit", Pawn.Car, startCash, board.Squares[0]),
            };

            // Declare Dice
            var die1 = new Die();
            var die2 = new Die();

            // Init game
            var monopoly = new Monopoly(1000, players, board);

            /**
             * Now let's play !
             **/
            Console.WriteLine("Welcome to Monopoly !");
            Console.WriteLine();

            // Launch Game
            monopoly.Play(die1, die2);

            Console.Read();
        }
    }
}
