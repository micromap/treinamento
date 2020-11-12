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
            double peso  = 1.2;
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
            cachorro.SetNome("Léia");

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.GetNome();

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
            cachorro1.SetNome("Leia");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.SetNome("Leia");

            Assert.AreNotEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Igualdade_Entre_Tipo_de_Referencias_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Leia");

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }
    }
}
