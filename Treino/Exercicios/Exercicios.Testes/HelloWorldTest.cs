using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Testes
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem;
            
            mensagem = HelloWorld.SayHello();

            Assert.AreEqual("Hello World!!!", mensagem);

            Console.WriteLine(mensagem);
        }
    }
}
