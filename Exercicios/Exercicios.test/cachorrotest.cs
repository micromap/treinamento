using Exercicios.domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.test
{

    [TestClass]
    public class Cachorrotest
    {
        private object leia;

        public Cachorrotest(object leia)
        {
            this.leia = leia;
        }

        [TestMethod]
        public void cachorro_latir_test()
        {
            var latido = Latir();


            Console.WriteLine(latido);

            Assert.AreEqual("Au, AU!", latido);

        }

        private string Latir()
        {
            throw new NotImplementedException();
        }

        //Considerando que a Léia pesa 1kg,
        // e come 5% do seu peso de ração,
        // implemente o método "quanto devo comer"
        // para passar neste teste

        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {
            string leia = null;
            int?quantoDevoComer =null;

            
            Assert.AreEqual(null,leia);
            Assert.AreEqual(null,quantoDevoComer);
        }

        [TestMethod]

        public void Cachorro_Set_Get_Nome_Test()
        {
            var leia = new Cachorro();
            leia.SetNome("Leia");
            var nome = leia.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Leia", nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_test()
        {
            var leia = new Cachorro();
            leia.SetRaca("Femea");
            var raca = leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Femea", raca);
        }

        [TestMethod]
        public void Cahorro_Set_Get_Porte_test()
        {
            var leia = new Cachorro();
            leia.SetPorte("Pequeno");
            var porte = leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Pequeno", porte);
        }
    }

}
