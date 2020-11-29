using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class DonoTest
    {
        [TestMethod]
        public void Dono_AddPet_Test()
        {

            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };

            var silvia = new Dono { Nome = "Silvia" };
      
            silvia.AddPet(leia);
            silvia.AddPet(yuri);
            Assert.AreEqual(2, silvia.Pets.Count);
            Assert.AreEqual(silvia,leia.Dono);
            Assert.AreEqual(silvia, yuri.Dono);

            foreach ( var pet in silvia.Pets)
                Console.WriteLine(pet.Nome);
        }

        [TestMethod]
        public void Dono_AddPets_Test()
        {

            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };

            var dono_cao = new Dono { Nome = "Silvia" };

            dono_cao.AddPet(cachorro1, cachorro2);

            Assert.AreEqual(2, dono_cao.Pets.Count);
            Assert.AreEqual(dono_cao, cachorro1.Dono);
            Assert.AreEqual(dono_cao, cachorro2.Dono);

            foreach (var pet in dono_cao.Pets)
                Console.WriteLine(pet.Nome);
        }



        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };

            var silvia = new Dono { Nome = "Silvia" };

            silvia.AddPet(leia);
            silvia.AddPet(yuri);

            silvia.RemovePet(yuri);

            Assert.AreEqual(1, silvia.Pets.Count);
            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);

            foreach (var pet in silvia.Pets)
                Console.WriteLine(pet.Nome);
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };

            var dono_cao = new Dono { Nome = "Silvia" };

            dono_cao.AddPet(cachorro1);
            dono_cao.AddPet(cachorro2);

            dono_cao.RemovPet(cachorro1, cachorro2);

            Assert.AreEqual(0, dono_cao.Pets.Count);
            Assert.AreEqual(null, cachorro1.Dono);
            Assert.AreEqual(null, cachorro2.Dono);

            foreach (var pet in dono_cao.Pets)
                Console.WriteLine(pet.Nome);
        }






    }
}
