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
            Assert.AreEqual("Como tenho 1Kg,devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30Kg,devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15Kg,devo comer 750g por dia", quantoDevoComer);
        }

        
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            var yuri = new Cachorro();

            yuri.Nome = "Yuri";
            var nome = yuri.Nome;

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        public void Cachorro_Set_Get_Raca_Test()
        {
            var Tequila = new Cachorro();

            Tequila.Raca = "Labrador";
            var raca = Tequila.Raca;

            Console.WriteLine(raca);
            Assert.AreEqual("Labrador", raca);
        }

        public void Cachorro_Set_Get_Sexo_Test()
        {
            var Leia = new Cachorro();

            Leia.Sexo = "Fêmea";
            var sexo = Leia.Sexo;

            Console.WriteLine(sexo);
            Assert.AreEqual("Fêmea", sexo);
        }

        
        public void Cachorro_Set_Get_Porte_Test()
        {
            var Leia = new Cachorro();

            Leia.Porte = "Médio";
            var porte = Leia.Porte;

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        
        public void Tequila_Cachorro_Set_Get_Idade_Test()
        {
            var Tequila = new Cachorro();

            Tequila.Idade = 4;
            var idade = Tequila.Idade;

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);
        }

        
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            var Leia = new Cachorro();

            Leia.Peso = 1.2;
            var pesoKg = Leia.Peso;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(1.2, pesoKg);
        }

        
        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var Leia = new Cachorro();

            Leia.Peso = -1.2;
            var pesoKg = Leia.Peso;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
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
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            var tequila = new Cachorro();

            tequila.Vacinado = true;
            var vacinado = tequila.Vacinado;

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Anos_Test()
        {
            var cachorro = new Cachorro();
            cachorro.DataNascimento = DateTime.Today.AddYears(-4);
            //cachorro.DataNascimento = new DateTime(2016, 1, 10);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("4 anos", idade);
            Console.WriteLine("Idade do cachorro: "+ idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_um_Ano_Test()
        {
            var cachorro = new Cachorro();
            //cachorro.DataNascimento = new DateTime(2019, 1, 10);
            cachorro.DataNascimento = DateTime.Today.AddYears(-1);
            var idade = cachorro.GetIdade();
            Assert.AreEqual("1 ano", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_GetIdade_em_Meses_Test()
        {
            var cachorro = new Cachorro();
            //cachorro.DataNascimento = new DateTime(2019, 11, 10);
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
        public void Cachorro_Nome_Obrigatorio_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "",
                Sexo = "Fêmea",
                DataNascimento = new DateTime(2020, 7, 4),
                Peso = 5
            };

            var mensagens = cachorro.Validar();

            Assert.AreEqual("Nome do Cachorro é Obrigatório!", mensagens[0]);
            Console.WriteLine(mensagens[0]);
        }

        [TestMethod]
        public void Cachorro_Sexo_Deve_Ser_Femea_ou_Macho_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Sexo = "Xyz",
                DataNascimento = new DateTime(2020, 7, 4),
                Peso = 5
            };

            var mensagens = cachorro.Validar();

            Assert.AreEqual("Sexo do Cachorro deve ser Fêmea ou Macho!", mensagens[0]);
            Console.WriteLine(mensagens[0]);
        }

        [TestMethod]
        public void Cachorro_Sexo_DataNascimento_Deve_ser_Menor_que_Hoje_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Sexo = "Fêmea",
                DataNascimento = DateTime.Today.AddMonths(5),
                Peso = 5
            };

            var mensagens = cachorro.Validar();

            Assert.AreEqual("Data de Nascimento do Cachorro deve ser menor que Hoje!",
                mensagens[0]);
            Console.WriteLine(mensagens[0]);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_ser_Maior_que_Zero_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Sexo = "Fêmea",
                DataNascimento = new DateTime(2020, 7, 4),
                Peso = 0
            };

            var mensagens = cachorro.Validar();

            Assert.AreEqual("Peso do Cachorro deve ser maior que zero!",
                mensagens[0]);
            Console.WriteLine(mensagens[0]);
        }
    }
}
