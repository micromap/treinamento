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
        public void Conversao_Implicita_Test()
        {
            int inteiro = 10;
            double valor = inteiro;   //converte inteiro para double

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }
        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 1.2;
            int inteiro = (int)valor;    //cast explicit

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);  //primeiro resultado esperado, depois o que é pra comparar
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
            cachorro.Nome = "Léia";

            HelloWorld.PassaReferencia(cachorro);
            string nomeCachorro = cachorro.Nome;

            Console.WriteLine(nomeCachorro);
            Assert.AreEqual("Tequila", nomeCachorro);
        }
        [TestMethod]
        public void Desigualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Leia";

            Assert.AreNotEqual(cachorro1, cachorro2);
        }
        [TestMethod]
        public void Igualdade_entre_Tipos_de_Referencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Léia";

            Cachorro cachorro2 = cachorro1;

            Assert.AreEqual(cachorro1, cachorro2);
        }

        [TestMethod]
        public void Tipos_Explicitos_Test()  //declara os tipos das variáveis
        {
            string nome = "Leia";
            int idade = 1;
            double peso = 1.3;
            Cachorro cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Tipos_Implicitos_Test()//declara 'var', identifica o tipo por causa da atribuição "Leia"
        {
            var nome = "Leia";    
            var idade = 1;
            var peso = 1.3;
            var cachorro = new Cachorro();

            Assert.AreEqual(typeof(string), nome.GetType());
            Assert.AreEqual(typeof(int), idade.GetType());
            Assert.AreEqual(typeof(double), peso.GetType());
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());
        }

        [TestMethod]
        public void Declarar_Sem_Inicializar_Test()
        {
            Cachorro cachorro;
            cachorro = new Cachorro();
            Assert.AreEqual(typeof(Cachorro), cachorro.GetType());

           //não podemos declarar variáveis implicitas sem atribuir valores;
           //var nome;
           //nome = "Leia";
           //Assert.AreEqual(typeof(string), nome.GetType());

        }

        [TestMethod]
        public void Tipos_Que_Aceitam_Null_Test()
        {
            string nome = null;
            Cachorro cachorro = null;

            Assert.AreEqual(null, nome);
            Assert.AreEqual(null, cachorro);

            //int e double não aceitam null, nem variáveis implicitas
            //int idade = null;
            //double peso = null;
        }

        [TestMethod]
        public void Tipos_Nulaveis_Test()    //usar '?' deixa a variável aceitar null
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
          obj.MeuMetodo();
        }
    }

}
