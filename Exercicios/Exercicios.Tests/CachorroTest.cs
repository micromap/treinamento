using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {

        [TestMethod]
        public void Cachorro_Latir_Test()
        {

            Cachorro leia = new Cachorro();
            string latido = leia.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au!", latido);
        }

        //Considerando que leia pesa 1Kg
        //e come 5% do seu peso em racao
        //implemente o metodo "QuantoDevoComer"
        //para passar nesse teste
        [TestMethod]
        public void Cachorro_QuantoDevoComer_Test()
        {

            double percentualCorreto = 5;

            Cachorro leia = new Cachorro();
            double qtdIdeal = leia.QuantoDevoComer(1, percentualCorreto);

            //Teste passando de parametro somente valores corretos de acordo com a regra
            //Retorna que funcionou!
            Assert.AreEqual(leia.QuantoDevoComer(1,5), qtdIdeal);

            //---------------------------------------------------------------------------------------

            Cachorro tequila = new Cachorro();
            qtdIdeal = tequila.QuantoDevoComer(12, percentualCorreto);

            Assert.AreEqual(tequila.QuantoDevoComer(12, 5), qtdIdeal);

            //---------------------------------------------------------------------------------------

            Cachorro yury = new Cachorro();    
            qtdIdeal = yury.QuantoDevoComer(12, percentualCorreto);

            Assert.AreEqual(yury.QuantoDevoComer(12, 5), qtdIdeal);


        }
    }
}
