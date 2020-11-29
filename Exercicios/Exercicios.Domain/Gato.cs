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
    }
}
