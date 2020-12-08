using System;

namespace Exercicios.Domain
{
    public class Gato : Animal, IPet
    {
        public string Miar(int quantidadeMiados)
        {
            var miados = "";

            for (var i = 1; i <= quantidadeMiados; i++)
                miados += "Miau! ";  

            return miados.TrimEnd();
        }
        public override string QuantoDevoComer()
        {
            return $"Como tenho {Peso}kg, devo comer {Peso * 10}g por dia.";
        }
    }
}
