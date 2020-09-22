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

            Assert.AreEqual("Au! Au!", latido);
        }

        /// Leia pesa 1Kg
        /// e come 5% do seu peso em ração
        /// implemente o Método "QuantoDevoComer"
        /// para passar nesse teste

        [TestMethod]
        public void Cachorro_Quanto_Devo_Comer_Test()
        {
            Cachorro animal = new Cachorro();
            string quantoDevoComer = animal.QuantoDevoComer(15, "Yuri");

            Console.WriteLine(quantoDevoComer);

            if (quantoDevoComer.Substring(0, 4) == "Leia")
            {
                Assert.AreEqual("Leia pesando 1Kg deve comer 50g diariamente.", quantoDevoComer);
            }
            else if (quantoDevoComer.Substring(0, 7) == "Tequila")
            {
                Assert.AreEqual("Tequila pesando 30Kg deve comer 1500g diariamente.", quantoDevoComer);
            }
            else
            {
                Assert.AreEqual("Yuri pesando 15Kg deve comer 750g diariamente.", quantoDevoComer);
            }
        }
    }
}
