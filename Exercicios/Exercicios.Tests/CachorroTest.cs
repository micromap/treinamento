using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;
using System.Reflection.PortableExecutable;

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

        /*
         Considerando que a Léia pese 1Kg e come 5% do seu peso em ração,
         Implemente o metodo "Quanto devo comer" para passar nesse Teste.
         */

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            double percentual = 0.05;
            int peso = 1;
            Cachorro leia = new Cachorro();
            String quantoDevoComer = leia.QuantoDevoComer(peso, percentual);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 50g por dia", quantoDevoComer);

        }
        
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
           double percentual = 0.05;
            int peso = 30;           
            Cachorro tequila = new Cachorro();
            String quantoDevoComer= tequila.QuantoDevoComer(peso, percentual);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            double percentual = 0.05;
            int peso = 15;           
            Cachorro yuri = new Cachorro();
            String quantoDevoComer = yuri.QuantoDevoComer(peso, percentual);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 750g por dia", quantoDevoComer);
        }
    }
}
