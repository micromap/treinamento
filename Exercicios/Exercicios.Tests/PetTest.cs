using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Exercicios.Tests
{
    [TestClass]
    public class PetTest
    {
        [TestMethod]
        public void CarregaPetDoArquivo_Test()
        {
            var pets = new List<IPet>();
            pets.CarregaPetsDoArquivo("C:\\Aula030\\pets.csv");
            //Carrega a lista de pets pelo arquivo C:\\Aula030\\pets.csv
            Assert.AreEqual(15, pets.Count);

            foreach (var pet in pets)
                Console.WriteLine($"[{pet.GetTipo()}] {pet.Nome} - {pet.Dono.Nome}");

        }
    }
}
