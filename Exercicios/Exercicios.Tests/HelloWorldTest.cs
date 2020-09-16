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

            Assert.AreEqual("Hello Word!", mensagem);

            Console.WriteLine(mensagem);
        }
    }
}
