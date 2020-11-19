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
        public List<Cachorro> Pets { get; set; }

        public void AddPet(Cachorro pet)
        {
            if (Pets == null)
                {
                    Pets = new List<Cachorro>();                    
                }
            Pets.Add(pet);
            pet.Dono = this;

        }

        public void RemovePet(Cachorro pet)
        {
            if (Pets == null)
                return;

            if(Pets.Remove(pet) == true)
            {
                pet.Dono = null;
            }
        }
    }
}
