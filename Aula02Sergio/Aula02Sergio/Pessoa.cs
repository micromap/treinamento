using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02Sergio
{
    class Pessoa
    {
        public int Codigo { get; set; } //Encapsulamento
        public string Nome { get; set; } //"Nome"(LETRA MAIUSCULA) é propriedade de nome que dá permissão de acesso - leitura e escrita
        public double Altura { get; set; }
    }
}

