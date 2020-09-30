using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void Test_SayHello()
        {
            var mensagem = HelloWorld.SayHello();
            Console.WriteLine(mensagem);
            Assert.AreEqual("Hello World - GitHub Desktop! (nova alteração)", mensagem);
        }
    }
}
