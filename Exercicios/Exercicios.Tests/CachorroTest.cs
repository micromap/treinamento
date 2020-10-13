using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios.Tests
{   
    //Classe de teste, da classe Cachorro()
    [TestClass]
   public  class CachorroTest
    {
        //Primeiro método de teste da classe Cachorro()
       /* #region METODO TESTE LATIR()
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }
        #endregion
       */

        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au!", latido);
        }
        
        // Considerando que a Léia pesa 1Kg,
        // e come 5% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse Teste, e depois crie esse metodo para testar com outros cachorros
        #region EXERCICIO AULA 13

        #region LEIA QUANTO DEVE COMER
        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }
        #endregion

        #region TEQUILA QUANTO DEVE COMER
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }
        #endregion

        #region YURI QUANTO DEVO COMER
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }
        #endregion

        #endregion

        //Criando metodos de teste, para testar os atributos da classe Cachorro()
        #region EXERCICIO AULA 14
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro leia = new Cachorro();
            Cachorro yuri = new Cachorro();

            leia.SetNome("Leia");
            var nome = leia.GetNome();


            yuri.SetNome("Yuri");
            var nome2 = yuri.GetNome();

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
            var sexo = leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Femea", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetRaca("Buldogue");
            var raca = leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Buldogue", raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPorte("Pequeno");
            var porte = leia.GetPorte();

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

            leia.SetPesoKg(10.25);
            double pesoKg = leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(10.25, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetPesoKg(-1.0);
            double pesoKg = leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(0, pesoKg);
        }
        #endregion

        #region EXERCICIO AULA 15
        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Test()
        {
            Cachorro leia = new Cachorro();

            leia.SetVacinado(true);
            bool vacinado = leia.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }
        #endregion
    }
}
