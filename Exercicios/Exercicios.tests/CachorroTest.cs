using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicios.domain;
using System;

namespace Exercicios.tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_latir_test()
        {
            var leia = new Cachorro();
            var latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("AU! AU! AU!", latido);
        }

        [TestMethod]
        public void Leia_QuantoDevoComer_test()
        {
            var leia = new Cachorro();
            var quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);

        }

        // criar metodos para os cachorros Tequila e Yuri

        /* criar metodos para os cachorros Tequila */
        [TestMethod]
        public void Tequila_QuantoDevoComer_test()
        {
            var tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);

        }

        /* criar metodos para os cachorros Yuri */
        [TestMethod]
        public void Yuri_QuantoDevoComer_test()
        {
            var yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Teste()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("Yuri");
            var nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetRaca("buldog");
            var raca = yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("buldog", raca);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetSexo("macho");
            var sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("macho", sexo);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetPorte("medio");
            var porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("medio", porte);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetIdade(3);
            var idade = yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(3, idade);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(15);
            var peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(15, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Nao_Pode_Ser_Negativo_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(-1.2);
            var peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Cachorro_Peso_Deve_Aceitar_Null_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetPeso(null);
            var peso = yuri.GetPeso();   

            Console.WriteLine(peso);
            Assert.AreEqual(null, peso);
        }


        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Teste()
        {
            var yuri = new Cachorro();

            yuri.SetVacinado(false);
            var vacinado = yuri.GetVacinado();

            if (vacinado)
            {
                Console.WriteLine("Já foi vacinado");
            }
            else
            {
                Console.WriteLine("Não foi vacinado");
            }    
            //Console.WriteLine(vacinado);
            //Assert.AreEqual(true, vacinado);
        }

    }
}
