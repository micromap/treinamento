using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System;
using System.Reflection.PortableExecutable;

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

        /*
         Considerando que a Léia pese 1Kg e come 5% do seu peso em ração,
         Implemente o metodo "Quanto devo comer" para passar nesse Teste.
         */

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            int peso = 1;
            Cachorro leia = new Cachorro();
            String quantoDevoComer = leia.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 50g por dia", quantoDevoComer);

        }
        
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
           
            int peso = 30;           
            Cachorro tequila = new Cachorro();
            String quantoDevoComer= tequila.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            int peso = 15;           
            Cachorro yuri = new Cachorro();
            String quantoDevoComer = yuri.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();
            Console.WriteLine(nome);
            Assert.AreEqual("Yuri",nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            Cachorro leia= new Cachorro();

            leia.SetSexo("Fêmea");
            string sexo = leia.GetSexo();
            Console.WriteLine(sexo);
            Assert.AreEqual("Fêmea", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Teste()
        {
            Cachorro tequila = new Cachorro();

           tequila.SetRaca("Labrador");
            string raca = tequila.GetRaca();
            Console.WriteLine(raca);
            Assert.AreEqual("Labrador", raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPorte("Médio");
            string porte = yuri.GetPorte();
            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Teste()
        {
            int idade_cao = 4;
            Cachorro tequila = new Cachorro();

            tequila.SetIdade(idade_cao);
            int idade = tequila.GetIdade();
            Console.WriteLine(idade);
            Assert.AreEqual(idade_cao, idade);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            double peso_cao = -1.2;
            Cachorro leia = new Cachorro();

            leia.SetPeso(peso_cao);
            double peso = leia.GetPeso();
            Console.WriteLine(peso);
            Assert.AreEqual(0, peso);
        }

    }
}
