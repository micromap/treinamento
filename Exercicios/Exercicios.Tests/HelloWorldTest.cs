using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        //[TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();

            //Classe Assert usada para realizar testes de validacao.
            //A mensagem sera testada para ver se retorna "HelloWorld".
            Assert.AreEqual("HelloWorld", mensagem);

            Console.WriteLine(mensagem);
        }


        //[TestMethod]
        public void Conversao_Implicita_Test()
        {

            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);

        }

        //[TestMethod]
        public void Tipo_De_Valor_Test()
        {

            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
            Assert.AreNotEqual(10, valor);

        }

        //[TestMethod]
        public void Igualdade_Entre_Tipos_De_Referencia()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "LALALA";


            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        //[TestMethod]
        public void Desigualdade_Entre_Tipos_De_Referencia()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "LALALA";


            Cachorro cachorro2 = new Cachorro();
            cachorro1.Nome = "HAHAHA";

            Assert.AreEqual(cachorro1, cachorro2);
        }

        //[TestMethod]
        public void Tipos_Explicitos_Test()
        {

            string nome = "LLALA";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        //[TestMethod]
        public void Tipos_Implicitos_Test()
        {

            var nome = "LLALA";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

        }

        //[TestMethod]
        public void Declarar_Sem_Inicializar()
        {

            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

        }

        //[TestMethod]
        public void Tipos_Que_Aceitam_Null()
        {

            string nome = null;
            Cachorro cachorro = null;

            //int e double nao aceitam NULL
            //int idade = 1;
            //double peso = 1.3;

            Assert.AreEqual(null, nome.GetType());
            Assert.AreEqual(null, cachorro.GetType());
        }

        //[TestMethod]
        public void Tipos_Nulaveis_Test()
        {

            int? idade = null;
            double? peso = null;
            bool? vacinado = null;

            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
        }

        //[TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
        }

        //[TestMethod]
        public void DateTime_Test()
        {
            //Somente data
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Dia + hora
            var agora = DateTime.Now;
            Console.WriteLine(agora);
        }

        //[TestMethod]
        public void DateTime_Desmenbrando_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(agora.Year);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);
            Console.WriteLine(agora.Millisecond);
            Console.WriteLine(agora.DayOfWeek);
            Console.WriteLine(agora.DayOfYear);

        }

        //[TestMethod]
        public void DateTime_Add_Test()
        {
            var agora = DateTime.Now;

            Console.WriteLine(agora.AddHours(5));
            Console.WriteLine(agora.AddDays(1));
            Console.WriteLine(agora.AddDays(-1));
            Console.WriteLine(agora.AddMonths(1));

        }

        //[TestMethod]
        public void DateTime_Inicializacao_Test()
        {

            //Construtor Ano+Mes+Dia
            var data = new DateTime(2020, 11, 13);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 11, 13, 11, 10, 35);
            Console.WriteLine(dataHora);

        }

        //[TestMethod]
        public void DateTime_Convertendo_De_String_Test()
        {
            string texto = "2020/11/13 11:15:20";
            var data = DateTime.Parse(texto);

            Console.WriteLine(data);
        }

        //[TestMethod]
        public void DateTime_Quantidade_Dias_Mes_Test()
        {
            var diasMes = DateTime.DaysInMonth(2020, 11);
            Console.WriteLine(diasMes);

            var ultimoDiaMes = new DateTime(2020, 11, diasMes);
            Console.WriteLine(ultimoDiaMes);
        }

        //[TestMethod]
        public void DateTime_Formatacoes_Test()
        {

            DateTime agora = DateTime.Now;

            Console.WriteLine(agora);

            //Formatado
            Console.WriteLine(agora.ToString("dd/MM/yyyy"));

            //Nome do Mes Formatado e ano.
            Console.WriteLine(agora.ToString("MMMM/yyyy"));

        }

        [TestMethod]
        public void TimeSpan_Test()
        {

            var hoje = DateTime.Today;
            var amanha = hoje.AddDays(1);

            var dif = amanha.Subtract(hoje);

            Console.WriteLine("Diferenca: " + dif);

        }

        [TestMethod]
        public void Array_While_Test()
        {
            var array = new int[3];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            var i = 0;
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }

        [TestMethod]
        public void Array_Do_While_Test()
        {
            var array = new string[] { "Léia", "Yuri", "Tequila" };

            var i = 0;
            do
            {
                Console.WriteLine(array[i++]);
            } while (i < array.Length);
        }

        [TestMethod]
        public void Array_For_Test()
        {
            var array = new string[] { "Léia", "Yuri", "Tequila" };

            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new[] { "Léia", "Yuri", "Tequila" };

            for (var i = array.Length - 1; i >= 0; i--)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_Foreach_Test()
        {
            var array = new[] { "Léia", "Yuri", "Tequila" };

            foreach (var item in array)
                Console.WriteLine(item);
        }

        [TestMethod]
        public void List_Foreach_Test()
        {
            var lista = new List<string> { "Léia", "Yuri", "Tequila" };
            lista.Add("Xyz");
            lista.Remove("Yuri");

            foreach (var item in lista)
                Console.WriteLine(item);
        }

        [TestMethod]
        public void Dictionary_Test()
        {
            var dic = new Dictionary<int, string>();
            dic.Add(1, "Léia");
            dic.Add(2, "Yuri");
            dic.Add(3, "Tequila");

            dic.Remove(2);

            foreach (var item in dic)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }

        [TestMethod]
        public void If_Else_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            string mensagem;
            if (numero % 2 == 0)
                mensagem = $"{numero} é par";
            else
                mensagem = $"{numero} é impar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void If_Inline_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            var mensagem = numero % 2 == 0
                ? $"{numero} é par"
                : $"{numero} é impar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Else_If_Test()
        {
            var hoje = DateTime.Today;

            string mensagem;

            if (hoje.DayOfWeek == DayOfWeek.Sunday)
                mensagem = "Hoje é Domingo";
            else if (hoje.DayOfWeek == DayOfWeek.Monday)
                mensagem = "Hoje é Segunda :(";
            else if (hoje.DayOfWeek == DayOfWeek.Tuesday)
                mensagem = "Hoje é Terça";
            else if (hoje.DayOfWeek == DayOfWeek.Wednesday)
                mensagem = "Hoje é Quarta";
            else if (hoje.DayOfWeek == DayOfWeek.Thursday)
                mensagem = "Hoje é Quinta";
            else if (hoje.DayOfWeek == DayOfWeek.Friday)
                mensagem = "Sextou!";
            else
                mensagem = "É Sábado! :)";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Switch_Case_Test()
        {
            var hoje = DateTime.Today;

            string mensagem;

            switch (hoje.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    mensagem = "Hoje é Domingo";
                    break;
                case DayOfWeek.Monday:
                    mensagem = "Hoje é Segunda :(";
                    break;
                case DayOfWeek.Tuesday:
                    mensagem = "Hoje é Terça";
                    break;
                case DayOfWeek.Wednesday:
                    mensagem = "Hoje é Quarta";
                    break;
                case DayOfWeek.Thursday:
                    mensagem = "Hoje é Quinta";
                    break;
                case DayOfWeek.Friday:
                    mensagem = "Sextou!";
                    break;
                default:
                    mensagem = "É Sábado! :)";
                    break;
            }

            Console.WriteLine(mensagem);
        }

    }
}
