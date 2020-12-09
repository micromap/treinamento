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
            var vesgo = new Gato { Nome = "Vesgo" };
            var mingau = new Gato { Nome = "Mingau" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia);
            tamara.AddPet(yuri);
            tamara.AddPet(vesgo);
            tamara.AddPet(mingau);

            Assert.AreEqual(4, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(tamara, yuri.Dono);
            Assert.AreEqual(tamara, vesgo.Dono);
            Assert.AreEqual(tamara, mingau.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Vesgo" };
            var mingau = new Gato { Nome = "Mingau" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia);
            tamara.AddPet(yuri);
            tamara.AddPet(vesgo);
            tamara.AddPet(mingau);

            tamara.RemovePet(yuri);
            tamara.RemovePet(vesgo);

            Assert.AreEqual(2, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);
            Assert.AreEqual(tamara, mingau.Dono);
            Assert.AreEqual(null, vesgo.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }
    

        [TestMethod]
        public void Dono_AddPets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Vesgo" };
            var mingau = new Gato { Nome = "Mingau" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia, yuri, vesgo, mingau);

            Assert.AreEqual(4, tamara.Pets.Count);
            Assert.AreEqual(tamara, leia.Dono);
            Assert.AreEqual(tamara, yuri.Dono);
            Assert.AreEqual(tamara, vesgo.Dono);
            Assert.AreEqual(tamara, mingau.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Vesgo" };
            var mingau = new Gato { Nome = "Mingau" };

            var tamara = new Dono { Nome = "Tamara" };

            tamara.AddPet(leia, yuri, vesgo, mingau);

            tamara.RemovePet(yuri, leia, vesgo);

            Assert.AreEqual(1, tamara.Pets.Count);
            Assert.AreEqual(null, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);
            Assert.AreEqual(null, vesgo.Dono);

            foreach (var pet in tamara.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }
    }
}
