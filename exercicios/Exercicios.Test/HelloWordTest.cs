using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Test
{
    [TestClass]
    public class HelloWordTest
    {
        [TestMethod]
        public void SayHelloTest()
        {
            string Message = HelloWorld.SayHello();
            
            Assert.AreEqual("Hello World", Message);

            Console.WriteLine(Message);
        }
    }
}
