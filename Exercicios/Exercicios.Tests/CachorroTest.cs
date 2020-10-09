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
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        /*      Considerando que a Léia pesa 1 kg,
                e come 5% do seu peso de ração,
                implemente o Método QuantoDevoComer
                para passar nesse teste
         */

        [TestMethod]

        public  void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        // Criar os métodos de teste para Tequila e Yuri

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Sexo_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetSexo("Fêmea");
            string sexo = leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Fêmea", sexo);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro tequila = new Cachorro();

            tequila.SetRaca("Labrador");
            string raca = tequila.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Labrador", raca);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPorte("Médio");
            string porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Idade_Test()
        {
            Cachorro tequila = new Cachorro();

            tequila.SetIdade(4);
            int idade = tequila.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Peso_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPeso(1.2);
            double peso = leia.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(1.2, peso);
        }

        [TestMethod]

        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPeso(-1.2);
            double peso = leia.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(0, peso);
        }
    }
}
