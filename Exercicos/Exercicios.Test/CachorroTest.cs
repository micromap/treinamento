using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Exercicios.Test
{   
    [TestClass]
    public class CachorroTest
    {   [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            short quantiade = 3;
            string latido = leia.Latir(quantiade);

            string result = "";

            for (int i = 0; i < quantiade; i++)
            {
                result += "Au! ";
            }

            Console.WriteLine(latido);

            Assert.AreEqual(result, latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            int peso = 1;
            double quandoDevoComer = leia.quantoDevoComer(peso);

            double result = ((peso * 1000) * 5 / 100);

            Console.WriteLine($"Como tenho {peso} KG, devo comer {quandoDevoComer}g");

            Assert.AreEqual(result, quandoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuandoDevoComer_Teste ()
        {
            Cachorro tequila = new Cachorro();
            int peso = 10;
            double quandoDevoComer = tequila.quantoDevoComer(peso);

            double result = ((peso * 1000) * 5 / 100);

            Console.WriteLine($"Como tenho {peso} KG, devo comer {quandoDevoComer}g");

            Assert.AreEqual(result, quandoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuandoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            int peso = 25;
            double quandoDevoComer = yuri.quantoDevoComer(peso);

            double result = ((peso * 1000) * 5 / 100);

            Console.WriteLine($"Como tenho {peso} KG, devo comer {quandoDevoComer}g");

            Assert.AreEqual(result, quandoDevoComer);
        }

        [TestMethod]
        public void Idade_Cachorro_Test()
        {
            String result = "";
            var dataNascimento = new DateTime(1999, 10, 25);

            Cachorro cachorro = new Cachorro();
            String cachorroIdade = cachorro.idade(dataNascimento);
            
            Console.WriteLine($"Data de Nascimento {dataNascimento}");
            Console.WriteLine($"Data Atual {DateTime.Today}");

            var anos = DateTime.Today.Year - dataNascimento.Year;
            var meses = DateTime.Today.Month - dataNascimento.Month + (12 * anos);

            if (meses == 1)
                result = $"Cachorro tem {meses} Mês";
            else if (meses < 12)
                result = $"Cachorro tem {meses} Meses";
            else if (anos == 1)
                result = $"Cachorro tem {anos} Ano";
            else
                result = $"Cachorro tem {anos} Anos";

            Console.WriteLine(result);

            Assert.AreEqual(result, cachorroIdade);
        }

        [TestMethod]
        public void Validar_Dados_Cachorro_Test()
        {
            try
            {
                Cachorro cachorro = new Cachorro();
                cachorro.Nome = "Ted";
                cachorro.Sexo = Sexo.Macho;
                cachorro.DataNascimento = new DateTime(1998, 10, 30);
                cachorro.Peso = 20.5;

                cachorro.ValidarDadosCachorro();

                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("Nome do Cachorro é Obrigatório", e.Message);
                Console.WriteLine(e.Message);
            }   
            finally
            {
                Console.WriteLine("Fim do Teste");
            }
        }
    }
}
