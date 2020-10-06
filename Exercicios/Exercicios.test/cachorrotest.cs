using Exercicios.domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.test
{
  
    [TestClass]
        public class Cachorrotest
    {
         [TestMethod]
        public void cachorro_latir_test()
        {
            Cachorro leia;
            string latido = leia.Latir(); 


            Console.WriteLine(latido);
            
            Assert.AreEqual("Au, AU!", latido);            

         }
        // Considerando que a Léia pesa 1kg,
        // e come 5% do seu peso de ração,
        // implemente o método "quanto devo comer"
        // para passar neste teste

        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Devo Comer : 50", quantoDevoComer);
        }

     }
}
