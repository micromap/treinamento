using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_test()
        {
            var leia = new Cachorro();
            var latido = leia.latir(6);

            Console.WriteLine(latido);
            
            Assert.AreEqual("Au! Au! Au! Au! Au! Au!", latido);
               
        }

         [TestMethod]       
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1 Kg, devo comer 50 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30 Kg, devo comer 1500 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15 Kg, devo comer 750 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Peso_Teste()
        {
            var yuri = new Cachorro();

            yuri.Peso = 15.01;
            var peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(15.01, peso);
        }

        [TestMethod]
        public void Cachorro_Pode_Aceitar_Nulo_Peso_Teste()
        {
            var yuri = new Cachorro();

            yuri.Peso = null;
            var peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var yuri = new Cachorro();

            yuri.Peso = -15.01;
            var peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Anos_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Today.AddYears(-4);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("4 anos", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Ano_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Today.AddYears(-1);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("1 ano", idade);
            Console.WriteLine(idade);
        }
        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Today.AddMonths(-11);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("11 meses", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Mes_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Today.AddMonths(-1);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("1 mês", idade);
            Console.WriteLine(idade);
        }
    }
}
