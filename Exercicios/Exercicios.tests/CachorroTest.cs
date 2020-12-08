﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios.domain;
using System;

namespace Exercicios.tests
{
    [TestClass]
    public class CachorroTest
    {
        private Dono silvia;

        [TestMethod]
        public void Cachorro_latir_test()
        {
            var leia = new Cachorro();
            var latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("AU! AU! AU!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);

        }

        /* criar metodos para os cachorros Tequila */
        [TestMethod]
        public void Tequila_QuantoDevoComer_test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);

        }

        /* criar metodos para os cachorros Yuri */
        [TestMethod]
        public void Yuri_QuantoDevoComer_test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var yuri = new Cachorro();

            yuri.Peso = -1.2;
            var peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
            var yuri = new Cachorro();

            yuri.Peso = null;
            var peso = yuri.Peso;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Associacao_Raca_Test()
        {
            var labrador = new Raca { Nome = "labrador" };
            var tequila = new Cachorro
            {
                Nome = "Tequila",
                Raca = labrador
            };

            Console.WriteLine(tequila.Raca.Nome) ;

            Assert.AreEqual("labrador", tequila.Raca.Nome);
        }

        [TestMethod]
        public void Cachorro_Associacao_Dono_test()
        {
            var silvia = new Dono
            {
                Nome = "Silvia",
                Email = "silvia@teste.com",
                Telefone = "11111"
            };

            var leia = new Cachorro
            {
                Nome = "Léia",
                Dono = silvia
            };

            Console.WriteLine(leia.Dono.Nome);
            Assert.AreEqual("Silvia", leia.Dono.Nome);
        }

        [TestMethod]
        public void Cachorro_Enum_Sexo_test()
        {
            var cachorro = new Cachorro
            {
                Nome = "Léia",
                Sexo = Sexo.femea
            };

            Console.WriteLine(cachorro.Sexo);
            Assert.AreEqual(Sexo.femea, cachorro.Sexo);
        }

        [TestMethod]
        public void Cachorro_Enum_Raca_Porte_Test()
        {
            var york = new Raca
            {
                Nome = "Yorkshire",
                Porte = Porte.Pequeno
            };

            var leia = new Cachorro
            {
                Nome = "Léia",
                Raca = york
            };

            Assert.AreEqual(Porte.Pequeno, leia.Raca.Porte);

            Console.WriteLine(leia.Raca.Porte);

        }

    }
}
