using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios.Tests
{
    [TestClass]
    public class PetTest
    {
        private static List<IPet> _pets;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            // carrega a lista de pets pelo arquivo C:\\Aula030\\pets.csv
            _pets = new List<IPet>();
            _pets.CarregaPetsDoArquivo("C:\\Aula030\\pets.csv");
        }

        private static void ImprimePets(IEnumerable<IPet> pets)
        {
            foreach (var pet in pets)
                Console.WriteLine($"[{pet.GetTipo()}] {pet.Nome} - {pet.Dono.Nome}");
        }

        [TestMethod]
        public void CarregaPetsDoArquivo_Test()
        {
            Assert.AreEqual(15, _pets.Count);

            ImprimePets(_pets);
        }

        [TestMethod]
        public void Linq_Test()
        {
            // LINQ é um acrônimo para Language Integrated Query, ou Consulta Integrada à Linguagem . 
            // Trata - se de um “framework” dentro do .NET destinado a auxiliar os desenvolvedores a escrever 
            // expressões de consulta diretamente em C# de maneira agnóstica.
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
        public void Linq_Order_Metodo_Test()
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
                Console.WriteLine($"{pet.Nome} - {pet.Peso}");
        }

        [TestMethod]
        public void Linq_Projecao_Metodo_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato")
                             .OrderByDescending(pet => pet.Peso)
                             .Select(pet => new { pet.Nome, pet.Peso });

            foreach (var pet in query)
                Console.WriteLine($"{pet.Nome} - {pet.Peso}");
        }

        [TestMethod]
        public void Linq_Skip_Take_Test()
        {   
            // este metodo serve para fazer paginação
            // Take(3) - pegar os três primeiros da query
            // Skip(3) - pular os três primeiros da query
            var query = (from pet in _pets
                         where pet.GetTipo() == "Cachorro"
                         orderby pet.Peso descending
                         select new { Nome = pet.Nome, Peso = pet.Peso }).Skip(3).Take(3);

            foreach (var pet in query)
                Console.WriteLine($"{pet.Nome} - {pet.Peso}");
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

            Console.WriteLine("Primeiro: "+primeiro.Nome);
            Console.WriteLine("Último: " + ultimo.Nome);
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
            Console.WriteLine($"Média Peso: {media}");
        }

        [TestMethod]
        public void Linq_Group_Test()
        {
            var query = from pet in _pets
                        group pet by pet.Sexo into g
                        select new { Sexo = g.Key, Total = g.Count() };

            foreach (var pet in query)
                Console.WriteLine($"{pet.Sexo} - {pet.Total}");
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
                            QtdeCaes = g.Key.Pets.Count(x => x.GetTipo() == "Cachorro"),
                            QtdeGatos = g.Key.Pets.Count(x => x.GetTipo() == "Gato")
                        };

            foreach (var x in query)
                Console.WriteLine($"{x.Dono}: Cachorro = {x.QtdeCaes} - Gatos = {x.QtdeGatos}");
        }

        [TestMethod]
        public void Linq_Cachorro_MaisVelho_e_MaisNovo_Test()
        {
            // comando cast <> se usar para conversão de double para int
            var cachorros = _pets.Where(x => x.GetTipo() == "Cachorro").Cast<Cachorro>();

            // O método agregado aplica uma função a cada item de uma coleção. Por exemplo, vamos ter a coleção { 6, 2, 8, 3}
            // e a função Adicionar(operador + ) que ela faz(((6 + 2) + 8) + 3) e retorna 19.
            // Implementação de Sum usando o método Aggregate.Este exemplo usa a sobrecarga do método Aggregate 
            // com apenas um parâmetro func . No parâmetro func , é passada a expressão lambda(método anônimo) 
            // que adiciona dois números. Este exemplo é apenas para demonstração . 
            // Para calcular a soma dos números, use Enumerable.Sum.

            // var numbers = new List<int> { 6, 2, 8, 3 };
            // int sum = numbers.Aggregate(func: (result, item) => result + item);
            // sum: (((6+2)+8)+3) = 19

            var maisVelho = cachorros.Aggregate((min, x) =>
                                            x.DataNascimento < min.DataNascimento ? x : min);

            var maisNovo = cachorros.Aggregate((max, x) =>
                                x.DataNascimento > max.DataNascimento ? x : max);

            Console.WriteLine(
                $"Mais Velho: {maisVelho.Nome} - {maisVelho.DataNascimento} - {maisVelho.GetIdade()}");

            Console.WriteLine(
                $"Mais Novo: {maisNovo.Nome} - {maisNovo.DataNascimento} - {maisNovo.GetIdade()}");
        }

    }
}
