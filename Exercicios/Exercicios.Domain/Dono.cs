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

        public override string ToString()
        {
            return "Nome: " + Nome + " " + "Email: " + Email + " " + " Telefone: " + Telefone;
        }
    }
}
