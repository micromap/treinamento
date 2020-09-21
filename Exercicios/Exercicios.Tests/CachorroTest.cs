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

            Assert.AreEqual("AU! AU!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            leia.peso = 1;
            string quantoDevoComer = leia.QuantoDevoComer(leia.peso);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como eu peso " + leia.peso + "KG, devo comer 50g de ração.", quantoDevoComer);

        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            tequila.peso = 30;
            string quantoDevoComer = tequila.QuantoDevoComer(tequila.peso);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como eu peso " + tequila.peso + "KG, devo comer 1500g de ração.", quantoDevoComer);

        }

        [TestMethod]
        public void Yury_QuantoDevoComer_Test()
        {
            Cachorro yury = new Cachorro();
            yury.peso = 15;
            string quantoDevoComer = yury.QuantoDevoComer(yury.peso);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como eu peso " + yury.peso + "KG, devo comer 750g de ração.", quantoDevoComer);

        }

    }
}
