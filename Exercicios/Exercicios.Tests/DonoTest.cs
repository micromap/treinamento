using Exercicios.Domain;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia);
            tamara.AddPet(yuri);

            Assert.AreEqual(2, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(tamara, yuri.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine(pet.Nome);
        }

        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia);
            tamara.AddPet(yuri);

            tamara.RemovePet(yuri);

            Assert.AreEqual(1, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine(pet.Nome);
        }

        [TestMethod]
        public void Dono_AddPets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia, yuri);

            Assert.AreEqual(2, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(tamara, yuri.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine(pet.Nome);
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };

            var tamara = new Dono { Nome = "Tamara" };

            var pets = new[] { leia, yuri };

            tamara.AddPet(leia);
            tamara.AddPet(yuri);

            tamara.RemovePet(yuri, leia);

            Assert.AreEqual(0, tamara.Pets.Count);
            Assert.AreEqual(null, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine(pet.Nome);
        }
    }
}
