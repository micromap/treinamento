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
            string mensagem = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", mensagem);
            Console.WriteLine(mensagem);

        }

        [TestMethod]
        public void Tipos_Primitivos_e_Complexos_Test()
        {
            //Tipos Primitivos
            string mensagem = "Hello World!";
            double peso = 1.2;
            int idade = 4;
            Console.WriteLine(mensagem);
            Console.WriteLine(peso);
            Console.WriteLine(idade);


            //Tipos Complexos

            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);
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

            Console.WriteLine(valor);
            Assert.AreNotEqual(valor,inteiro);
        }

        [TestMethod]
        public void Tipo_de_Valor_Test()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
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
            Assert.AreEqual("Tequila", nomeCachorro);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Valor_Test()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1,valor2);
        }

        [TestMethod]
        public void Desigualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Léia");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.SetNome("Léia");

            Assert.AreNotEqual(cachorro1,cachorro2);
        }

        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Léia");

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_Explicitos_Test()
        {
            string nome = "Léia";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();
            

            Assert.AreEqual(typeof(string),nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_Implicitos_Test()
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
        public void Declarar_Sem_inicializar_Test()
        {
            Cachorro cachorro;
            cachorro = new Cachorro();

            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

          /* Não podemos declarar variaveis implicitas sem atribuir um valor
           * 
            var nome;
            nome = "Léia";
            Assert.AreEqual(typeof(String), nome.GetType());
          */

        }

        [TestMethod]
        public void Tipos_Que_Aceitam_Null_Test()
        {
            string nome = null;
            Cachorro cachorro = null;


            Assert.AreEqual(null, nome);
            Assert.AreEqual(null, cachorro);

            /*Int e double não são Nullaveis assim como variaveis implicitas*/

            //   int idade = null;
            //   double peso = null;
            //Assert.AreEqual(null, idade);
            //Assert.AreEqual(null, peso);
        }

        [TestMethod]
        public void Tipos_Nullaveis_Test()
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
           // obj.MeuMetodo();
        }
    }

    public class ClasseFilha2 : MinhaClasse
    {
        public void MetodoFilho2()
        {
            this.MeuMetodo();
        }
    }
}
