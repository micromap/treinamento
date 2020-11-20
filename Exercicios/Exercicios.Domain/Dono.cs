
using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Dono
    {
        public string Nome { get; set;}
        public string Telefone { get; set;}
        public string Email { get; set; }
        public List<IPet> Pets { get; set; }

        public void AddPet(IPet pet)
        {
            if (Pets == null)
                Pets = new List<IPet>();

            Pets.Add(pet);
            pet.Dono = this;
        }

        public void RemovePet(IPet pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null;
        }

        public void AddPet(params IPet[] pets) //params interpreta os dois parâmetros, sem precisar de array
        {
            foreach (var pet in pets)
                AddPet(pet);
        }
        public void RemovePet(params IPet[] pets) 
        {
            foreach (var pet in pets)
                RemovePet(pet);
        }
    }
}
