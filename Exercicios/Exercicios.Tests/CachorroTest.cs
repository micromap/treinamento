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
            
            var leia = new Cachorro();
            var latido = leia.Latir(5);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var peso = 1;
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 50g por dia", quantoDevoComer);

        }
        
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
           
            var peso = 30;           
            var tequila = new Cachorro();
            var quantoDevoComer= tequila.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var peso = 15;           
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(peso);
            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho " + peso + "Kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            var nome_cao = "Yuri";
            var yuri = new Cachorro();

            yuri.SetNome(nome_cao);
            var nome = yuri.GetNome();
            Console.WriteLine(nome);
            Assert.AreEqual(nome_cao, nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            var sexo_cao = "Fêmea";
            var leia= new Cachorro();

            leia.SetSexo(sexo_cao);
            var sexo = leia.GetSexo();
            Console.WriteLine(sexo);
            Assert.AreEqual(sexo_cao, sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Teste()
        {
            var raca_cao = "Labrador";
            var tequila = new Cachorro();

           tequila.SetRaca(raca_cao);
            var raca = tequila.GetRaca();
            Console.WriteLine(raca);
            Assert.AreEqual(raca_cao, raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Teste()
        {
            var porte_cao = "Médio";
            var yuri = new Cachorro();

            yuri.SetPorte(porte_cao);
            var porte = yuri.GetPorte();
            Console.WriteLine(porte);
            Assert.AreEqual(porte_cao, porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Teste()
        {
            var idade_cao = 4;
            var tequila = new Cachorro();

            tequila.SetIdade(idade_cao);
            var idade = tequila.GetIdade();
            Console.WriteLine(idade);
            Assert.AreEqual(idade_cao, idade);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var peso_cao = 1.2;
            var leia = new Cachorro();

            leia.SetPeso(peso_cao);
            var peso = leia.GetPeso();
            Console.WriteLine(peso);
            Assert.AreEqual(peso_cao, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var peso_cao = -1.2;
            var leia = new Cachorro();

            leia.SetPeso(peso_cao);
            var peso = leia.GetPeso();
            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            var vacinado = true;
            var tequila = new Cachorro();

            tequila.SetVacinado(vacinado);
            vacinado = tequila.GetVacinado();
            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
           
            var leia = new Cachorro();
            leia.SetPeso(null);
            
            var peso = leia.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

    }

        
}
