using System;
using System.Collections.Generic;

namespace Exercicios.Domain
{
    public class Dono
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }


        public List<Cachorro> Pets { get; set; }

        public void AddPet(Cachorro[] pets)
        {
            foreach (var pet in pets)
                AddPet(pet);
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
        
         if( Pets.Remove(pet)== true)
            pet.Dono = null;
        }

      
    }
}
