using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04
{
    interface PessoaRepositorio
    {
        public void inserir(Pessoa pessoa);

        public void buscar(int codigo);
    }
}
