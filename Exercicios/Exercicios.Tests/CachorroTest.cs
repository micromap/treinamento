﻿using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]

        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        /*      Considerando que a Léia pesa 1 kg,
                e come 5% do seu peso de ração,
                implemente o Método QuantoDevoComer
                para passar nesse teste
         */

        [TestMethod]

        public  void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg devo comer 50g por dia !", quantoDevoComer);
        }

        // Criar os métodos de teste para Tequila e Yuri
    }
}