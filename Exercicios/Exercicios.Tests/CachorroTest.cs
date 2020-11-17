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
            string latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au!", latido);
        }

        /// Leia pesa 1Kg
        /// e come 5% do seu peso em ração
        /// implemente o Método "QuantoDevoComer"
        /// para passar nesse teste

        [TestMethod]
        public void Cachorro_Quanto_Devo_Comer_Test()
        {
            Cachorro animal1 = new Cachorro();
            string quantoDevoComer1 = animal1.QuantoDevoComer(1, "Leia");

            Console.WriteLine(quantoDevoComer1);
            Assert.AreEqual("Leia pesando 1Kg deve comer 50g diariamente.", quantoDevoComer1);



            Cachorro animal2 = new Cachorro();
            string quantoDevoComer2 = animal2.QuantoDevoComer(30, "Tequila");

            Console.WriteLine(quantoDevoComer2);
            Assert.AreEqual("Tequila pesando 30Kg deve comer 1500g diariamente.", quantoDevoComer2);



            Cachorro animal3 = new Cachorro();
            string quantoDevoComer3 = animal3.QuantoDevoComer(15, "Yuri");

            Console.WriteLine(quantoDevoComer3);
            Assert.AreEqual("Yuri pesando 15Kg deve comer 750g diariamente.", quantoDevoComer3);

        }

        [TestMethod]
        public void Cachorro_Peso_Get_Set_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Peso = 10;
            double? peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(10, peso);
        }
    }
}
