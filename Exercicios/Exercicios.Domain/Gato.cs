using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Domain
{
    public class Gato : Animal, IPet
    {
        public string Miar(int qtdMiado)
        {
            string miados = "";
            for (var i = 1; i <= qtdMiado; i++)
                miados += "Miau! ";
            return miados.TrimEnd();
        }

        public override string QuantoDevoComer()
        {
            //Método para Calcular 1% do peso do cachorro em gramas de ração.
            return $"Como tenho {Peso }Kg, devo comer { Peso * 10}g por dia";
        }
    }
    
}
