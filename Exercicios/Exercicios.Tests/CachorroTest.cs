using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {
            int peso = 10;

            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(peso);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho " + peso + "kg, devo comer 500g por dia", quantoDevoComer);
        }
    }
}
