using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.tests
{
    [TestClass]
    public class HelloWordTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", mensagem);
            Console.WriteLine(mensagem);
        }
    }
}
