using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios.Tests
{   
    //Classe de teste, da classe Cachorro()
    [TestClass]
   public  class CachorroTest
    {   
        //Metodo de teste 
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        // Considerando que a Léia pesa 1Kg,
        // e come 5% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse Teste

        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

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


        //Testando mais de um retorno
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro leia = new Cachorro();
            Cachorro yuri = new Cachorro();

            leia.SetNome("Leia");
            string nome = leia.GetNome();


            yuri.SetNome("Yuri");
            string nome2 = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Leia", nome);

            Console.WriteLine(nome2);
            Assert.AreEqual("Yuri", nome2);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetSexo("Femea");
            String sexo = leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Femea", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetRaca("Buldogue");
            string raca = leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Buldogue", raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPorte("Pequeno");
            string porte = leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetIdade(4);
            int idade = leia.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);
        }

        [TestMethod]
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPesoKg(10.20);
            double pesoKg = leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(10.20, pesoKg);
        }
    }
}
