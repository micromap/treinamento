using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Assert.AreEqual("Au Au!", latido);

        }

        [TestMethod]
        public void Leia_QuandoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine();
            Assert.AreEqual("Como tenho 1kg, devo comer 50g", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuandoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine();
            Assert.AreEqual("Como tenho 1kg, devo comer 50g", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuandoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine();
            Assert.AreEqual("Como tenho 1kg, devo comer 50g", quantoDevoComer);
        }
    }
}
