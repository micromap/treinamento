using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Test
{
    [TestClass]
    public class CachorroTest

    {
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            var leia = new Cachorro();
            string latido = leia.Latir(3);
            Assert.AreEqual("Au! Au! Au! ", latido);
            Console.WriteLine(latido);
        }

        /* Considerando quea Léia pesa 1KG,
         * e come 5% do seu peso em ração,
         * implemente m Método "QuantoDevoComer"
         * para passar neste teste
         */

        [TestMethod]
        public void Leia_Quanto_Devo_Comer_Test()
        {
            var leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDeveComer(1);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }
        
        [TestMethod]
        public void Tequila_Quanto_Devo_Comer_Test()
        {
            var tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDeveComer(30);
            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_Quanto_Devo_Comer_Test()
        {
            var yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDeveComer(15);
            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
            Console.WriteLine(quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_Get_Set_Nome_Teste()
        {
            var yuri = new Cachorro();
            yuri.Nome = "Yuri";
            string nome = yuri.Nome;
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Yuri_Get_Set_Sexo_Teste()
        {
            var yuri = new Cachorro();
            yuri.Sexo = "Macho";
            string nome = yuri.Sexo;
            Assert.AreEqual("Macho", nome);
        }
        
        [TestMethod]
        public void Cachorro_Nome_Obrigatorio_Teste()
        {
            var cachorro = new Cachorro();
            var message = cachorro.Valida();
            Assert.AreNotEqual("Nome do cachorro é obrigatório!", message[0]);
            Console.WriteLine(message[0]);
        }

        [TestMethod]
        public void Cachorro_Macho_Femea_Teste()
        {
            var cachorro = new Cachorro();
            Console.WriteLine("");
            
        }
      
    }
}
