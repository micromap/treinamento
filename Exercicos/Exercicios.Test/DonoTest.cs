using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Test
{
    [TestClass]
    public class DonoTest
    {
        [TestMethod]
        public void Dono_AddPet_Test()
        {
            var cachorro1 = new Cachorro();
            cachorro1.Nome = "Ted";

            var cachorro2 = new Cachorro();
            cachorro2.Nome = "Bob";

            var dono = new Dono();
            dono.Nome = "Ana";
            
            dono.AddPets(cachorro1);
            dono.AddPets(cachorro2);

            Assert.AreEqual(2, dono.Pets.Count);
            Assert.AreEqual(dono, cachorro1.Dono);
            Assert.AreEqual(dono, cachorro2.Dono);

            foreach (var pet in dono.Pets) {
                Console.WriteLine($"Nome do Cachorro {pet.Nome}");
            }

            Console.WriteLine($"Quantidade de Cachorro(s) {dono.Pets.Count}");
        }

        [TestMethod]
        public void Dono_AddPets_Test()
        {
            var cachorro1 = new Cachorro();
            cachorro1.Nome = "Ted";

            var cachorro2 = new Cachorro();
            cachorro2.Nome = "Bob";

            var dono = new Dono();
            dono.Nome = "Ana";

            var pets = new[] { cachorro1, cachorro2 };
            
            dono.AddPets(pets);

            Assert.AreEqual(2, dono.Pets.Count);
            Assert.AreEqual(dono, cachorro1.Dono);
            Assert.AreEqual(dono, cachorro2.Dono);

            foreach (var pet in dono.Pets)
            {
                Console.WriteLine($"Nome do Cachorro {pet.Nome}");
            }

            Console.WriteLine($"Quantidade de Cachorro(s) {dono.Pets.Count}");
        }

        [TestMethod]
        public void Dono_RemovePet_Test()
        {
            var cachorro1 = new Cachorro();
            cachorro1.Nome = "Ted";

            var cachorro2 = new Cachorro();
            cachorro2.Nome = "Bob";

            var dono = new Dono();
            dono.Nome = "Ana";

            dono.AddPets(cachorro1);
            dono.AddPets(cachorro2);

            dono.RemovePets(cachorro2);

            Assert.AreEqual(1, dono.Pets.Count);
            Assert.AreEqual(dono, cachorro1.Dono);
            Assert.AreEqual(null, cachorro2.Dono);

            foreach (var pet in dono.Pets)
            {
                Console.WriteLine($"Nome do Cachorro {pet.Nome}");
            }

            Console.WriteLine($"Quantidade de Cachorro(s) {dono.Pets.Count}");
        }

        [TestMethod]
        public void Dono_RemovePets_Test()
        {
            var cachorro1 = new Cachorro();
            cachorro1.Nome = "Ted";

            var cachorro2 = new Cachorro();
            cachorro2.Nome = "Bob";

            var dono = new Dono();
            dono.Nome = "Ana";

            dono.AddPets(cachorro1);
            dono.AddPets(cachorro2);

            var pets = new[] { cachorro1, cachorro2 };

            dono.RemovePets(pets);

            Assert.AreEqual(0, dono.Pets.Count);
            Assert.AreEqual(null, cachorro1.Dono);
            Assert.AreEqual(null, cachorro2.Dono);

            Console.WriteLine("Fim do Teste RemovePets_Test");
        }
    }
}
