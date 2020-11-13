
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

            Assert.AreEqual("au au au au!", latido);

        } 


        [TestMethod]
        public void Leia_QtoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            leia.Peso = 1;
            string QuantoDevoComer = leia.QuantoDevoComer(leia.Peso);
            Console.WriteLine(QuantoDevoComer);
            //usando interpolação de string
            Assert.AreEqual($"Como tenho {leia.Peso}Kg, devo comer {leia.Peso * 0.05}g por dia", QuantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QtoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            tequila.Peso = 30;
            string QuantoDevoComer = tequila.QuantoDevoComer(tequila.Peso);
            Console.WriteLine(QuantoDevoComer);
            Assert.AreEqual("Como tenho " + tequila.Peso + "Kg, devo comer " + (tequila.Peso * 0.05) + "g por dia", QuantoDevoComer);
        }
       
        
        [TestMethod]
        public void Yury_QtoDevoComer_Test()
        {
            Cachorro yury = new Cachorro();
            yury.Peso = 15;
            string QuantoDevoComer = yury.QuantoDevoComer(yury.Peso);
            Console.WriteLine(QuantoDevoComer);
            Assert.AreEqual("Como tenho "+yury.Peso+"Kg, devo comer "+(yury.Peso*0.05)+"g por dia",QuantoDevoComer);
        }
    }
}
