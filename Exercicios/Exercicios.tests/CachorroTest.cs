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
        public void LeiaQuantoIreiPesarTest()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoIreiPesar(80);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 80Kg atualmente, daqui 10 anos irei pesar 72kg", quantoDevoComer);
        }

        [TestMethod]
        public void TequilaQuantoIreiPesarTest()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoIreiPesar(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg atualmente, daqui 10 anos irei pesar 27kg", quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoIreiPesarTest()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoIreiPesar(150);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 150Kg atualmente, daqui 10 anos irei pesar 135kg", quantoDevoComer);
        }

        //Considerando que a Léia tem 10 anos atualmente e
        // a cada 5 anos ela envelhece, qual sera sua idade?
        // implemente o Método "QualMinhaIdade"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQualMinhaIdadeTest()
        {
            Cachorro leia = new Cachorro();
            string qualMinhaIdade = leia.QualMinhaIdade(10);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 10 anos de idade, daqui 5 anos vou ter 15 anos", qualMinhaIdade);
        }

        [TestMethod]
        public void TequilaQualMinhaIdadeTest()
        {
            Cachorro tequila = new Cachorro();
            string qualMinhaIdade = tequila.QualMinhaIdade(8);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 8 anos de idade, daqui 5 anos vou ter 13 anos", qualMinhaIdade);
        }

        [TestMethod]
        public void YuriQualMinhaIdadeTest()
        {
            Cachorro yuri = new Cachorro();
            string qualMinhaIdade = yuri.QualMinhaIdade(5);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 5 anos de idade, daqui 5 anos vou ter 10 anos", qualMinhaIdade);
        }
    }
}
