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

        // Considerando que a Léia pesa 1Kg,
        // e come 5% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse Teste

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Test()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.SetNome("Leia");
            cachorro.SetSexo("Fêmea");
            cachorro.SetRaca("Yorkshire");
            cachorro.SetPorte("Pequena");
            cachorro.SetIdade(1);
            cachorro.SetPesoKg(1.0);

            string nome = cachorro.GetNome();
            string sexo = cachorro.GetSexo();
            string raca = cachorro.GetRaca();
            string porte = cachorro.GetPorte();
            int idade = cachorro.GetIdade();
            double pesoKg = cachorro.GetPesoKg();


        }

    }
}
