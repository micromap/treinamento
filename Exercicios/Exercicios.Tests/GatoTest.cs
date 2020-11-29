using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;
using System.Reflection.PortableExecutable;

namespace Exercicios.Tests
{
    [TestClass]
    public class GatoTest
    {

        [TestMethod]
        public void Gato_Miar_Test()
        {
            
            var gato1 = new Gato();
            var miado = gato1.Miar(3);

            Console.WriteLine(miado);

            Assert.AreEqual("Miau! Miau! Miau!", miado);
        }

        [TestMethod]
        public void Gato_Validar_Test()
        {
            try
            {
                var nome_gato = " ";
              

                var gato = new Cachorro()
                {
                    Nome = nome_gato,
                
                };

                gato.Validar();
                Assert.Fail();

            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Nome do pet é obrigatório!");

                Assert.AreEqual(true, ok);
                Console.WriteLine(ex.Message);
            }
        }

    }


}



