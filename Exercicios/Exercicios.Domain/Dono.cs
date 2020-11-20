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

        public override string ToString()
        {
            return "Nome: " + Nome + " " + "Email: " + Email + " " + " Telefone: " + Telefone;
        }

        public void AddPet(Cachorro pet)
        {
            if (Pets == null)
                Pets = new List<Cachorro>();

            Pets.Add(pet);
            pet.Dono = this;

        }

        public void RemovePet(Cachorro pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null;
        }
    }
}
