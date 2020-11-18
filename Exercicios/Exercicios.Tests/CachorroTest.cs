using System;
using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual("Como tenho 1Kg,devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 30Kg,devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);
            Assert.AreEqual("Como tenho 15Kg,devo comer 750g por dia", quantoDevoComer);
        }

        public void Leia_Cachorro_Set_Get_Nome_Test()
        {
            var Leia = new Cachorro();
            Leia.SetNome("Leia");
            var nome = Leia.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Leia", nome);
        }

        public void Tequila_Cachorro_Set_Get_Nome_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetNome("Tequila");
            var nome = Tequila.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Tequila", nome);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_Nome_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetNome("Yuri");
            var nome = Yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        public void Leia_Cachorro_Set_Get_Sexo_Test()
        {
            var Leia = new Cachorro();

            Leia.SetSexo("Fêmea");
            var sexo = Leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Fêmea", sexo);
        }

        public void Tequila_Cachorro_Set_Get_Sexo_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetSexo("Fêmea");
            var sexo = Tequila.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Fêmea", sexo);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_Sexo_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetSexo("Masculino");
            var sexo = Yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Masculino", sexo);
        }

        public void Leia_Cachorro_Set_Get_Raca_Test()
        {
            var Leia = new Cachorro();

            Leia.SetRaca("Vira Lata");
            var raca = Leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Vira Lata", raca);
        }

        public void Tequila_Cachorro_Set_Get_Raca_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetRaca("Labrador");
            var raca = Tequila.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Labrador", raca);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_Raca_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetRaca("Vira Lata");
            var raca = Yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Vira Lata", raca);
        }

        public void Leia_Cachorro_Set_Get_Porte_Test()
        {
            var Leia = new Cachorro();

            Leia.SetPorte("Médio");
            var porte = Leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        public void Tequila_Cachorro_Set_Get_Porte_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetPorte("Médio");
            var porte = Tequila.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_Porte_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetPorte("Médio");
            var porte = Yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        public void Leia_Cachorro_Set_Get_Idade_Test()
        {
            var Leia = new Cachorro();

            Leia.SetIdade(3);
            var idade = Leia.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(3, idade);
        }

        public void Tequila_Cachorro_Set_Get_Idade_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetIdade(4);
            var idade = Tequila.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_Idade_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetIdade(3);
            var idade = Yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(3, idade);
        }

        public void Leia_Cachorro_Set_Get_PesoKg_Test()
        {
            var Leia = new Cachorro();

            Leia.SetPesoKg(1.2);
            var pesoKg = Leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(1.2, pesoKg);
        }

        public void Tequila_Cachorro_Set_Get_PesoKg_Test()
        {
            var Tequila = new Cachorro();

            Tequila.SetPesoKg(5.5);
            var pesoKg = Tequila.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(5.5, pesoKg);
        }

        [TestMethod]
        public void Yuri_Cachorro_Set_Get_PesoKg_Test()
        {
            var Yuri = new Cachorro();

            Yuri.SetPesoKg(5.5);
            var pesoKg = Yuri.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(5.5, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var Leia = new Cachorro();

            Leia.SetPesoKg(-1.2);
            var pesoKg = Leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
            var leia = new Cachorro();

            leia.SetPesoKg(null);
            var peso = leia.GetPesoKg();

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            var tequila = new Cachorro();

            tequila.SetVacinado(true);
            var vacinado = tequila.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }
    }
}
