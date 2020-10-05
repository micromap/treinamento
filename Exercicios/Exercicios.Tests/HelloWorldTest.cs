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

            Assert.AreEqual("Hello World!", mensagem);

            Console.WriteLine(mensagem);
       }
        [TestMethod]
        public void Conversao_Implicita_Test()
        {
            int inteiro = 10;
            double valor = inteiro;   //converte inteiro para double

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }
        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 1.2;
            int inteiro = (int)valor;    //cast explicit

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);  //primeiro resultado esperado, depois o que é pra comparar
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
        }
    }

}
