using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string mensage  = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", mensage);

            Console.WriteLine("");

        }

        [TestMethod]
        public void TiposPrimitivos_e_ComplexosTest() 
        { 
            // Tipos Primitivos
            string mensagem = "Hello World";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            // Tipos Complexos
            Cachorro cachorro = new Cachorro();
            Console.WriteLine(cachorro);
        }

        [TestMethod]
        public void ConversaoImplicitaTest()
        {
            int inteiro = 10;
            double valor = inteiro;

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro,valor);
        }


        [TestMethod]
        public void ConversaoExplicitaTest()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);
        }

        [TestMethod]
        public void TipoValorTest()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
            Assert.AreEqual(10,valor);
        }

        [TestMethod]
        public void TiposReferenciaTest()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Léia";

            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.Nome;

            Console.WriteLine(nomeCachorro);
            Assert.AreEqual("Tequila",nomeCachorro);
        }

        [TestMethod]
        public void Igualdade_entre_tipos_ValoresTest()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1,valor2);

        }

        [TestMethod]
        public void Desigualdade_entre_tipos_ReferenciasTest()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Léia";

            Assert.AreNotEqual(cachorro1, cachorro2);

        }

        [TestMethod]
        public void Igualdade_entre_tipos_ReferenciasTest()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_ExplicitosTest()
        {
            string nome = "Léia";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_ImplicitosTest()
        {
            var nome = "Léia";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }
        [TestMethod]
        public void Declara_Sem_InicializarTest()
        {
            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

            // Não podemos declarar variaveis do tipo implicitas sem atribuis valor 
            //string nome;
            // nome = "Léia";
            //Assert.AreEqual(typeof(string), nome.GetType()); 
        }

        [TestMethod]
        public void Tipos_Que_aceitam_NullTest()
        {
            string nome = null;
            Cachorro cachorro = null;

            Assert.AreEqual(null,nome);
            Assert.AreEqual(null,cachorro);

            //int idade = null;
            //double peso = null;
            //Assert.AreEqual(null, idade);
            //Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Tipos_NulaveisTest()
        {
            int? idade = null;
            double? peso = null;
            bool? vacinado = null;
            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
        }
    }
}
