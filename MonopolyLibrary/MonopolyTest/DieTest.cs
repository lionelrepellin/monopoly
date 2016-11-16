using MonopolyLibrary.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MonopolyTest
{
    
    
    /// <summary>
    ///Classe de test pour DieTest, destinée à contenir tous
    ///les tests unitaires DieTest
    ///</summary>
    [TestClass()]
    public class DieTest
    {
        /// <summary>
        ///Test pour Roll
        ///</summary>
        [TestMethod()]
        public void RollTest()
        {
            Die target = new Die();
            var value = target.Roll();

            Assert.IsTrue((value >= 1 && value < 7), String.Format("Erreur: les valeurs du DE sont incorrectes : {0}", value));
        }
    }
}
