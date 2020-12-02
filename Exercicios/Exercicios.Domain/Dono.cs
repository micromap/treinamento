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

        public List<IPet> Pets { get; set; }

        public void AddPet(IPet pet)
        {
            if (Pets == null)
                Pets = new List<IPet>();

            Pets.Add(pet);
            pet.Dono = this;  // this este  intância da classe
        }

        public void AddPet(params IPet[] pets)    // // o comando params foi usado para passar parametros como arrays
        {
            foreach (var pet in pets)
                AddPet(pet);
        }

        public void RemovePet(IPet pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null;
        }

        public void RemovePet(params IPet[] pets)    // // o comando params foi usado para passar parametros como arrays
        {
            foreach (var pet in pets)
                RemovePet(pet);
        }
    }
}
