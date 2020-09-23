using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02B
{
    class Pessoa
    {
        // Aqui vemos uma propriedade Encapsulando um atributo , já criado o nome do atributo codigo
        public int Codigo { get; set; }
        public string Nome { get; set; }        
        public double Altura { get; set; }
        public DateTime Data { get; set; }

    }
}
