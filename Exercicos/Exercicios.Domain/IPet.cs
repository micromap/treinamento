using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public interface IPet
    {
        List<Cachorro> Pets { get; set; }

        void AddPets(Cachorro pet);
        void AddPets(Cachorro[] pets);
        void RemovePets(Cachorro pet);
        void RemovePets(Cachorro[] pets);
    }
}
