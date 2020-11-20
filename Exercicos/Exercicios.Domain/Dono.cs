using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Dono
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Cachorro> Pets { get; set; }

        public void AddPets(Cachorro pet)
        {
            if (Pets == null) 
                Pets = new List<Cachorro>();

            Pets.Add(pet);
            pet.Dono = this;
        }

        public void AddPets(Cachorro[] pets)
        {
            foreach (var pet in pets)
                AddPets(pet);
        }

        public void RemovePets(Cachorro pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null;
        }

        public void RemovePets(Cachorro[] pets)
        {
            foreach (var pet in pets)
                RemovePets(pet);
        }
    }
}
