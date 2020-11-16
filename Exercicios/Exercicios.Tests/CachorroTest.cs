using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace Exercicios.Tests
{   
    //Classe de teste, da classe Cachorro()
    [TestClass]
   public  class CachorroTest
    {
        // Classe de teste Latir(), testa quantidade de latidos do cachorro com variavel short... 
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


        //Criando metodos de teste, para testar os atributos da classe Cachorro()
        [TestMethod]
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = 10.25;
            var pesoKg = leia.PesoKg;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(10.25, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = -1.0;
            var pesoKg = leia.PesoKg;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = null;
            var peso = leia.PesoKg;

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
            Assert.AreEqual("1 mes", idade);
            Console.WriteLine(idade);
        }

        [TestMethod]
        public void Cachorro_Nome_Obrigatorio_Test()
        {
            try
            {
                var cachorro = new Cachorro
                {
                    Nome = "",
                    Sexo = Sexo.Macho,
                    DataNascimento = DateTime.Today.AddMonths(5),
                    PesoKg = 0

                };
                
                cachorro.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do cachorro é obrigatório!!") &&
                         ex.Message.Contains("A data de nascimento do cachorro, deve menor que hoje!!") &&
                         ex.Message.Contains("Peso do cachorro deve ser maior que zero!!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }    
        }

        [TestMethod]
        public void Cachorro_Associação_Raca_Test()
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
        public void Cachorro_Associação_Dono_Test()
        {
            var matheus = new Dono { Nome = "Matheus", Email = "matheus@gemmap.com.br", Telefone = "(14) 99835-5969" };

            var tequila = new Cachorro
            {
                Nome = "Tequila",
                Dono = matheus
            };

            Console.WriteLine(tequila.Dono.Nome);

            Assert.AreEqual("Matheus", tequila.Dono.Nome);
        }

        [TestMethod]
        public void Cachorro_Enum_Sexo_Test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Tequila",
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
                Nome = "Leia",
                Raca = york
            };

            Console.WriteLine(leia.Raca.Porte);
            Assert.AreEqual(Porte.Pequeno, leia.Raca.Porte);
        }
    }
}
