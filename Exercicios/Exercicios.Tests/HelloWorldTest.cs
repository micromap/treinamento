using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class HelloWorldTest
    {
        //[TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();

            //Classe Assert usada para realizar testes de validacao.
            //A mensagem sera testada para ver se retorna "HelloWorld".
            Assert.AreEqual("HelloWorld", mensagem);

            Console.WriteLine(mensagem);
        }


        //[TestMethod]
        public void Conversao_Implicita_Test()
        {

            double valor = 1.23;
            int inteiro = (int)valor;

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);

        }

        //[TestMethod]
        public void Tipo_De_Valor_Test()
        {

            int valor = 10;
            HelloWorld.Passa_Valor(valor);

            Console.WriteLine(valor);
            Assert.AreNotEqual(10, valor);

        }

        //[TestMethod]
        public void Igualdade_Entre_Tipos_De_Referencia()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("LALALA");


            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Desigualdade_Entre_Tipos_De_Referencia()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("LALALA");


            Cachorro cachorro2 = new Cachorro();
            cachorro1.SetNome("HAHAHA");

            Assert.AreEqual(cachorro1, cachorro2);
        }


    }
}
