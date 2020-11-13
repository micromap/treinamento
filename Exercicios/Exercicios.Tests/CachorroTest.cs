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
        public void  Cachorro_GetIdade_em_Anos_Test()
        {
            var cachorro = new Cachorro();
            var idade_Anos = cachorro.CalcularIdade(DateTime.Today.AddYears(-4));

            Console.WriteLine(idade_Anos);
            Assert.AreEqual("4 anos", idade_Anos);

            var idade_Ano = cachorro.CalcularIdade(DateTime.Today.AddYears(-1));

            Console.WriteLine(idade_Ano);
            Assert.AreEqual("1 ano", idade_Ano);

        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            var cachorro = new Cachorro();
            var idade_Meses = cachorro.CalcularIdade(DateTime.Today.AddMonths(-11));

            Console.WriteLine(idade_Meses);
            Assert.AreEqual("11 meses", idade_Meses);

            var idade_Mes = cachorro.CalcularIdade(DateTime.Today.AddMonths(-1));

            Console.WriteLine(idade_Mes);
            Assert.AreEqual("1 mês", idade_Mes);

        }

        [TestMethod]
        public void Cachorro_Valida_Nome_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = null;
            cachorro.Sexo = "Teste";
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 10;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado[0]);
            Assert.AreEqual("Nome do cachorro é obrigatório", resultado[0]);

        }

        [TestMethod]
        public void Cachorro_Valida_Sexo_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = "Teste";
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 10;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado[0]);
            Assert.AreEqual("Sexo Inválido", resultado[0]);
        }

        [TestMethod]
        public void Cachorro_Valida_Nascimento_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "YURI";
            cachorro.Sexo = "Fêmea";
            cachorro.DataDeNascimento = DateTime.Parse("14/11/2020");
            cachorro.Peso = 10;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado[0]);
            Assert.AreEqual("Data de Nascimento deve ser anterior ou igual a data de hoje", resultado[0]);
        }

        [TestMethod]
        public void Cachorro_Valida_Peso_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = "Fêmea";
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 0;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado[0]);
            Assert.AreEqual("Peso deve ser maior que 0", resultado[0]);
        }
    }
}