using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            var dataNascimento = new DateTime(1998, 10, 25);

            Cachorro cachorro = new Cachorro();
            String cachorroIdade = cachorro.idade(dataNascimento);
            
            Console.WriteLine($"Data de Nascimento {dataNascimento}");
            Console.WriteLine($"Data Atual {DateTime.Today}");

            TimeSpan dataaux = DateTime.Today.Subtract(dataNascimento);

            double idade = Math.Truncate(dataaux.TotalDays / 365);

            if (idade < 1)
                result = $"Cachorro tem {idade} Mese(s)";
            else
                result = $"Cachorro tem {idade} Ano(s)";

            Console.WriteLine(result);

            Assert.AreEqual(result, cachorroIdade);
        }
    }
}
