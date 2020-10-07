using Exercicios.Domain;
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
            string latido = leia.Latir(3);

            Console.WriteLine(latido);
            Assert.AreEqual("Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Sexo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetSexo("Masculino");
            string sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Masculino", sexo);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Raca_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetRaca("Bulldog");
            string raca = yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Bulldog", raca);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPorte("Pequeno");
            string porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Idade_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetIdade(2);
            int idade = yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(2, idade);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Vacinado_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetVacinado(true);
            bool vacinado = yuri.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Peso_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(7);
            double pesoKg = yuri.GetPeso();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(7, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(-1.2);
            double pesoKg = yuri.GetPeso();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(0, pesoKg);
        }
    }
}
