using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Tests
{
    [TestClass]
    public class PetTest
    {
        private static List<IPet> _pets;

        [ClassInitialize]
        public static async Task Setup(TestContext context)
        {
            _pets = new List<IPet>();
           await _pets.CarregaPetsDoArquivo("C:\\Aula030\\pets.csv");
        }

        private static void ImprimePets(IEnumerable<IPet> pets)
        {
            foreach (var pet in _pets)
                Console.WriteLine($"[{pet.GetTipo()}] {pet.Nome} - {pet.Dono.Nome}");
        }

        [TestMethod]
        public void CarregaPetDoArquivo_Test()
        {
            Assert.AreEqual(15, _pets.Count);
            ImprimePets(_pets);
        }

        [TestMethod]
        public void Linq_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        select pet;
            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Metodos_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato");
            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Order_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        orderby pet.Nome
                        select pet;
            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Order_Metodos_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato")
                .OrderBy(pet => pet.Nome);

            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Projecao_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        orderby pet.Peso descending
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            foreach (var pet in query)
                Console.WriteLine($" {pet.Nome} - {pet.Peso}");
        }

        [TestMethod]
        public void Linq_Projecao_Metodos_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato")
                .OrderByDescending(pet => pet.Peso)
                .Select(pet => new { pet.Nome, pet.Peso });

            foreach (var pet in query)
                Console.WriteLine($" {pet.Nome} - {pet.Peso}");
        }

        [TestMethod]
        public void Linq_Skip_Take_Test()
        {
            var query = (from pet in _pets
                         where pet.GetTipo() == "Cachorro"
                         orderby pet.Peso descending
                         select new { Nome = pet.Nome, Peso = pet.Peso }).Skip(3).Take(3);

            foreach (var pet in query)
                Console.WriteLine($" {pet.Nome} - {pet.Peso}");
        }

        [TestMethod]
        public void Linq_First_Last_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        orderby pet.Peso descending
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            var primeiro = query.FirstOrDefault();
            var ultimo = query.LastOrDefault();

            Console.WriteLine(primeiro.Nome);
            Console.WriteLine(ultimo.Nome);
        }

        [TestMethod]
        public void Linq_Agregacoes_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        orderby pet.Peso descending
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            var soma = query.Sum(pet => pet.Peso);
            var maior = query.Max(pet => pet.Peso);
            var menor = query.Min(pet => pet.Peso);
            var media = query.Average(pet => pet.Peso);


            Console.WriteLine($"Soma Peso: {soma}");
            Console.WriteLine($"Maior Peso: {maior}");
            Console.WriteLine($"Menor Peso: {menor}");
            Console.WriteLine($"Media Peso: {media}");


        }

        [TestMethod]
        public void Linq_Group_Test()
        {
            var query = from pet in _pets
                        group pet by pet.Sexo into g
                        select new {Sexo = g.Key,Total = g.Count()};

            foreach (var pet in query)
                Console.WriteLine($" {pet.Sexo} - {pet.Total}");
        }

        [TestMethod]
        public void Linq_Group_Dono_Test()
        {
            var query = from pet in _pets
                        group pet by pet.Dono into g
                        orderby g.Key.Nome
                        select new
                        {
                            Dono = g.Key.Nome,
                            TotalCaes = g.Key.Pets.Count(x => x.GetTipo() == "Cachorro"),
                            TotalGatos = g.Key.Pets.Count(x => x.GetTipo() == "Gatos"),
                        };

            foreach (var x in query)
                Console.WriteLine($"{x.Dono}: Cães = {x.TotalCaes} | Gatos ={x.TotalGatos}");
        }

        [TestMethod]
        public void Linq_Cachorro_MaisVelho_e_MaisNovo_Test()
        {
            var cachorros = _pets.Where(x => x.GetTipo() == "Cachorro").Cast<Cachorro>();

            var maisVelho = cachorros.Aggregate((min, x) =>
            x.Nascimento < min.Nascimento ? x : min);

            var maisNovo = cachorros.Aggregate((max, x) => 
            x.Nascimento > max.Nascimento ? x : max);

            Console.WriteLine($"Mais Velho : {maisVelho.Nome} - Nasceu em : {maisVelho.Nascimento} - Tem {maisVelho.GetIdade()}");
            Console.WriteLine($"Mais Novo : {maisNovo.Nome} - Nasceu em : {maisNovo.Nascimento} - Tem {maisNovo.GetIdade()}");

        }

    }
}
