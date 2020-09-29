using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void CachorroLatirTest()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        //Considerando que a Léia pesa 1Kg,
        // e come 10% do seu peso de ração,
        // implemente o Método "QuantoDevoComer"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQuantoDevoComerTest()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(80);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 80Kg, devo comer 8kg por dia", quantoDevoComer);
        }

        [TestMethod]
        public void TequilaQuantoDevoComerTest()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg, devo comer 3kg por dia", quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoDevoComerTest()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(150);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 150Kg, devo comer 15kg por dia", quantoDevoComer);
        }

        //Considerando que a Léia pesa 80kg atualmente e
        // ela perde 10% do seu peso a cada 10 anos
        // implemente o Método "QuantoIreiPesar"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQuantoIreiPesarTest()                    //LeiaPeso
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoIreiPesar(80);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 80Kg atualmente, daqui 10 anos irei pesar 72kg", quantoDevoComer);
        }

        [TestMethod]
        public void TequilaQuantoIreiPesarTest()                 //TequilaPeso
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoIreiPesar(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30Kg atualmente, daqui 10 anos irei pesar 27kg", quantoDevoComer);
        }

        [TestMethod]
        public void YuriQuantoIreiPesarTest()                     //YuriPeso
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoIreiPesar(150);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 150Kg atualmente, daqui 10 anos irei pesar 135kg", quantoDevoComer);
        }

        //Considerando que a Léia tem 10 anos atualmente e
        // a cada 5 anos ela envelhece, qual sera sua idade?
        // implemente o Método "QualMinhaIdade"
        // para passar nesse teste

        [TestMethod]
        public void LeiaQualMinhaIdadeTest()                       //LeiaIdade
        {
            Cachorro leia = new Cachorro();
            string qualMinhaIdade = leia.QualMinhaIdade(10);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 10 anos de idade, daqui 5 anos vou ter 15 anos", qualMinhaIdade);
        }

        [TestMethod]
        public void TequilaQualMinhaIdadeTest()                   //TequilaIdade
        {
            Cachorro tequila = new Cachorro();
            string qualMinhaIdade = tequila.QualMinhaIdade(8);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 8 anos de idade, daqui 5 anos vou ter 13 anos", qualMinhaIdade);
        }

        [TestMethod]
        public void YuriQualMinhaIdadeTest()                      //YuriIdade
        {
            Cachorro yuri = new Cachorro();
            string qualMinhaIdade = yuri.QualMinhaIdade(5);

            Console.WriteLine(qualMinhaIdade);

            Assert.AreEqual("Como tenho 5 anos de idade, daqui 5 anos vou ter 10 anos", qualMinhaIdade);
        }

        //EXERCÍCIOS AULA 14 RODRIGO
        //private string _nome;
        //private string _sexo;
        //private string _raca;
        //private string _porte;
        //private int _idade;
        //private double _peso

        [TestMethod]                                                  //NOMES
        public void CachorroGetSetNome()
        {
            Cachorro yuri = new Cachorro();
            Cachorro tequila = new Cachorro();
            Cachorro leia = new Cachorro();

            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();

            tequila.SetNome("Tequila");
            string nome2 = tequila.GetNome();

            leia.SetNome("Leia");
            string nome3 = leia.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);

            Console.WriteLine(nome2);
            Assert.AreEqual("Tequila", nome2);

            Console.WriteLine(nome3);
            Assert.AreEqual("Leia", nome3);
        }

        [TestMethod]
        public void CachorroGetSetSexo()                                //SEXO
        {
            Cachorro yuri = new Cachorro();
            Cachorro tequila = new Cachorro();
            Cachorro leia = new Cachorro();

            yuri.SetSexo("Masculino");                          
            string sexo = yuri.GetSexo();

            tequila.SetSexo("Feminino");
            string sexo2 = tequila.GetSexo();

            leia.SetSexo("Feminino");
            string sexo3 = leia.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Masculino", sexo);

            Console.WriteLine(sexo2);
            Assert.AreEqual("Feminino", sexo2);

            Console.WriteLine(sexo3);
            Assert.AreEqual("Feminino", sexo3);
        }

        [TestMethod]
        public void CachorroGetSetRaca()                                 //RAÇA
        {
            Cachorro yuri = new Cachorro();
            Cachorro tequila = new Cachorro();
            Cachorro leia = new Cachorro();

            yuri.SetRaca("BullDog");
            string raca = yuri.GetRaca();

            tequila.SetRaca("Labrador");
            string raca2 = tequila.GetRaca();

            leia.SetRaca("Yorkshire");
            string raca3 = leia.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("BullDog", raca);

            Console.WriteLine(raca2);
            Assert.AreEqual("Labrador", raca2);

            Console.WriteLine(raca3);
            Assert.AreEqual("Yorkshire", raca3);
        }

        [TestMethod]
        public void CachorroGetSetPorte()               //PORTE
        {
            Cachorro yuri = new Cachorro();
            Cachorro tequila = new Cachorro();
            Cachorro leia = new Cachorro();

            yuri.SetPorte("Médio");
            string porte = yuri.GetPorte();

            tequila.SetPorte("Grande");
            string porte2 = yuri.GetPorte();

            leia.SetPorte("Pequeno");
            string porte3 = leia.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);

            Console.WriteLine(porte2);
            Assert.AreEqual("Grande", porte2);

            Console.WriteLine(porte3);
            Assert.AreEqual("Pequeno", porte3);
        }
    }
}
