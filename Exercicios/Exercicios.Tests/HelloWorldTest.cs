using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

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
            //Tipos Primitivos
            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;
            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);


            //Tipos Complexos

            Gato leia = new Gato();
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

            Console.WriteLine(valor);
            Assert.AreNotEqual(valor,inteiro);
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
            Gato cachorro = new Gato();
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

            Assert.AreEqual(valor1,valor2);
        }

        [TestMethod]
        public void Desigualdade_entre_Tipos_de_Referencia_Test()
        {
            Gato cachorro1 = new Gato();
            cachorro1.Nome="Léia";

            Gato cachorro2 = new Gato();
            cachorro2.Nome="Léia";

            Assert.AreNotEqual(cachorro1,cachorro2);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Gato cachorro1 = new Gato();
            cachorro1.Nome = "Léia";

            Gato cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_Explicitos_Test()
        {
            string nome = "Léia";
            int idade = 1;
            double peso = 1.3;
            Gato cachorro = new Gato();
            

            Assert.AreEqual(typeof(string),nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Gato), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_Implicitos_Test()
        {
            var nome = "Léia";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Gato();


            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Gato), cachorro.GetType());
        }

        [TestMethod]
        public void Declarar_Sem_inicializar_Test()
        {
            Gato cachorro;
            cachorro = new Gato();

            Assert.AreEqual(typeof(Gato), cachorro.GetType());

          /* Não podemos declarar variaveis implicitas sem atribuir um valor
           * 
            var nome;
            nome = "Léia";
            Assert.AreEqual(typeof(String), nome.GetType());
          */

        }

        [TestMethod]
        public void Tipos_Que_Aceitam_Null_Test()
        {
            string nome = null;
            Gato cachorro = null;


            Assert.AreEqual(null, nome);
            Assert.AreEqual(null, cachorro);

            /*Int e double não são Nullaveis assim como variaveis implicitas*/

            //   int idade = null;
            //   double peso = null;
            //Assert.AreEqual(null, idade);
            //Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Tipos_Nullaveis_Test()
        {
         

            int? idade = null;
            double? peso = null;
            bool? vacinado = null;

            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
        }

        [TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
           // obj.MeuMetodo();
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
            var data = new DateTime(2020, 10, 27);
            Console.WriteLine(data);

            var dataHora = new DateTime(2020, 10, 27, 11, 23, 0);
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Convertendo_de_String_Test()
        {
            var data = DateTime.Parse("27/10/2020");
            Console.WriteLine(data);

            var dataHora = DateTime.Parse("27/10/2020 11:29");
            Console.WriteLine(dataHora);
        }

        [TestMethod]
        public void DateTime_Quantidade_Dias_Mes_Test()
        {
            var diaMes = DateTime.DaysInMonth(2020,10);
            Console.WriteLine(diaMes);

            var ultimoDiaMes = new DateTime(2020, 10, diaMes);
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
            Console.WriteLine(agora.ToString("dd/MM/yyyy hh:mm"));
            Console.WriteLine(agora.ToString("MMMM/yy"));
            Console.WriteLine(agora.ToString("MM/yyyy"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var data1 = new DateTime(2020, 10, 17, 10, 25, 12);
            var data2 = new DateTime(2020, 10, 18, 18, 10, 23);

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
            var array = new String[] { "Léia", "Yuri", "Tequila" };
            var i = 0;
            do
            {
            /*  Console.WriteLine(array[i]);
                  i++;*/
                Console.WriteLine(array[i++]);//primeiro pega o array depois faz o incremento
             // Console.WriteLine(array[++i]);//primeiro faz o incremento e depois pega o array
            } while (i<array.Length);

        }

        [TestMethod]
        public void Array_For_Test()
        {
            var array = new String[] { "Léia", "Yuri", "Tequila" };
            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new [] { "Léia", "Yuri", "Tequila" };
            for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        [TestMethod]
        public void Array_Forech_Test()
        {
            var array = new[] { "Léia", "Yuri", "Tequila" };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void Array_List_Foreach_Test()
        {
            var lista = new List<String> { "Léia", "Yuri", "Tequila" };
            lista.Add("Xyz");
            lista.Remove("Yuri");

            foreach (var item in lista)
                Console.WriteLine(item);
        }

        [TestMethod]
        public void Dictionary_Test()
        {
            var dic = new Dictionary<int, String>();
            dic.Add(1, "Léia");
            dic.Add(2, "Yuri");
            dic.Add(3, "Tequila");

           // dic.Remove(2);

            foreach (var item in dic)
                Console.WriteLine($"{item.Key}: {item.Value}");


        }

        [TestMethod]
        public void If_Else_Test()
        {
            var agora = DateTime.Now;
            var numero = agora.Second;
            String mensagem;

            if (numero %2 == 0)
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

            string mensagem = numero % 2 == 0 ?$"{numero} é par": $"{numero} é impar";
            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Else_If_Test()
        {
            var hoje = DateTime.Today;

            String mensagem;
            if (hoje.DayOfWeek == DayOfWeek.Sunday)
                mensagem = "Hoje é Domingo!";
            else if (hoje.DayOfWeek == DayOfWeek.Monday)
                mensagem = "Hoje é Segunda";
            else if (hoje.DayOfWeek == DayOfWeek.Tuesday)
                mensagem = "Hoje é Terça";
            else if (hoje.DayOfWeek == DayOfWeek.Wednesday)
                mensagem = "Hoje é Quarta";
            else if (hoje.DayOfWeek == DayOfWeek.Thursday)
                mensagem = "Hoje é Quinta";
            else if (hoje.DayOfWeek == DayOfWeek.Friday)
                mensagem = "Hoje é Sexta";
            else
                mensagem = "Hoje é Sabado!";

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Switch_Case_Test()
        {
            var hoje = DateTime.Today;

            String mensagem;
            switch (hoje.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    mensagem = "Hoje é Domingo!";
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
                    mensagem = "Hoje é Sabado!";
                    break;
            }

            Console.WriteLine(mensagem);
        }

        [TestMethod]
        public void Exception_Test()
        {
            try
            {
                Gato cachorro = null;
                if (cachorro == null)
                    throw new Exception("O cachorro não foi instanciado!");
            //  var mensagens = cachorro.Validar();
                var x = 10;
                var y = 0;

                var resultado = x / y;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de Divisão por Zero!");
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

        [TestMethod]
        public void SystemIO_CreatedDirectory_Test()
        {
            Directory.CreateDirectory("C:\\Aula030");
            Directory.CreateDirectory("C:\\Aula030\\SubPasta");
        }

        [TestMethod]
        public void SystemIO_File_Create_Test()
        {
            File.WriteAllText("C:\\Aula030\\hello.txt","Hello World!");
        }

        [TestMethod]
        public void SystemIO_GetFileSystemEntries_Test()
        {
            var lista = Directory.GetFileSystemEntries("C:\\Aula030\\");
            foreach (var item in lista)
                Console.WriteLine(item);
        }

        [TestMethod]
        public void SystemIO_File_Read_Txt_Test()
        {
            var conteudo = File.ReadAllText("C:\\Aula030\\hello.txt");
            Console.WriteLine(conteudo);
        }

        [TestMethod]
        public void Async_Await_Tarefa_Test()
        {
            var retorno1 = HelloWorld.Tarefa("Um",5);
            Console.WriteLine(retorno1);

            var retorno2 = HelloWorld.Tarefa("Dois", 3);
            Console.WriteLine(retorno2);
        }

        [TestMethod]
        public async Task Async_Await_TarefaAsync_1_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            Console.WriteLine("Código que pode ser executado, independente do retorno da tarefa1");
            string resultado = await tarefa1;
            Console.WriteLine(resultado);
        }
        [TestMethod]
        public async Task Async_Await_TarefaAsync_2_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            Task<string> tarefa2 = HelloWorld.TarefaAsync("Dois", 5);

            string resultado1 = await tarefa1;
            Console.WriteLine(resultado1);

            string resultado2 = await tarefa2;
            Console.WriteLine(resultado2);

        }

        [TestMethod]
        public async Task Async_Await_TarefaAsync_3_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            Task<string> tarefa2 = HelloWorld.TarefaAsync("Dois", 10);

            string resultado1 = await tarefa1;
            Console.WriteLine(resultado1);

            Task<string> tarefa3 = HelloWorld.TarefaAsync("Três", 5);

            string resultado2 = await tarefa2;
            Console.WriteLine(resultado2);

            string resultado3 = await tarefa3;
            Console.WriteLine(resultado3);

        }
    }



    [TestClass]
    public class ClasseFilha2 : MinhaClasse
    {
        public void MetodoFilho2()
        {
            this.MeuMetodo();
        }
    }
}
