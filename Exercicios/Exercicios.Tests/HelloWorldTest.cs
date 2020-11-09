using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();

            Assert.AreEqual("Hello Word!", mensagem);

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_test()
        {
            // Tipos primitivos
            string mensagem = "Hello world!";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            // Tipos complexos 
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
            Assert.AreNotEqual (valor, inteiro);
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
            cachorro.Nome = "L�ia";

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
            cachorro1.Nome = "L�ia";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Tequila";

            Assert.AreNotEqual(cachorro1, cachorro2);
        }


        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            //cachorro1.SetNome("L�ia");
            Cachorro cachorro2 = cachorro1;
                
            Console.WriteLine(cachorro2);
            Console.WriteLine(cachorro1);
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

            // N�o podemos inicializar variaveis implicitas sem atribuir valor
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

            //Strings e objetos podem receber null como valor
            /*int idade = null;
            double peso = null;
            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);*/
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
            var data = new DateTime(2020, 10 , 27);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 10, 27, 8, 55, 0);
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Convertendo_de_String_Test()
        {
            var data = DateTime.Parse("27/10/2020");
            Console.WriteLine(data);

            var dataHora = DateTime.Parse("27/10/2020 09:05");
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
            Console.WriteLine(agora);
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("f"));
            Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(agora.ToString("MMMM/yy"));
            Console.WriteLine(agora.ToString("MMM/yy"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var data1 = new DateTime(2020, 10, 27, 14, 25, 36);
            var data2 = new DateTime(2020, 10, 28, 19, 55, 19);

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
            var array = new string [] {"L�ia", "Tequila", "Yuri"}; 
            
            var i = 0;
            do
            {
                Console.WriteLine(array[i++]);
            } while (i < array.Length);
        }

        [TestMethod]
        public void Array_For_Test()
        {
            var array = new string[] { "L�ia", "Tequila", "Yuri" };

            for (var i = 0; i < array.Length; i ++)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new[] { "L�ia", "Tequila", "Yuri" };

            for (var i = array.Length - 1; i >=0; i--)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_Foreach_Test()
        {
            var lista = new List<string> { "L�ia", "Tequila", "Yuri" };
            lista.Add("Xyz");
            lista.Remove("Yuri");

            foreach (var i in lista)
                Console.WriteLine(i);
        }

        [TestMethod]
        public void Dicionary_Test()
        {
            var dic = new Dictionary<int, string>();
            dic.Add(1, "L�ia");
            dic.Add(2, "yuri");
            dic.Add(3, "Tequila");

            dic.Remove(2);

            foreach (var i in dic)
                Console.WriteLine($"{i.Key}: {i.Value}");
        }

        [TestMethod]
        public void If_Else_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            string mensagem;
            if (numero % 2 == 0)
                mensagem = $"{numero} � par";
            else
                mensagem = $"{numero} � �mpar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void If_Inline_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            var mensagem = numero % 2 == 0
                ? $"{numero} � par"
                : $"{numero} � �mpar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Else_If_Test()
        {
            var hoje = DateTime.Today;

            string mensagem;

            if (hoje.DayOfWeek == DayOfWeek.Sunday)
                mensagem = "Hoje � domingo";
            else if (hoje.DayOfWeek == DayOfWeek.Monday)
                mensagem = "Hoje � segunda";
            else if (hoje.DayOfWeek == DayOfWeek.Tuesday)
                mensagem = "Hoje � ter�a";
            else if (hoje.DayOfWeek == DayOfWeek.Wednesday)
                mensagem = "Hoje � quarta";
            else if (hoje.DayOfWeek == DayOfWeek.Thursday)
                mensagem = "Hoje � quinta";
            else if (hoje.DayOfWeek == DayOfWeek.Friday)
                mensagem = "Hoje � sexta";
            else
                mensagem = "Hoje � sabado";

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
                    mensagem = "Hoje � domingo";
                    break;
                case DayOfWeek.Monday:
                    mensagem = "Hoje � segunda";
                    break;
                case DayOfWeek.Tuesday:
                    mensagem = "Hoje � ter�a";
                    break;
                case DayOfWeek.Wednesday:
                    mensagem = "Hoje � quarta";
                    break;
                case DayOfWeek.Thursday:
                    mensagem = "Hoje � quinta";
                    break;
                case DayOfWeek.Friday:
                    mensagem = "Hoje � sexta";
                    break;
                default:
                    mensagem = "Hoje � sabado";
                    break;
            }
            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Exception_Test()
        {
            try
            {
                Cachorro cachorro = null;
                if (cachorro == null)
                    throw new Exception("O cachorro n�o foi instanciado");

                cachorro.Validar();

                var x = 10;
                var y = 0;
                var resultado = x / y;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de divis�o por zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Fim do teste!");
            }
        }
    }
}
