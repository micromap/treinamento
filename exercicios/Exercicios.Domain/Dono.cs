using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Dono
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        
        public List<Ipet> Pets { get; set; }

        public void AddPet(Ipet pet)
        {
            if (Pets == null)
                {
                    Pets = new List<Ipet>();                    
                }
            Pets.Add(pet);
            pet.Dono = this;

        }

        public void AddPet(params Ipet[] pets)
        {
            foreach (var pet in pets)
            {
                AddPet(pet);
            }
        }

        public void RemovePet(Ipet pet)
        {
            if (Pets == null)
                return;

            if(Pets.Remove(pet) == true)
            {
                pet.Dono = null;
            }
        }

        public void RemovePet(params Ipet[] pets)
        {
            foreach (var pet in pets)
            {
                RemovePet(pets);
            }
        }
    }
}
