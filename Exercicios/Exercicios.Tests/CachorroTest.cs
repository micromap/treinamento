using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class CachorroTest
    {

        //[TestMethod]
        public void Cachorro_Latir_Test()
        {

            Cachorro leia = new Cachorro();
            //string latido = leia.Latir();

            //Console.WriteLine(latido);

            //Assert.AreEqual("Au! Au!", latido);
        }

        //Considerando que leia pesa 1Kg
        //e come 5% do seu peso em racao
        //implemente o metodo "QuantoDevoComer"
        //para passar nesse teste
        //[TestMethod]
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
        
        //[TestMethod]
        public void Preencher_Atributos_Test()
        {
            Cachorro cachorro = new Cachorro();


            cachorro.SetNome("Rex");

        }

        //[TestMethod]
        public void Instanciando_Cachorros_Test()
        {

            List<Cachorro> cachorros = new List<Cachorro>();

            Cachorro cachorro = new Cachorro();

            cachorro.SetIdade(12);
            cachorro.SetNome("Leia");
            cachorro.SetPeso(12.5);
            cachorro.SetPorte("Grande");
            cachorro.SetRaca("Labrador");
            cachorro.SetSexo("Femea");

            cachorros.Add(cachorro);

            cachorro = new Cachorro();

            cachorro.SetIdade(9);
            cachorro.SetNome("Lulu");
            cachorro.SetPeso(2);
            cachorro.SetPorte("PEqueno");
            cachorro.SetRaca("ChauChau");
            cachorro.SetSexo("Macho");

            cachorros.Add(cachorro);

            cachorro = new Cachorro();

            cachorro.SetIdade(7);
            cachorro.SetNome("Xico");
            cachorro.SetPeso(5);
            cachorro.SetPorte("Medio");
            cachorro.SetRaca("Vira-Lata");
            cachorro.SetSexo("Macho");

            cachorros.Add(cachorro);

            foreach(Cachorro objeto in cachorros){
                Console.WriteLine("Nome: " + objeto.GetNome()               + "\n" +
                                  "Idade: " + objeto.GetIdade().ToString()  + "\n" + 
                                  "Peso: " + objeto.GetPeso().ToString()    + "\n" + 
                                  "Porte: " + objeto.GetPorte()             + "\n" +
                                  "Raça: " + objeto.GetRaca()               + "\n" + 
                                  "Sexo: " + objeto.GetSexo()               + "\n" +
                                  "-----------------------------------------------\n");
            }


        }

        [TestMethod]
        public void Gerar_Latidos_Test()
        {

            Cachorro cachorro = new Cachorro();

            Console.WriteLine(cachorro.Latir(5));

        }

    }
}
