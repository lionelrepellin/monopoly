using MonopolyLibrary.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MonopolyTest.Domain;
using System.Linq;

namespace MonopolyTest
{
    
    
    /// <summary>
    ///Classe de test pour PropertyTest, destinée à contenir tous
    ///les tests unitaires PropertyTest
    ///</summary>
    [TestClass()]
    public class PropertyTest
    {
        Board Board;
        List<Player> Players;

        [TestInitialize]
        public void Setup()
        {
            this.Board = new Board();
            this.Players = new List<Player> {
                new Player("Lionel", Pawn.Horse, 1500, this.Board.Squares[0]),
                new Player("Benoit", Pawn.Car, 1500, this.Board.Squares[0]),
                new Player("Jeff", Pawn.Wheelbarrow, 1500, this.Board.Squares[0])
            };
        }


        /// <summary>
        ///Test pour Pay
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MonopolyLibrary.dll")]
        public void PayTest()
        {
            // le premier joueur achete la case 1
            this.Players[0].TakeATurn(new PipedDie(0), new PipedDie(1));
            // le premier joueur achete la case 3
            this.Players[0].TakeATurn(new PipedDie(0), new PipedDie(2));

            // TODO checker le owner avec la méthode du group
            var target = this.Board.Groups.First().Squares.Count(s => s.Owner == this.Players[0]);
            Assert.AreEqual(2, target, "Le joueur ne possède pas toutes les cases du même groupe");

            // le deuxième joueur arrive sur la case 1
            this.Players[1].TakeATurn(new PipedDie(0), new PipedDie(1));

            // la 1 case est 
            Assert.AreEqual(1498, this.Players[1].Amount, "Le montant du loyer n'a pas été doublé");

            // le troisème joueur arrive sur la case 1
            this.Players[2].TakeATurn(new PipedDie(0), new PipedDie(1));

            // la 1 case est 
            Assert.AreEqual(1498, this.Players[2].Amount, "Le montant du loyer n'a pas été doublé");
        }
    }
}
