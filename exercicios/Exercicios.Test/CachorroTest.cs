using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Test
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void CachorroLatirTest()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();
            Assert.AreEqual("Au! Au!", latido);
            Console.WriteLine(latido);


        }

        /* 
         * Considerando quea Léia pesa 1KG,
         * e come 5% do seu peso em ração,
         * implemente m Método "QuantoDevoComer"
         * para passar neste teste
         */

        [TestMethod]
        public void LeiaQuantoDevoComerTest()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDeveComer(1);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }
        
        [TestMethod]
        public void TequilaQuantoDevoComerTest()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDeveComer(30);
            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoDevoComerTest()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDeveComer(15);
            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }
    }

}
 