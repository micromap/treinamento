using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Dono
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }


        public List<IPet> Pets { get; set; }

        public void AddPet(params IPet[] pets)
        {
            foreach (var pet in pets)
                AddPet(pet);
        }

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
        
         if( Pets.Remove(pet)== true)
            pet.Dono = null;
        }

        public void RemovPet(params IPet[] pets)
        {
            foreach (var pet in pets)
               RemovePet(pet);
        }


    }
}
