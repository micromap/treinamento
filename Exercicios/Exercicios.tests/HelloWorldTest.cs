using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.domain;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios.tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", mensagem);
        }
        [TestMethod]
        public void Tipos_Primitivos_e_Complexos()
        {
            // tipos primitivos
            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            // tipo complexo
            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);

        }
        [TestMethod]
        public void Conversao_Implicita_Test()
        {
            int inteiro = 10;
            double valor = inteiro;

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }
        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);
        }
        [TestMethod]
        public void Tipo_De_Valor_test()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
            Assert.AreEqual(10, valor);
        }
        [TestMethod]
        public void Tipo_De_Referencia_test()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Léia";

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.Nome;

            Console.WriteLine(nomeCachorro);
            Assert.AreEqual("Tequila", nomeCachorro);
        }
        [TestMethod]
        public void Igualdade_Entre_Tipos_De_Valor_Test()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1,valor2);
        }
        [TestMethod]
        public void Desigualdade_Entre_Tipos_De_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Léia";

            Assert.AreNotEqual(cachorro1,cachorro2);
        }

        [TestMethod]
        public void Igualdade_Entre_Tipos_De_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = cachorro1;
            cachorro2.Nome = "Léia";

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
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
        public void DateTime_Desmembrando_test()
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
        public void Datetime_Add_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);

            var mais5horas = agora.AddHours(5);
            Console.WriteLine(mais5horas);

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
            var data = new DateTime(2020, 10, 17);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 10, 17,10, 48, 0);
            Console.WriteLine(dataHora);
        }

    }

}
