using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios.Tests
{   
    //Classe de teste, da classe Cachorro()
    [TestClass]
   public  class CachorroTest
    {
        // Classe de teste Latir(), testa quantidade de latidos do cachorro com variavel short... 
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

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }
        
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }


        //Criando metodos de teste, para testar os atributos da classe Cachorro()4
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            var leia = new Cachorro();
            var yuri = new Cachorro();

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
            var leia = new Cachorro();

            leia.SetSexo("Femea");
            var sexo = leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Femea", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            var leia = new Cachorro();

            leia.SetRaca("Buldogue");
            var raca = leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Buldogue", raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            var leia = new Cachorro();

            leia.SetPorte("Pequeno");
            var porte = leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Test()
        {
            var leia = new Cachorro();

            leia.SetIdade(4);
            var idade = leia.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(4, idade);
        }

        [TestMethod]
        public void Cachorro_Set_Get_PesoKg_Test()
        {
            var leia = new Cachorro();

            leia.SetPesoKg(10.25);
            var pesoKg = leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(10.25, pesoKg);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            var leia = new Cachorro();

            leia.SetPesoKg(-1.0);
            var pesoKg = leia.GetPesoKg();

            Console.WriteLine(pesoKg);
            Assert.AreEqual(null, pesoKg);
        }

        public void Cachorro_Peso_Deve_Aceitar_Null_Test()
        {
            var leia = new Cachorro();

            leia.SetPesoKg(null);
            var peso = leia.GetPesoKg();

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }
        // Criando metodo com atributo boolean
        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Test()
        {
            var leia = new Cachorro();

            leia.SetVacinado(true);
            bool vacinado = leia.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }

    }
}
