using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();

            //Classe Assert usada para realizar testes de validacao.
            //A mensagem sera testada para ver se retorna "HelloWorld".
            Assert.AreEqual("HelloWorld", mensagem);

            Console.WriteLine(mensagem);
        }
    }
}
