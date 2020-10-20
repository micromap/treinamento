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
            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia.", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Nome_Test()
        {
            var yuri = new Cachorro();

            yuri.SetNome("Yuri");
            var nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Sexo_Test()
        {
            var yuri = new Cachorro();

            yuri.SetSexo("Masculino");
            var sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Masculino", sexo);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Raca_Test()
        {
            var yuri = new Cachorro();

            yuri.SetRaca("Bulldog");
            var raca = yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Bulldog", raca);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Porte_Test()
        {
            var yuri = new Cachorro();

            yuri.SetPorte("Pequeno");
            var porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Idade_Test()
        {
            var yuri = new Cachorro();

            yuri.SetIdade(2);
            var idade = yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(2, idade);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Vacinado_Test()
        {
            var yuri = new Cachorro();

            yuri.SetVacinado(true);
            var vacinado = yuri.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

        [TestMethod]
        public void Cachorro_Get_Set_Peso_Test()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(7);
            var pesoKg = yuri.GetPeso();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(7, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(-1.2);
            var pesoKg = yuri.GetPeso();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Test()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(null);
            var pesoKg = yuri.GetPeso();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }
    }
}
