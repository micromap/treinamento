
using System;
using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1Kg,devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30Kg,devo comer 1500g por dia", quantoDevoComer);
        }
        
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro Yuri = new Cachorro();
            string quantoDevoComer = Yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15Kg,devo comer 750g por dia", quantoDevoComer);
        }
    }


      
        
}
