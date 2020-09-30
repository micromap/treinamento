using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
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

            Assert.AreEqual("Au! Au!", latido);

        }

        // Considerando que a Leia pesa 1Kg,
        // e come 5% do seu peso de ração,
        // implemente o metodo "QuandoDevoComer",
        // para passar nesse teste 

        [TestMethod]
        public void leia_quantoDevoComer_test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuandoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }


        // Considerando que a Tequila pesa 30Kg,
        // e come 5% do seu peso de ração,
        // implemente o metodo "QuandoDevoComer",
        // para passar nesse teste 

        [TestMethod]
        public void tequila_quantoDevoComer_test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuandoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        // Considerando que a Yuri pesa 30Kg,
        // e come 5% do seu peso de ração,
        // implemente o metodo "QuandoDevoComer",
        // para passar nesse teste 

        [TestMethod]
        public void yuri_quantoDevoComer_test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuandoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Nome = "Yuri";
            string nomeCachorroYuri = yuri.Nome;

            Console.WriteLine(nomeCachorroYuri);

            Assert.AreEqual("Yuri", nomeCachorroYuri);



            Cachorro cachorro = new Cachorro("Ted", "Macho", "Shitsu", "Pequeno", 1, 3.0);

            string nomeCachorro  = cachorro.Nome;
            string sexoCachorro  = cachorro.Sexo;
            string racaCachorro  = cachorro.Raca;
            string porteCachorro = cachorro.Porte;
            int idadeCachorro = cachorro.Idade;
            double pesoCachorro = cachorro.Peso;

            Console.WriteLine(nomeCachorro);
            Console.WriteLine(sexoCachorro);
            Console.WriteLine(racaCachorro);
            Console.WriteLine(porteCachorro);
            Console.WriteLine(idadeCachorro);
            Console.WriteLine(pesoCachorro);

            Assert.AreEqual(cachorro.Nome, nomeCachorro);
            Assert.AreEqual(cachorro.Sexo, sexoCachorro);
            Assert.AreEqual(cachorro.Raca, racaCachorro);
            Assert.AreEqual(cachorro.Porte, porteCachorro);
            Assert.AreEqual(cachorro.Idade, idadeCachorro);
            Assert.AreEqual(cachorro.Peso, pesoCachorro);

        }

    }
}