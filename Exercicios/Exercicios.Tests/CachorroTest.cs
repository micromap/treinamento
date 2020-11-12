using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.latir(6);

            Console.WriteLine(latido);
            
            Assert.AreEqual("Au! Au! Au! Au! Au! Au!", latido);
               
        }

         [TestMethod]       
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1 Kg, devo comer 50 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30 Kg, devo comer 1500 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15 Kg, devo comer 750 g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("yuri");
            string nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("yuri", nome);
        }
        [TestMethod]
        public void Cachorro_Get_Set_Sexo_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetSexo("macho");
            string sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("macho", sexo);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Raca_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetRaca("Buldog Frânces");
            string raca = yuri.GetRaca();
           
            Console.WriteLine(raca);
            Assert.AreEqual("Buldog Frânces", raca);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Porte_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPorte("Médio");
            string porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Idade_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetIdade(2);
            int idade = yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(2, idade);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Peso_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(15.01);
            double peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(15.01, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(-15.01);
            double peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(0, peso);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Vacinado_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetVacinado(true);
            bool vacinado = yuri.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

    }
}
