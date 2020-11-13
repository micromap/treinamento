using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            var mensagem = HelloWorld.SayHello();
            Console.WriteLine(mensagem);
            Assert.AreEqual("Hello World!", mensagem);
        }

        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_Test()
        {
            // Tipos Primitivos
            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            //Tipo complexo
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
        public void Igualdade_entre_Tipos_de_Valor_Test()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1, valor2);
        }

        [TestMethod]
        public void Desigualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = new Cachorro();
            cachorro1.Nome = "Léia";

            Assert.AreNotEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_Explicitos_Test()
        {
            string nome = "Leia";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_Implicitos_Test()
        {
            var nome = "Leia";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Declarar_Sem_Inicializar_Test()
        {
            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

            // Não podemos declarar variaveis implicitas sem atribuir valor
            //var nome;
            //nome = "Leia";
            //Assert.AreEqual(typeof(string), nome.GetType());
        }

        [TestMethod]
        public void Tipos_Que_Aceitam_Null_Test()
        {
            string nome = null;
            Cachorro cachorro = null;

            Assert.AreEqual(null, nome);
            Assert.AreEqual(null, cachorro);
        }

        [TestMethod]
        public void Tipos_Nulaveis_Test()
        {
            int? idade = null;
            double? peso = null;
            bool? vacinado = null;

            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
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
        public void DateTime_Desmembrando_Test()
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
            var data = new DateTime(2020, 10, 30);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 10, 30, 16, 36, 0);
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Convertendo_de_String_Test()
        {
            var data = DateTime.Parse("30/10/2020");
            Console.WriteLine(data);

            var dataHora = DateTime.Parse("30/10/2020 10:53");
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Quantidade_Dias_Mes_Test()
        {
            var diasMes = DateTime.DaysInMonth(2020, 10);
            Console.WriteLine(diasMes);

            var ultimoDiaMes = new DateTime(2020, 10, diasMes);
            Console.WriteLine(ultimoDiaMes);
        }

        [TestMethod]
        public void DateTime_Formatacoes_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("f"));
            Console.WriteLine(agora.ToString("dd/mm/yyyy"));
            Console.WriteLine(agora.ToString("dd/mm/yyyy HH:mm"));
            Console.WriteLine(agora.ToString("MMMM/yy"));
            Console.WriteLine(agora.ToString("MM/yyyy"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var hoje = DateTime.Today;
            var amanha = hoje.AddDays(1);

            var data1 = new DateTime(2020, 10, 30, 18, 30, 00);
            var data2 = new DateTime(2022, 10, 30, 18, 30, 00);

            var dif = data2.Subtract(data1);

            Console.WriteLine(dif);
            Console.WriteLine(dif.TotalSeconds);
            Console.WriteLine(dif.TotalMinutes);
            Console.WriteLine(dif.TotalHours);
            Console.WriteLine(dif.TotalDays);
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
            var array = new string[] {"Léia","Yuri","Tequila"};

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
            {
                Console.WriteLine(array[i]);
            }
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new[] { "Léia", "Yuri", "Tequila" };

         for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        [TestMethod]
        public void Array_Foreach_Test()
        {
           var array = new[] { "Léia", "Yuri", "Tequila" };
           

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void List_Foreach_Test()
        {
            var lista = new List<string> { "Léia", "Yuri", "Tequila" };
            lista.Add("Xyz");
            lista.Remove("Yuri");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Dictionary_Test()
        {
            //var lista = new List<string> { "Léia", "Yuri", "Tequila" };
            var dic = new Dictionary<int, string>();
            dic.Add(1, "Léia");
            dic.Add(2, "Yuri");
            dic.Add(3, "Tequila");

            dic.Remove(2);

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        [TestMethod]
        public void If_Else_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            string mensagem;
            if (numero % 2 == 0)
            {
                mensagem = $"{numero} é par";
            }
            else
            {
                mensagem = $"{numero} é impar";
            }

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void If_InLine_Test()
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

            var mensagem = "";

            if (hoje.DayOfWeek == DayOfWeek.Sunday)
                mensagem = "Hoje é Domingo";
            else if (hoje.DayOfWeek == DayOfWeek.Monday)
                mensagem = "Hoje é Segunda";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Switch_Case_Test()
        {
            var hoje = DateTime.Today;

            var mensagem = "";

            switch (hoje.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    mensagem = "Hoje é Domingo";
                    break;
                case DayOfWeek.Monday:
                    mensagem = "Hoje é Segunda";
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
                    mensagem = "Hoje é Sexta";
                    break;
                default:
                    mensagem = "Hoje é Sábado";
                    break;
            }

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Exception_test()
        {
            try
            {
                Cachorro cachorro = null;
                if (cachorro == null)
                    throw new Exception("O cachorro não foi instanciado!");

                var mensagem = cachorro.ValidarCampos();

                var x = 10;
                var y = 0;
                var resultado = x / y;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de Divisão por zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Fim do Teste!");
            }


        }
    }
}