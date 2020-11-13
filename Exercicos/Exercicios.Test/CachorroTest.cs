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
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Ted";
            cachorro.Sexo = "Macho";
            cachorro.DataNascimento = new DateTime(1998, 10, 30);
            cachorro.Peso = 20.5;

            var listaDados = cachorro.validarDadosCachorro();

            var listaValidar = new List<string>();

            if (string.IsNullOrWhiteSpace(cachorro.Nome))
                listaValidar.Add("Nome do Cachorro é Obrigatório");
            else
                listaValidar.Add("Nome Cachorro OK");

            if (cachorro.Sexo.Equals("Macho") || cachorro.Sexo.Equals("Femea"))
                listaValidar.Add("Sexo Cachorro OK");
            else
                listaValidar.Add("Sexo do Cachorro Inválido");

            if (cachorro.DataNascimento > DateTime.Today)
                listaValidar.Add("Data de Nascimento do Cachorro deve ser menor que Hoje");
            else
                listaValidar.Add("Data Nascimento Cachorro OK");

            if (cachorro.Peso <= 0)
                listaValidar.Add("Peso do Cachorro deve ser maior que 0 (zero)");
            else
                listaValidar.Add("Peso Cachorro OK");

            if (listaValidar.Count == 0)
                listaValidar = null;

            foreach (var item in listaValidar)
                Console.WriteLine(item);

            CollectionAssert.AreEqual(listaValidar, listaDados);
        }
    }
}
