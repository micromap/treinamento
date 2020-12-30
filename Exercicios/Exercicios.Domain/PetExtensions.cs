using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public static class PetExtensions
    {
        public static string GetTipo(this IPet pet)
        {
            return pet.GetType().Name;
        }
    }
}
