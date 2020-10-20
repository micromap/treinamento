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

        // Considerando que a Leia pesa 1Kg
        // e come 5% do seu peso de ração,
        // Implemente o método "QuantoDevoComer"
        // para passar nesse teste

        [TestMethod]
        public void Leia_QuandoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string QuantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(QuantoDevoComer);

            Assert.AreEqual("Como tenho 1Kg, devo comer 50g por dia", QuantoDevoComer);
        }

        // Criar os métodos de teste, para a Tequila e para o Yuri

    }
}
