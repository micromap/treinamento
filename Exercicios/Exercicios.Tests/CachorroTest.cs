﻿using Exercicios.Domain;
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
            var leia = new Cachorro { Peso = 1 };
            var quantoDevoComer = leia.QuantoDevoComer();

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro { Peso = 30 };
            var quantoDevoComer = tequila.QuantoDevoComer();

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro { Peso = 15 };
            var quantoDevoComer = yuri.QuantoDevoComer();

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

        [TestMethod]
        public void Cachorro_Validar_Test()
        {
            try
            {
                var cachorro = new Cachorro
                {
                    Nome = "",
                    Sexo = Sexo.Macho,
                    DataNascimento = DateTime.Today.AddMonths(5),
                    Peso = 0
                };

                cachorro.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do Pet é Obrigatório!") &&
                         ex.Message.Contains("Data de Nascimento do Cachorro deve ser menor que Hoje!") &&
                         ex.Message.Contains("Peso do Cachorro deve ser maior que zero!");

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
            var silvia = new Dono
            {
                Nome = "Silvia",
                Email = "silvia@teste.com",
                Telefone = "1111111"
            };

            var leia = new Cachorro
            {
                Nome = "Léia",
                Dono = silvia
            };

            Console.WriteLine(leia.Dono.Nome);
            Assert.AreEqual("Silvia", leia.Dono.Nome);
        }

        [TestMethod]
        public void Cachorro_Enum_Sexo_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Sexo = Sexo.Femea
            };

            Console.WriteLine(cachorro.Sexo);
            Assert.AreEqual(Sexo.Femea, cachorro.Sexo);
        }

        [TestMethod]
        public void Cachorro_Enum_Raca_Porte_Test()
        {
            var york = new Raca
            {
                Nome = "Yorkshire",
                Porte = Porte.Pequeno
            };

            var leia = new Cachorro
            {
                Nome = "Léia",
                Raca = york
            };

            Assert.AreEqual(Porte.Pequeno, leia.Raca.Porte);
            Console.WriteLine(leia.Raca.Porte);
        }

        [TestMethod]
        public void Cachorro_IPet_Test()
        {
            IPet pet = new Cachorro { Nome = "Léia", Peso = 2 };

            Assert.AreEqual("Léia", pet.Nome);
            Console.WriteLine(pet.Nome);

            var leia = pet as Cachorro;

            Assert.AreEqual(2, leia.Peso);
            Console.WriteLine(leia.Peso);
        }
    }
}