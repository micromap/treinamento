﻿using System;

namespace Exercicios.Domain
{
    public class Gato : Animal, IPet
    {
        public string Miar(int qtdMiados)
        {
            var miados = "";

            for (var i = 1; i <= qtdMiados; i++)
                miados += "Miau! ";

            return miados.TrimEnd();
        }
    }
}