using System;
using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios.Tests
{
    [TestClass]
    public class GatoTest
    {
        [TestMethod]
        public void Gato_Miar_Test()
        {
            var vesgo = new Gato();
            var miado = vesgo.Miar(3);

            Console.WriteLine(miado);
            Assert.AreEqual("Miau! Miau! Miau!", miado);
        }

        [TestMethod]
        public void Gato_Validar_Test()
        {
            try
            {
                var gato = new Gato();
                gato.Nome = "";
          
                gato.Validar();
                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do Pet é Obrigatório!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Vesgo_QuantoDevoComer_Test()
        {
            var vesgo = new Gato { Peso = 3 };
            var quantoDevoComer = vesgo.QuantoDevoComer();

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 3kg, devo comer 30g por dia.", quantoDevoComer);
        }
    }
}
