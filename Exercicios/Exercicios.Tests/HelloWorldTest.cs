using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();
            Console.WriteLine(mensagem);
            Assert.AreEqual("Hello World!", mensagem);
        }
        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_test()
        {
            // Tipos Primitivos
            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            // Tipo Complexo
            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);
        }
        [TestMethod]
        public void Conversao_Implicita_test()
        {
            int inteiro = 10;
            double valor = inteiro;
            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }
        [TestMethod]
        public void Conversao_Explicita_test()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);
        }

        [TestMethod]
        public void Tipo_de_Valor_Test()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
            Assert.AreEqual(10, valor);
        }

        [TestMethod]
        public void Tipo_de_Referencia_Test()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Léia";

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.Nome;

            Console.WriteLine(nomeCachorro);
            Assert.AreEqual("Tequila", nomeCachorro);
        }

        [TestMethod]
        public void Igualdade_Entre_Tipo_de_Valores_Test()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1, valor2);
        }

        [TestMethod]
        public void Desigualdade_Entre_Tipo_de_Referencias_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Leia";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Leia";

            Assert.AreNotEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Igualdade_Entre_Tipo_de_Referencias_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Leia";

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void DateTime_Test()
        {
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var agora = DateTime.Now;
            Console.WriteLine(agora);
        }

        [TestMethod]
        public void DateTime_Desmenbrando_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(agora.Year);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Hour);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);
            Console.WriteLine(agora.Millisecond);
            Console.WriteLine(agora.DayOfWeek);
            Console.WriteLine(agora.DayOfYear);
        }

        [TestMethod]
        public void DateTime_Add_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);

            var mais5Horas = agora.AddHours(5);
            Console.WriteLine(mais5Horas);

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);

            var mesQueVem = agora.AddMonths(1);
            Console.WriteLine(mesQueVem);
        }

        [TestMethod]
        public void DateTime_Inicializacao_Test()
        {
            var data = new DateTime(2020, 11, 23);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 11, 23, 16, 22, 0);
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Convertendo_de_String_Test()
        {
            var data = DateTime.Parse("23/11/2020");
            Console.WriteLine(data);

            var dataHora = DateTime.Parse("23/11/2020 18:25");
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Quantidade_Dias_Mes_Test()
        {
            var diasMes = DateTime.DaysInMonth(2020, 11);
            Console.WriteLine(diasMes);

            var ultimoDiaMes = new DateTime(2020, 11, diasMes);
            Console.WriteLine(ultimoDiaMes);
        }

        [TestMethod]
        public void DateTime_Formatacoes_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("f"));
            Console.WriteLine(agora.ToString("dd/MM/yyyy"));
            Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(agora.ToString("MMMM/yy"));
            Console.WriteLine(agora.ToString("MM/yy"));
            Console.WriteLine(agora.ToString("MMM/yyyy"));
        }

        [TestMethod]
        public void DateTime_TimeSpan_Test()
        {
            var data1 = new DateTime(2020, 11, 23, 19, 09, 15);
            var data2 = new DateTime(2020, 11, 24, 20, 18, 23);

            var dif = data2.Subtract(data1);
            Console.WriteLine(dif);
            Console.WriteLine(dif.TotalSeconds);
            Console.WriteLine(dif.TotalMinutes);
            Console.WriteLine(dif.TotalHours);
            Console.WriteLine(dif.TotalDays);
        }
    }
}
