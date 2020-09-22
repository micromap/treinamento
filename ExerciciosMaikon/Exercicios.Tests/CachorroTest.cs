using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Leia_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        // Considerando que a Léia pesa 1Kg,
        // e come 5% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse Teste

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(2);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 2kg, devo comer 100g por dia", quantoDevoComer);
        }

    }
}
