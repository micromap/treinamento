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
            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(silvia, yuri.Dono);

            foreach (var pet in silvia.Pets)
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
    }
}
