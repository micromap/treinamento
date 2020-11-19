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
            cachorro.Sexo = Sexo.Macho;
            cachorro.DataDeNascimento = DateTime.Today.AddDays(-1);
            cachorro.Peso = 10;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado);
            Assert.AreEqual("Nome do cachorro é obrigatório", resultado[0]);

        }

        [TestMethod]
        public void Cachorro_Valida_Sexo_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = Sexo.Macho;
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 10;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(Sexo.Macho);
            Assert.AreEqual(cachorro.Sexo, Sexo.Macho);
        }

        [TestMethod]
        public void Cachorro_Valida_Nascimento_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "YURI";
            cachorro.Sexo = Sexo.Femea;
            cachorro.DataDeNascimento = DateTime.Today.AddDays(1);
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
            cachorro.Sexo = Sexo.Femea;
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 0;

            var resultado = cachorro.ValidarCampos();

            Console.WriteLine(resultado[0]);
            Assert.AreEqual("Peso deve ser maior que 0", resultado[0]);
        }

        [TestMethod]
        public void Cachorro_Valida_Nome_Exception_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = null;
            cachorro.Sexo = Sexo.Macho;
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 10;


            try
            {
                cachorro.ValidarCamposException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Nome do cachorro é obrigatório", e.Message);
            }
        }

        [TestMethod]
        public void Cachorro_Valida_Sexo_Exception_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = Sexo.Macho;
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 10;

            try
            {
                cachorro.ValidarCamposException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Sexo Inválido", e.Message);
            }
        }

        [TestMethod]
        public void Cachorro_Valida_Nascimento_Exception_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = Sexo.Femea;
            cachorro.DataDeNascimento = DateTime.Parse("14/11/2020");
            cachorro.Peso = 10;

            try
            {
                cachorro.ValidarCamposException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Data de Nascimento deve ser anterior ou igual a data de hoje", e.Message);
            }            
        }

        [TestMethod]
        public void Cachorro_Valida_Peso_Exception_Test()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Yuri";
            cachorro.Sexo = Sexo.Femea;
            cachorro.DataDeNascimento = DateTime.Parse("12/11/2020");
            cachorro.Peso = 0;

            try
            {
                cachorro.ValidarCamposException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Peso deve ser maior que 0", e.Message);
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
        public void Cachorro_Associacao_Dono_teste()
        {
            var dono = new Dono { Nome = "Diego", Email = "diego@gemmap.com.br", Telefone = "(14)99667-5548" };

            var cachorro = new Cachorro
            {
                Nome = "Olga",
                Dono = dono
            };

            Console.WriteLine(cachorro);

            Assert.AreEqual("Diego", cachorro.Dono.Nome);


        }

        [TestMethod]
        public void Cachorro_Enum_Sexo_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Olga",
                Sexo = Sexo.Femea
            };

            Console.WriteLine(cachorro.Sexo);
            Assert.AreEqual(Sexo.Femea, cachorro.Sexo);
        }

        [TestMethod]
        public void Cachorro_Enum_Porte_Test()
        {
            var raca = new Raca
            {
                Nome = "Pug",
                Porte = Porte.Pequeno
            };

            var cachorro = new Cachorro
            {
                Nome = "Olga",
                Raca = raca
            };

            Console.WriteLine(cachorro.Raca.Porte);
            Assert.AreEqual(Porte.Pequeno, cachorro.Raca.Porte);
        }
    }
}