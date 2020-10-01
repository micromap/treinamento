using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios.domain;
using System;

namespace Exercicios.tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_latir_test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("AU! AU!", latido);
        }

        /*
        Considerando que e Léia pesa 20kg,
        Considerando que e Léia pesa 30kg,
        e come 5% do seu peso de ração,
        implemente o método "QuandoDevoComer"
        para passar nesse teste
        */
        
        [TestMethod]
        public void Leia_QuantoDevoComer_test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);

        }


        /* criar metodos para os cachorros Tequila e Yuri */
        [TestMethod]
        public void Tequila_QuantoDevoComer_test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);

        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);

        }

    }
}
