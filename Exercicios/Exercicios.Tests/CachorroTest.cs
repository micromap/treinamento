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
            int q_latidos = 3;
            Cachorro leia = new Cachorro();
            string latido = leia.Latir((short)q_latidos);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! ", latido);
        }

     

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
            String nome_cao = "Yuri";
            Cachorro yuri = new Cachorro();

            yuri.SetNome(nome_cao);
            string nome = yuri.GetNome();
            Console.WriteLine(nome);
            Assert.AreEqual(nome_cao, nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            String sexo_cao = "Fêmea";
            Cachorro leia= new Cachorro();

            leia.SetSexo(sexo_cao);
            string sexo = leia.GetSexo();
            Console.WriteLine(sexo);
            Assert.AreEqual(sexo_cao, sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Teste()
        {
            String raca_cao = "Labrador";
            Cachorro tequila = new Cachorro();

           tequila.SetRaca(raca_cao);
            string raca = tequila.GetRaca();
            Console.WriteLine(raca);
            Assert.AreEqual(raca_cao, raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Teste()
        {
            String porte_cao = "Médio";
            Cachorro yuri = new Cachorro();

            yuri.SetPorte(porte_cao);
            string porte = yuri.GetPorte();
            Console.WriteLine(porte);
            Assert.AreEqual(porte_cao, porte);
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
        public void Cachorro_Peso_Teste()
        {
            double peso_cao = 1.2;
            Cachorro leia = new Cachorro();

            leia.SetPeso(peso_cao);
            double peso = leia.GetPeso();
            Console.WriteLine(peso);
            Assert.AreEqual(peso_cao, peso);
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

        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            bool vacinado = true;
            Cachorro tequila = new Cachorro();

            tequila.SetVacinado(vacinado);
            vacinado = tequila.GetVacinado();
            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

    }

        
}
