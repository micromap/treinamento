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
            var leia = new Cachorro { Peso = 1 };
            var quantoDevoComer = leia.QuantoDevoComer();
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1Kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {             
            var tequila = new Cachorro { Peso = 30};
            var quantoDevoComer = tequila.QuantoDevoComer();
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30Kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro { Peso = 15};
            var quantoDevoComer = yuri.QuantoDevoComer();
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15Kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var peso_cao = 1.2;
            var leia = new Cachorro();

            leia.Peso = (peso_cao);
            var peso = leia.Peso;
            Console.WriteLine(peso);
            Assert.AreEqual(1.2, peso_cao);
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

            dtnascimento.Nascimento = new DateTime(2020, 10, 8);
            var idade = dtnascimento.GetIdade();
            Console.WriteLine(idade);

            Assert.AreEqual("1 mês", idade);
            Console.WriteLine(idade);

        }

        [TestMethod]
        public void Cachorro_Validar_Test()
        {
            try
            {
                var nome_cao = " ";
                var sexo = Sexo.Macho;
                var dtnasc = DateTime.Today.AddMonths(4);
                var peso = 0;

                var cachorro = new Cachorro()
                {
                    Nome = nome_cao,
                    Sexo = sexo,
                    Nascimento = dtnasc,
                    Peso = peso,
                };

                cachorro.Validar();
                Assert.Fail();

            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do pet é obrigatório!") &&
                         ex.Message.Contains("Data de nascimento do pet deve ser menor que hoje!") &&
                         ex.Message.Contains("Peso do pet deve ser maior que zero!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Cachorro_Sexo_Deve_Ser_Femea_Ou_Macho_Test()
        {
            try
            {
                var nome_cao = "Tequila";
                var sexo = Sexo.Femea;
                var dtnasc = new DateTime(2020, 11, 14);
                var peso = 15;

                var cachorro = new Cachorro()
                {
                    Nome = nome_cao,
                    Sexo = sexo,
                    Nascimento = dtnasc,
                    Peso = peso,
                };

                cachorro.Validar();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Sexo do cachorro deve ser Fêmea ou Macho!", ex.Message);
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
            var pessoa = new Dono
            {
                Nome = "Silvia",
                Email = "silvia@teste.com",
                Telefone = "(14)99770-7070"
            };

            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Dono = pessoa
            };
            Console.WriteLine(cachorro.Dono.Nome);
            Assert.AreEqual("Silvia", cachorro.Dono.Nome);
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
            var nome_cao = "Léia";
            var raca = "Yorkshire";

            var porte = new Raca
            {
                Nome = raca,
                Porte = Porte.Pequeno
            };

            var cachorro = new Cachorro
            {
                Nome = nome_cao,
                Raca = porte
            };

            Assert.AreEqual(Porte.Pequeno, cachorro.Raca.Porte);
            Console.WriteLine(cachorro.Raca.Porte);

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