using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios.Domain;
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

            Assert.AreEqual("Hello World!", mensagem);

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_Test()
        {
            // Tipos primitivos

            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            //Tipos Complexos

            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);
        }

        [TestMethod]
        public void Conversao_Implicita_Test()
        {
            int inteiro = 10;
            double valor = inteiro;

            Console.WriteLine("Valor: " + valor);
            Assert.AreEqual(inteiro, valor);
        }

        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine("Valor: " + valor);
            Console.WriteLine("Inteiro: " + inteiro);
            Assert.AreNotEqual(valor, inteiro);
        }

        [TestMethod]
        public void Tipo_de_Valor_Test()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine("Valor: " + valor);
            Assert.AreEqual(10, valor);
        }

        [TestMethod]
        public void Tipo_de_Referencia_Test()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Leia";

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.Nome;

            Console.WriteLine("Nome Cachorro: " + nomeCachorro);
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
            cachorro1.Nome = "Leia";

            Cachorro cachorro2 = new Cachorro();
            cachorro1.Nome = "Leia";

            Assert.AreNotEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Leia";

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

            // N�o podemos declarar variaveis implicitas sem atribuir valor
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

            // O Tipo int , double, bool n�o aceitam ser inicializado com o valor nulo
            // var nome = null;  n�o podemos atribuir o valor nulo, pois o comando var necessita saber um valor verdadeiro para saber o seu tipo (string,int, double,bool......
            // int idade = null;       
            // double peso = null;
            // Assert.AreEqual(null, idade);
            // Assert.AreEqual(null, double);
        }

        [TestMethod]
        public void Tipos_Nulaveis_Test()
        {
            // O Tipo int , double, bool n�o aceitam ser inicializado com o valor nulo, a menos que voc� coloque o sinal de ?
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
            Console.WriteLine("Agora: " + agora);
            Console.WriteLine("Ano: " + agora.Year);
            Console.WriteLine("M�s: " + agora.Month);
            Console.WriteLine("Dia: " + agora.Day);
            Console.WriteLine("Hora: " + agora.Hour);
            Console.WriteLine("Minuto: " + agora.Minute);
            Console.WriteLine("Segundo: " + agora.Second);
            Console.WriteLine("Milisegundo: " + agora.Millisecond);
            Console.WriteLine("Dia da semana: " + agora.DayOfWeek);
            Console.WriteLine("Qtde de dias no ano: " + agora.DayOfYear);
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
        public void DateTime_Convertendo_de_String_Test()
        {
            var data = DateTime.Parse("17/10/2020");
            Console.WriteLine(data);

            var dataHora = DateTime.Parse("17/10/2020 10:53");
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Inicializacao_Test()
        {
            var data = new DateTime(2020, 10, 17);
            Console.WriteLine("Data" + data);

            var dataHora = new DateTime(2020, 10, 17, 10, 48, 0);
            Console.WriteLine("Data/Hora: " + dataHora);
        }

        [TestMethod]
        public void DateTime_Quantidade_Dias_Mes_Test()
        {
            var diasMes = DateTime.DaysInMonth(2020, 10);
            Console.WriteLine("�ltimo do Dia/M�s " + diasMes);

            var ultimoDiaMes = new DateTime(2020, 10, diasMes);
            Console.WriteLine("Data do �ltima dia do M�s " + ultimoDiaMes);
        }

        [TestMethod]
        public void DateTime_Formatacoes_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine("Agora: " + agora);
            Console.WriteLine("Data: " + agora.ToString("d"));  //short date (d)
            Console.WriteLine("Data/Hora: " + agora.ToString("G"));  // vai retornar o dia/mes/ano e a hora em portugu�s
            Console.WriteLine("Semana/Data (Extenso): " + agora.ToString("f"));   // vai retornar a data por extenso

            Console.WriteLine("Data : " + agora.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data/Hora 24 : " + agora.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("Data/Hora 12 : " + agora.ToString("dd/MM/yyyy hh:mm"));
            Console.WriteLine("M�s/Ano : " + agora.ToString("MMMM/yy"));
            Console.WriteLine("M�s abreviado/Ano : " + agora.ToString("MMM/yyyy"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var data1 = new DateTime(2020, 10, 17, 10, 25, 12);
            var data2 = new DateTime(2020, 10, 18, 18, 10, 23);

            var dif = data2.Subtract(data1);

            Console.WriteLine("Diferen�a em Dia/Hora/Min/Seg : " + dif);
            Console.WriteLine("Diferen�a em Segundos : " + dif.TotalSeconds);
            Console.WriteLine("Diferen�a em Minutos : " + dif.TotalMinutes);
            Console.WriteLine("Diferen�a em Horas : " + dif.TotalHours);
            Console.WriteLine("Diferen�a em Dias : " + dif.TotalDays);
        }

        [TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
            obj.MeuMetodo();
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
                Console.WriteLine("Valor do Array [" + i + "]: " + array[i]);
                i++;
            }
        }

        [TestMethod]
        public void Array_Do_While_Test()
        {
            var array = new string[] { "L�ia", "Yuri", "Tequila" };

            var i = 0;
            do
            {
                Console.WriteLine("Valor do Array [" + i + "]: " + array[i++]);
            } while (i < array.Length);
        }

        [TestMethod]
        public void Array_For_Test()
        {
            var array = new string[] { "L�ia", "Yuri", "Tequila" };

            for (var i = 0; i < array.Length; i++)
                Console.WriteLine("Valor do Array [" + i + "]: " + array[i]);
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new[] { "L�ia", "Yuri", "Tequila" };

            for (var i = array.Length - 1; i >= 0; i--)
                Console.WriteLine("Valor do Array [" + i + "]: " + array[i]);
        }

        [TestMethod]
        public void Array_Foreach_Test()
        {
            var array = new[] { "L�ia", "Yuri", "Tequila" };

            foreach (var item in array)
                Console.WriteLine("Valor do Array: " + item);
            //Console.WriteLine(item);
        }

        [TestMethod]
        public void List_Foreach_Test()
        {
            // var array = new[] { "L�ia", "Yuri", "Tequila" };
            var lista = new List<string> { "L�ia", "Yuri", "Tequila" };
            lista.Add("Xyz");
            lista.Remove("Yuri");

            foreach (var item in lista)
                Console.WriteLine("Valor da Lista: " + item);
        }

        [TestMethod]
        public void Dictionary_Test()
        {
            // var lista = new List<string> { "L�ia", "Yuri", "Tequila" };
            var dic = new Dictionary<int, string>();
            dic.Add(1, "L�ia");
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
                mensagem = $"{numero} � par";
            else
                mensagem = $"{numero} � impar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void If_Inline_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;

            var mensagem = numero % 2 == 0
                ? $"{numero} � par"
                : $"{numero} � impar";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Else_If_Test()
        {
            var hoje = DateTime.Today;

            string mensagem;

            if (hoje.DayOfWeek == DayOfWeek.Sunday)
                mensagem = "Hoje � Domingo";
            else if (hoje.DayOfWeek == DayOfWeek.Monday)
                mensagem = "Hoje � Segunda :(";
            else if (hoje.DayOfWeek == DayOfWeek.Tuesday)
                mensagem = "Hoje � Ter�a";
            else if (hoje.DayOfWeek == DayOfWeek.Wednesday)
                mensagem = "Hoje � Quarta";
            else if (hoje.DayOfWeek == DayOfWeek.Thursday)
                mensagem = "Hoje � Quinta";
            else if (hoje.DayOfWeek == DayOfWeek.Friday)
                mensagem = "Sextou!";
            else
                mensagem = "� S�bado! :)";

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
                    mensagem = "Hoje � Domingo";
                    break;
                case DayOfWeek.Monday:
                    mensagem = "Hoje � Segunda :(";
                    break;
                case DayOfWeek.Tuesday:
                    mensagem = "Hoje � Ter�a";
                    break;
                case DayOfWeek.Wednesday:
                    mensagem = "Hoje � Quarta";
                    break;
                case DayOfWeek.Thursday:
                    mensagem = "Hoje � Quinta";
                    break;
                case DayOfWeek.Friday:
                    mensagem = "Sextou! :)";
                    break;
                default:
                    mensagem = "� S�bado! :)";
                    break;
            }

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Exception_Test()
        {
            try // try quer dizer tentar executar
            {
                Cachorro cachorro = null;
                if (cachorro == null)
                    throw new Exception("O cachorro n�o foi instanciado!");   // throw quer dizer lan�ar  

                cachorro.Validar();

                var x = 10;
                var y = 0;
                var resultado = x / y;
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de Divis�o por zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
            }
            finally
            {
                Console.WriteLine("Fim do Teste!");
            }
        }

        [TestMethod]
        public void Cachorro_Associacao_Dono_Test()
        {
            var alessandro = new Dono
            {
                Nome = "Alessandro",
                Email = "alesandro@gemmap.com.br",
                Telefone = "(14) 3332-3232 - Ramal 236"
            };

            var leia = new Cachorro
            {
                Nome = "L�ia",
                Dono = alessandro
            };

            Console.WriteLine("Nome do dono: " + leia.Dono.Nome);
            Assert.AreEqual("Alessandro", leia.Dono.Nome);
        }


        public class ClasseFilha2 : MinhaClasse
        {
            public void MetodoFilho2()
            {
                this.MeuMetodo();
            }
        }
    }
}
