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
            var leia = new Ipet();
            var latido = leia.Latir(6);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Ipet();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Ipet();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Ipet();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var leia = new Ipet();

            leia.Peso = 1.2;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(1.2, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var leia = new Ipet();

            leia.Peso = -1.2;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
            var leia = new Ipet();

            leia.Peso = null;
            var peso = leia.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Anos_Test()
        {
            var cachorro = new Ipet();
            cachorro.DataNascimento = DateTime.Today.AddYears(-4);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("4 anos", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Ano_Test()
        {
            var cachorro = new Ipet();
            cachorro.DataNascimento = DateTime.Today.AddYears(-1);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("1 ano", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            var cachorro = new Ipet();
            cachorro.DataNascimento = DateTime.Today.AddMonths(-11);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("11 meses", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Mes_Test()
        {
            var cachorro = new Ipet();
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
                var cachorro = new Ipet
                {
                    Nome = "",
                    Sexo = SexoEnum.Femea,
                    DataNascimento = DateTime.Today.AddMonths(5),
                    Peso = 0
                };
                cachorro.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do Cachorro é Obrigatório!") &&                         
                         ex.Message.Contains("Data de Nascimento do Cachorro deve ser menor que Hoje!") &&
                         ex.Message.Contains("Peso do Cachorro deve ser maior que zero!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }

        }

        [TestMethod]
        public void Cachorro_Associacao_Raca()
        {
            var labrador = new Raca { Nome = "Labrador" };
            var tequila = new Ipet()
            {
                Nome = "tequila",
                Raca = labrador
            };
            Console.WriteLine(tequila.Raca.Nome);

            Assert.AreEqual("Labrador", tequila.Raca.Nome);

        }

        [TestMethod]
        public void Cachorro_Associacao_Dono()
        {
            var eder = new Dono
            {
                Nome = "Eder",
                Telefone = 2345678,
                Email = "eder@eder.com.br"
            };
            var tequila = new Ipet 
            {
                Nome = "tequila",
                Dono = eder 
            };

            Console.WriteLine("Nome: " + tequila.Dono.Nome);
            Console.WriteLine("Email: " + tequila.Dono.Email);
            Console.WriteLine("Telefone: " + tequila.Dono.Telefone);

            Assert.AreEqual("Eder", tequila.Dono.Nome);

        }

        [TestMethod]
        public void Cachorro_Enum_Sexo()
        {
            var cachorro = new Ipet();
            cachorro.Nome = "Léia";
            cachorro.Sexo = SexoEnum.Macho;

            Console.WriteLine(cachorro.Sexo);
            Assert.AreEqual(SexoEnum.Macho, cachorro.Sexo);
        }

        [TestMethod]
        public void Cachorro_Enun_Porte()
        {
                  
            var york = new Raca
            {
                Nome = "Yorkshide",
                Porte = PorteEnum.Pequeno
            };

            var leia = new Ipet
            {
                Nome = "Léia",
                Raca = york
            };

            Assert.AreEqual(PorteEnum.Pequeno, leia.Raca.Porte);
            Console.WriteLine(leia.Raca.Porte);
        }

    }
}