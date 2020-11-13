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
            HelloWorld.PassaValor(valor);

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

        //[TestMethod]
        public void Desigualdade_Entre_Tipos_De_Referencia()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("LALALA");


            Cachorro cachorro2 = new Cachorro();
            cachorro1.SetNome("HAHAHA");

            Assert.AreEqual(cachorro1, cachorro2);
        }

        //[TestMethod]
        public void Tipos_Explicitos_Test()
        {

            string nome = "LLALA";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        //[TestMethod]
        public void Tipos_Implicitos_Test()
        {

            var nome = "LLALA";
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

        }

        //[TestMethod]
        public void Declarar_Sem_Inicializar()
        {

            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

        }

        //[TestMethod]
        public void Tipos_Que_Aceitam_Null()
        {

            string nome = null;
            Cachorro cachorro = null;

            //int e double nao aceitam NULL
            //int idade = 1;
            //double peso = 1.3;

            Assert.AreEqual(null, nome.GetType());
            Assert.AreEqual(null, cachorro.GetType());
        }

        //[TestMethod]
        public void Tipos_Nulaveis_Test()
        {

            int? idade = null;
            double? peso = null;
            bool? vacinado = null;

            Assert.AreEqual(null, idade);
            Assert.AreEqual(null, peso);
            Assert.AreEqual(null, vacinado);
        }

        [TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
        }

    }
}
