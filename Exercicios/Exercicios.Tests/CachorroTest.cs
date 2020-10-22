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
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1Kg, devo comer 50g por dia", quantoDevoComer);
        }

        // Criar os métodos de teste, para a Tequila e para o Yuri
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg, devo comer 1500g por dia", quantoDevoComer);

        }
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15Kg, devo comer 750g por dia", quantoDevoComer);

        }
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();
            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);

        }
        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            Cachorro yuri = new Cachorro();
            yuri.SetSexo("Macho");
            string sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Macho", sexo);

        }
        
    }
}

