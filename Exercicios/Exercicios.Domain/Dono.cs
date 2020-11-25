using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    //Classe Dono
    public class Dono
    {
        public string Nome { set; get; }

        public string Telefone { set; get; }

        public string Email { set; get; }

        public List<IPet> Pets { set; get; }

        public void AddPet(IPet pet)
        {
            if (Pets == null)
                Pets = new List<IPet>();

            Pets.Add(pet);
            pet.Dono = this;
        }

        public void AddPet(params IPet[] pets)
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

        public void RemovePet(params IPet[] pets)
        {
            foreach (var pet in pets)
                RemovePet(pet);
        }

    }
}
