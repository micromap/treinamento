
using System;
using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1Kg,devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30Kg,devo comer 1500g por dia", quantoDevoComer);
        }
        
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro Yuri = new Cachorro();
            string quantoDevoComer = Yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15Kg,devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetNome("Yuri");
            string nome = Yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetSexo("Masculino");
            string sexo = Yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Masculino", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetRaca("Vira Lata");
            string raca = Yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Vira Lata", raca);
        }
        
        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetPorte("Médio");
            string porte = Yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetIdade(3);
            int idade = Yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(3, idade);
        }
        
        [TestMethod]
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            Cachorro Yuri = new Cachorro();

            Yuri.SetPesoKg(5.5);
            double pesoKg = Yuri.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(5.5, pesoKg);
        }
    }
}
