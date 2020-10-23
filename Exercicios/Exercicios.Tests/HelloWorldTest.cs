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
            string mens = HelloWorld.SayHello();
            Assert.AreEqual("Hello World", mens);
            Console.WriteLine(mens);
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

            // Tipos Complexos
            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);
        }

        [TestMethod]
        public void Conversao_Implicita_Teste()
        {
            int inteiro = 10;
            double valor = inteiro;

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }

        [TestMethod]
        public void Conversao_Explicita_Teste()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(valor);
            Assert.AreNotEqual(inteiro, valor);
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
            cachorro.SetNome("Léia");

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.GetNome();

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
            cachorro1.SetNome("Léia");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.SetNome("Léia");

            // Assert.AreEqual(cachorro1, cachorro2);
            Assert.AreNotEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Léia");

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_Explicitos_Test()
        {
            string nome = "Léia";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(peso);
            Console.WriteLine(cachorro);

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

        }

        [TestMethod]
        public void Tipos_Implicitos_Test()
        {
            var nome = "Léia";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(peso);
            Console.WriteLine(cachorro);

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

        }

        [TestMethod]
        public void Declarar_Sem_Inicializar_Test()
        {
            // Não se pode declarar variáveis Implicitas sem atribuir o Valor
            // var nome;
            // nome = "Léia";
            // Assert.AreEqual(typeof(string), nome.GetType());

            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_Que_Aceitam_Null_Test()
        {
            string nome = null;
            Cachorro cachorro = null;

            Assert.AreEqual(null, nome);
            Assert.AreEqual(null, cachorro);

            // Não aceitam NULL
            // int idade = null;
            // double peso = null;

            // Não aceitam NULL, mas posso fazer com que ele aceite usando o "?", mas utilizar isso em casos muitos específicos
            int? idade = null;
            double? peso = null;
            bool? vacinado = null;

            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
        }
    }
}
