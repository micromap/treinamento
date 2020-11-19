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
            var latido = leia.Latir(3);

            Console.WriteLine(latido);
            Assert.AreEqual("Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Peso_Test()
        {
            var yuri = new Cachorro();

            yuri.Peso = 7;
            var pesoKg = yuri.Peso;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(7, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var yuri = new Cachorro();

            yuri.Peso = -1.2;
            var pesoKg = yuri.Peso;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Test()
        {
            var yuri = new Cachorro();

            yuri.Peso = null;
            var pesoKg = yuri.Peso;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Anos_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2016, 1, 10);
            var idade = cachorro.GetIdade();

            Assert.AreEqual("4 anos", idade);
            Console.WriteLine(idade);           
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Ano_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2019, 1, 10);
            var idade = cachorro.GetIdade();

            Assert.AreEqual("1 ano", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2020, 7, 10);
            var idade = cachorro.GetIdade();

            Assert.AreEqual("4 meses", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Mes_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = new DateTime(2020, 10, 10);
            var idade = cachorro.GetIdade();

            Assert.AreEqual("1 mês", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_Validar_Test()
        {
            try
            {
                var cachorro = new Cachorro();
                cachorro.Nome = "";
                cachorro.Sexo = "Xyz";
                cachorro.DataNascimento = DateTime.Today.AddMonths(5);
                cachorro.Peso = 0;

                cachorro.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do Cachorro é Obrigatório!") &&
                         ex.Message.Contains("Sexo do cachorro deve ser Fêmea ou Macho!") &&
                         ex.Message.Contains("Data de nascimento deve ser menor que hoje!") &&
                         ex.Message.Contains("Peso deve ser maior que zero!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Cachorro_Associacao_Raca_Test()
        {
            var labrador = new Raca { Nome = "Labrador" };

            var tequila = new Cachorro
            {
                  Nome = "Tequila",
                  Raca = labrador
            };

            Console.WriteLine(tequila.Raca.Nome);
            Assert.AreEqual("Labrador", tequila.Raca.Nome);
        }

        [TestMethod]
        public void Cachorro_Associacao_Dono_Test()
        {
            var tamara = new Dono
            {
                Nome = "Tamara",
                Telefone = "14997583486",
                Email = "tamara@gemmap.com.br"
            };

            var leia = new Cachorro
            {
                Nome = "Léia",
                Dono = tamara
            };

            Console.WriteLine(leia.Dono.Nome);
            Assert.AreEqual("Tamara", leia.Dono.Nome);
        }
    }
}
