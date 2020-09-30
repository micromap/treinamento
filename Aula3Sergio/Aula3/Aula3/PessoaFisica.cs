using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    class PessoaFisica : Pessoa
    {
        public String Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public String CPF { get; set; }
    }
}
