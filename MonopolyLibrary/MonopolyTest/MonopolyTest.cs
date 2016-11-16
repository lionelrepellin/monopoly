using MonopolyLibrary.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MonopolyTest
{
    
    
    /// <summary>
    ///Classe de test pour MonopolyTest, destinée à contenir tous
    ///les tests unitaires MonopolyTest
    ///</summary>
    [TestClass()]
    public class MonopolyTest
    {
        Board Board;
        List<Player> Players;

        [TestInitialize]
        public void Setup()
        {
            this.Board = new Board();
            this.Players = new List<Player> {
                new Player("Lionel", Pawn.Horse, 1500, this.Board.Squares[0]),
                new Player("Benoit", Pawn.Car, 1500, this.Board.Squares[0])
            };
        }

        /// <summary>
        ///Test pour Constructeur Monopoly
        ///</summary>
        [TestMethod()]
        public void MonopolyConstructorTest()
        {
            // Declare Monopoly
            Monopoly target = new Monopoly(20, this.Players, this.Board);

            Assert.IsTrue(this.Board.Squares[0].Next.Name == "Lot number 1", "la case suivante n'est pas correcte");
            Assert.IsTrue(this.Board.Squares[this.Board.Squares.Count - 1].Next.Name == "GO", "la case suivant la dernière n'est pas la première");
            Assert.AreEqual(40, this.Board.Squares.Count, "Le plateau ne contient pas 40 cases");
        }
    }
}
