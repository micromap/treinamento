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
            string mensagem;
            mensagem = HelloWorld.SayHello();

            Assert.AreEqual("Hello World", mensagem);

            Console.WriteLine(mensagem);

        }

        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_Test()
        {

            //Tipos primitivos
            string mensagem = "Hello World";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);

            //Tipos complexos
            Cachorro cachorro = new Cachorro();
            Console.WriteLine(cachorro);
        }

        [TestMethod]
        public void Conversao_Implicita_Test()
        {
            int inteiro = 10;
            double valor = inteiro;

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }


        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreEqual(inteiro, (int)valor);
            Assert.AreNotEqual(inteiro, valor);
        }

        [TestMethod]
        public void Tipo_de_Valor_Test()
        {
            int valor = 10;
            HelloWorld.PassaValor(10);

            Console.WriteLine(valor );
            Assert.AreEqual(10, valor);
        }


        [TestMethod]
        public void Tipo_de_Referencia_Test()
        {

            Cachorro cachorro = new Cachorro();
            cachorro.SetNome("Léia");
            
            HelloWorld.PassaReferencia(cachorro);

            string nomeCachorro = cachorro.GetNome();
            Console.WriteLine(nomeCachorro);

            Assert.AreEqual(cachorro.GetNome(), nomeCachorro);

           
        }

        [TestMethod]
        public void Igualdade_Entre_Tipos_de_Valor_Test()
        {

            int valor1 = 10;
            int valor2 = 10;
            Console.WriteLine(valor1 +"---------"+ valor2);

            Assert.AreEqual(valor1, valor2);


        }
        [TestMethod]
        public void Desigualdade_Enrte_Tipos_de_Referencia_Test()
        {

            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Léia");
            Cachorro cachorro2 = new Cachorro();
            cachorro2.SetNome("Léia"); 
            Console.WriteLine(cachorro1 +"------"+ cachorro2);

            Assert.AreNotEqual(cachorro1, cachorro2);

            cachorro2 = cachorro1;
            Assert.AreEqual(cachorro2, cachorro1);


        }
    }
}


