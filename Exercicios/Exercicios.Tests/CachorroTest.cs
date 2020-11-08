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
            
            var leia = new Cachorro();
            var latido = leia.Latir(5);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var peso = 1;
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 50g por dia", quantoDevoComer);

        }
        
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
           
            var peso = 30;           
            var tequila = new Cachorro();
            var quantoDevoComer= tequila.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var peso = 15;           
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var peso_cao = 1.2;
            var leia = new Cachorro();

            leia.Peso=(peso_cao);
            var peso = leia.Peso;
            Console.WriteLine(peso);
            Assert.AreEqual(1.2,peso_cao);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var peso_cao = -1.2;
            var leia = new Cachorro();

            leia.Peso = (peso_cao);
            var peso = leia.Peso;
            Console.WriteLine(peso);
            Assert.AreEqual(-1.2, peso_cao);
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
        public void Dt_Nascimento_Ano_Test()
        {
            var dtnascimento = new Cachorro();

            dtnascimento.Nascimento = new DateTime(2016, 03, 16);
            var idade = dtnascimento.GetIdade();
           Assert.AreEqual("4 anos", idade);
            Console.WriteLine(idade);
        }


        [TestMethod]
        public void Dt_Nascimento_Um_Ano_Test()
        {
            var dtnascimento = new Cachorro();

            dtnascimento.Nascimento = new DateTime(2019, 03, 16);
            var idade = dtnascimento.GetIdade();
            Assert.AreEqual("1 ano", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Dt_Nascimento_Meses_Test()
        {
            var dtnascimento = new Cachorro();

            dtnascimento.Nascimento = new DateTime(2020, 08, 10);
            var idade = dtnascimento.GetIdade();
            Assert.AreEqual("3 meses", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Dt_Nascimento_Mes_Test()
        {
            var dtnascimento = new Cachorro();

            dtnascimento.Nascimento = new DateTime(2020,10, 8);
            var idade = dtnascimento.GetIdade();
            Assert.AreEqual("1 mês", idade);
            Console.WriteLine(idade);
        }






    }


}
