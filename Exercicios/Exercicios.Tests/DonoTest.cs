using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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

            var silvia = new Dono
            {
                Nome = "Silvia"
            };

            silvia.AddPet(leia);
            silvia.AddPet(yuri);
            silvia.AddPet(vesgo);
            silvia.AddPet(mingau);

            Assert.AreEqual(4, silvia.Pets.Count);

            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(silvia, yuri.Dono);
            Assert.AreEqual(silvia, vesgo.Dono);
            Assert.AreEqual(silvia, mingau.Dono);


            foreach (var pet in silvia.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Vesgo" };
            var mingau = new Gato { Nome = "Mingau" };

            var silvia = new Dono
            {
                Nome = "Silvia"
            };

            silvia.AddPet(leia);
            silvia.AddPet(yuri);
            silvia.AddPet(vesgo);
            silvia.AddPet(mingau);

            silvia.RemovePet(yuri);
            silvia.RemovePet(vesgo);

            Assert.AreEqual(2, silvia.Pets.Count);

            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);
            Assert.AreEqual(silvia, mingau.Dono);
            Assert.AreEqual(null, vesgo.Dono);


            foreach (var pet in silvia.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_AddPets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Yuri" };
            var mingau = new Gato { Nome = "Yuri" };

            var silvia = new Dono
            {
                Nome = "Silvia"
            };

            var pets = new [] { leia, yuri };

            silvia.AddPet(leia,yuri, vesgo, mingau);
            
            Assert.AreEqual(4, silvia.Pets.Count);

            Assert.AreEqual(silvia, leia.Dono);
            Assert.AreEqual(silvia, yuri.Dono);
            Assert.AreEqual(silvia, vesgo.Dono);
            Assert.AreEqual(silvia, mingau.Dono);


            foreach (var pet in silvia.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var leia = new Cachorro { Nome = "Léia" };
            var yuri = new Cachorro { Nome = "Yuri" };
            var vesgo = new Gato { Nome = "Yuri" };
            var mingau = new Gato { Nome = "Yuri" };

            var silvia = new Dono
            {
                Nome = "Silvia"
            };

            silvia.AddPet(leia, yuri, vesgo, mingau);

            silvia.RemovePet(yuri, leia, vesgo, mingau);

            Assert.AreEqual(0, silvia.Pets.Count);

            Assert.AreEqual(null, leia.Dono);
            Assert.AreEqual(null, yuri.Dono);
            Assert.AreEqual(null, vesgo.Dono);
            Assert.AreEqual(null, mingau.Dono);
        }
    }
}
