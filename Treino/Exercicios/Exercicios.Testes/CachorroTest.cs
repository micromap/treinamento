
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
            string latido = leia.Latir(3);

            Console.WriteLine(latido);

            Assert.AreEqual("AU AU AU ", latido);

        } 


        [TestMethod]
        public void Leia_QtoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetPeso(1);
            string QuantoDevoComer = leia.QuantoDevoComer(leia.GetPeso());
            Console.WriteLine(QuantoDevoComer);
            //usando interpolação de string
            Assert.AreEqual($"Como tenho {leia.GetPeso()}Kg, devo comer {leia.GetPeso() * 0.05}g por dia", QuantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QtoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            tequila.SetPeso(30);
            string QuantoDevoComer = tequila.QuantoDevoComer(tequila.GetPeso());
            Console.WriteLine(QuantoDevoComer);
            Assert.AreEqual("Como tenho " + tequila.GetPeso() + "Kg, devo comer " + (tequila.GetPeso() * 0.05) + "g por dia", QuantoDevoComer);
        }
       
        
        [TestMethod]
        public void Yury_QtoDevoComer_Test()
        {
            Cachorro yury = new Cachorro();
            yury.SetPeso(15);
            string QuantoDevoComer = yury.QuantoDevoComer(yury.GetPeso());
            Console.WriteLine(QuantoDevoComer);
            Assert.AreEqual("Como tenho "+yury.GetPeso()+"Kg, devo comer "+(yury.GetPeso()*0.05)+"g por dia",QuantoDevoComer);
        }

        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetNome("Leya");
            string novoNome = "O nome do cachorro agora é " + leia.GetNome();
            Console.WriteLine(novoNome);
            Assert.AreEqual("O nome do cachorro agora é "+leia.GetNome(), novoNome);


        }

        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetSexo("Fêmea");
            string novoSexo = "O sexo do cachorro agora é " + leia.GetSexo();
            Console.WriteLine(novoSexo);
            Assert.AreEqual("O sexo do cachorro agora é Fêmea", novoSexo);


        }

        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetRaca("Vira Lata");
            string novaRaca = "A raça do cachorro agora é " + leia.GetRaca();
            Console.WriteLine(novaRaca);
            Assert.AreEqual("A raça do cachorro agora é Vira Lata", novaRaca);


        }

        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetPorte("Pequeno");
            string novoPorte = "O porte do cachorro agora é " + leia.GetPorte();
            Console.WriteLine(novoPorte);
            Assert.AreEqual("O porte do cachorro agora é Pequeno", novoPorte);


        }

        [TestMethod]
        public void Cachorro_Set_Get_Idade_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetIdade(2);
            string novaIdade = "A idade do cachorro agora é " + leia.GetIdade();
            Console.WriteLine(novaIdade);
            Assert.AreEqual("A idade do cachorro agora é 2", novaIdade);


        }

        [TestMethod]
        public void Cachorro_Set_Get_Peso_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetPeso(1);
            string novoPeso = "O peso do cachorro agora é " + leia.GetPeso();
            Console.WriteLine(novoPeso);
            Assert.AreEqual("O peso do cachorro agora é 1", novoPeso);


        }


        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Test()
        {
            Cachorro leia = new Cachorro();
            leia.SetVacinado(true);
            string vacinado = "O cachorro "+leia.GetVacinado()+"foi vacinado";
            Console.WriteLine(vacinado);
            Assert.AreEqual("O cachorro foi vacinado", vacinado);
        }
        
    }
}
