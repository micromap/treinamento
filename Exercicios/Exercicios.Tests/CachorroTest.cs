using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            //Cachorro leia = new Cachorro(); declaração explícita
            //string latido = leia.Latir(6); declaração explícita

            // declaração Implícita
            var leia = new Cachorro(); 
            var latido = leia.Latir(6);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au! Au!", latido);

        }

                
        // Considerando que a Leia pesa 1Kg
        // e come 5% do seu peso de ração,
        // Implemente o método "QuantoDevoComer"
        // para passar nesse teste

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1Kg, devo comer 50g por dia", quantoDevoComer);
        }

        // Criar os métodos de teste, para a Tequila e para o Yuri
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg, devo comer 1500g por dia", quantoDevoComer);

        }
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15Kg, devo comer 750g por dia", quantoDevoComer);

        }
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            var yuri = new Cachorro();
            yuri.SetNome("Yuri");
            var nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);

        }
        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            var yuri = new Cachorro();
            yuri.SetSexo("Macho");
            var sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Macho", sexo);

        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Teste()
        {
            var tequila = new Cachorro();
            tequila.SetRaca("Labrador");
            var raca = tequila.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Labrador", raca);

        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Teste()
        {
            var leia = new Cachorro();
            leia.SetPorte("Pequeno");
            var porte = leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);

        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Teste()
        {
            var tequila = new Cachorro();
            tequila.SetIdade(4);
            var idade = tequila.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);

        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var leia = new Cachorro();
            leia.SetPeso(1.2);
            var peso = leia.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(1.2, peso);

        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var leia = new Cachorro();
            leia.SetPeso(-1.2);
            var peso = leia.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(0, peso);

        }

        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            var leia = new Cachorro();
            leia.SetVacinado(true);
            var vacinado = leia.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);

        }
    }
}

