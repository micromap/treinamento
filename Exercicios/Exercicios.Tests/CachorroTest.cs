using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios.Tests
{   
    //Classe de teste, da classe Cachorro()
    [TestClass]
   public  class CachorroTest
    {
        // Classe de teste Latir(), testa quantidade de latidos do cachorro com variavel short... 
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            var leia = new Cachorro();
            var latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au!", latido);
        }
        
        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }
        
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }


        //Criando metodos de teste, para testar os atributos da classe Cachorro()
        [TestMethod]
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = 10.25;
            var pesoKg = leia.PesoKg;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(10.25, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = -1.0;
            var pesoKg = leia.PesoKg;

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        public void Cachorro_Peso_Deve_Aceitar_Null_Test()
        {
            var leia = new Cachorro();

            leia.PesoKg = null;
            var peso = leia.PesoKg;

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }
    }
}
