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
    }
}
