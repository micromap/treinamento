using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void CachorroLatirTest()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        //Considerando que a Léia pesa 1Kg,
        // e come 10% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQuantoDevoComerTest()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(80);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 80Kg, devo comer 8kg por dia", quantoDevoComer);
        }

        [TestMethod]
        public void TequilaQuantoDevoComerTest()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg, devo comer 3kg por dia", quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoDevoComerTest()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(150);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 150Kg, devo comer 15kg por dia", quantoDevoComer);
        }

        //Considerando que a Léia pesa 80kg atualmente e
        // ela perde 10% do seu peso a cada 10 anos
        // implemente o Método "QuantoIreiPesar"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQuantoIreiPesar()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoIreiPesar(80);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 80Kg atualmente, daqui 10 anos irei pesar 72kg", quantoDevoComer);
        }

        [TestMethod]
        public void TequilaQuantoIreiPesar()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoIreiPesar(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg atualmente, daqui 10 anos irei pesar 27kg", quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoIreiPesar()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoIreiPesar(150);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 150Kg atualmente, daqui 10 anos irei pesar 135kg", quantoDevoComer);
        }
    }
}
