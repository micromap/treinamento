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
            var leia = new Cachorro();
            var latido = leia.Latir(6);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var leia = new Cachorro();

            leia.Peso = 1.2;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(1.2, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var leia = new Cachorro();

            leia.Peso = -1.2;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
            var leia = new Cachorro();

            leia.Peso = null;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Mes_Test()
        {
            // Idade igual a 1 mês
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Now;

            Console.WriteLine("Data Nascimento: " + cachorro.DataNascimento);
            Assert.AreEqual("1 mês", cachorro.GetIdade());
            Console.WriteLine(cachorro.GetIdade());

        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            // Idade maior que 1 mês
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2020, 05, 01);

            Console.WriteLine("Data Nascimento: " + cachorro.DataNascimento);
            Assert.AreEqual("6 meses", cachorro.GetIdade());
            Console.WriteLine(cachorro.GetIdade());

        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Ano_Test()
        {
            // Idade igual a 1 ano
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Now.AddYears(-1);

            Console.WriteLine("Data Nascimento: " + cachorro.DataNascimento);
            Assert.AreEqual("1 ano", cachorro.GetIdade());
            Console.WriteLine(cachorro.GetIdade());

        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Anos_Test()
        {
            // Idade maior que 2 anos
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2017, 07, 03);

            Console.WriteLine("Data Nascimento: " + cachorro.DataNascimento);
            Assert.AreEqual("3 anos", cachorro.GetIdade());
            Console.WriteLine(cachorro.GetIdade());

        }


    }
}