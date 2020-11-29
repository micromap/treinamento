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

            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };
            var gato1 = new Cachorro { Nome = "Vesgo" };
            var gato2 = new Cachorro { Nome = "Mingau" };

            var dono_pet = new Dono { Nome = "Silvia" };

            dono_pet.AddPet(cachorro1);
            dono_pet.AddPet(cachorro2);
            dono_pet.AddPet(gato1);
            dono_pet.AddPet(gato2);

            Assert.AreEqual(4, dono_pet.Pets.Count);
            Assert.AreEqual(dono_pet, cachorro1.Dono);
            Assert.AreEqual(dono_pet, cachorro2.Dono);
            Assert.AreEqual(dono_pet, gato1.Dono);
            Assert.AreEqual(dono_pet, gato2.Dono);

            foreach ( var pet in dono_pet.Pets)
                Console.WriteLine($"{pet.GetType().Name}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_AddPets_Test()
        {

            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };
            var gato1     = new Gato { Nome = "Vesgo" };
            var gato2     = new Gato { Nome = "Mingau" };

            var dono_pet = new Dono { Nome = "Silvia" };

            dono_pet.AddPet(cachorro1, cachorro2);
            dono_pet.AddPet(gato1, gato2);

            Assert.AreEqual(4, dono_pet.Pets.Count);
            Assert.AreEqual(dono_pet, cachorro1.Dono);
            Assert.AreEqual(dono_pet, cachorro2.Dono);
            Assert.AreEqual(dono_pet, gato1.Dono);
            Assert.AreEqual(dono_pet, gato2.Dono);

            foreach (var pet in dono_pet.Pets)
                Console.WriteLine($"{pet.GetType().Name}: {pet.Nome}");
        }



        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };
            var gato1 = new Gato { Nome = "Vesgo" };
            var gato2 = new Gato { Nome = "Mingau" };


            var dono_pet = new Dono { Nome = "Silvia" };

            dono_pet.AddPet(cachorro1);
            dono_pet.AddPet(cachorro2);
            dono_pet.AddPet(gato1);
            dono_pet.AddPet(gato2);

            dono_pet.RemovePet(cachorro2); 
            dono_pet.RemovePet(gato2);

            Assert.AreEqual(2, dono_pet.Pets.Count);
            Assert.AreEqual(dono_pet, cachorro1.Dono);
            Assert.AreEqual(dono_pet, gato1.Dono);
            Assert.AreEqual(null, cachorro2.Dono);
            Assert.AreEqual(null, gato2.Dono);

            foreach (var pet in dono_pet.Pets)
                Console.WriteLine($"{pet.GetType().Name}: {pet.Nome}");
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var cachorro1 = new Cachorro { Nome = "Léia" };
            var cachorro2 = new Cachorro { Nome = "Yuri" };
            var gato1 = new Gato { Nome = "Vesgo" };
            var gato2 = new Gato { Nome = "Mingau" };

            var dono_pet = new Dono { Nome = "Silvia" };

            dono_pet.AddPet(cachorro1);
            dono_pet.AddPet(cachorro2);

            dono_pet.AddPet(gato1);
            dono_pet.AddPet(gato2);

            dono_pet.RemovPet(cachorro1, cachorro2);
            dono_pet.RemovPet(gato1, gato2);

            Assert.AreEqual(0, dono_pet.Pets.Count);
            Assert.AreEqual(null, cachorro1.Dono);
            Assert.AreEqual(null, cachorro2.Dono);
            Assert.AreEqual(null, gato1.Dono);
            Assert.AreEqual(null, gato2.Dono);


            foreach (var pet in dono_pet.Pets)
                Console.WriteLine($"{pet.GetType().Name}: {pet.Nome}");
        }






    }
}
