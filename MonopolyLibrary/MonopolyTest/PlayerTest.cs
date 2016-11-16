using MonopolyLibrary.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MonopolyTest.Domain;

namespace MonopolyTest
{
    
    
    /// <summary>
    ///Classe de test pour PlayerTest, destinée à contenir tous
    ///les tests unitaires PlayerTest
    ///</summary>
    [TestClass()]
    public class PlayerTest
    {
        Board Board;

        [TestInitialize]
        public void Setup()
        {
            this.Board = new Board();
        }

        /// <summary>
        ///Test pour Move
        ///</summary>
        [TestMethod()]
        public void MoveTest()
        {
            Player target = new Player("Jeff", Pawn.Wheelbarrow, 1500, this.Board.Squares[0]);

            // Player Play
            target.TakeATurn(new PipedDie(6), new PipedDie(4));

            Assert.AreEqual("Lot number 10", target.CurrentSquare.Name);
        }
    }
}
