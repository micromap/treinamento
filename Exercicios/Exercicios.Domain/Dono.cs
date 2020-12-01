using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Dono
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public List<Cachorro> Pets { get; set; }

        public void AddPet(Cachorro pet)
        {
            if (Pets == null)
                Pets = new List<Cachorro>();

            Pets.Add(pet);
            pet.Dono = this;  // this este  intância da classe
        }

        public void AddPet(params Cachorro[] pets)    // // o comando params foi usado para passar parametros como arrays
        {
            foreach (var pet in pets)
                AddPet(pet);
        }

        public void RemovePet(Cachorro pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null;
        }

        public void RemovePet(params Cachorro[] pets)    // // o comando params foi usado para passar parametros como arrays
        {
            foreach (var pet in pets)
                RemovePet(pet);
        }
    }
}
