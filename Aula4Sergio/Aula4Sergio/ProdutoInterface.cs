using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4Sergio
{
    interface ProdutoInterface
    {
        public Produto BuscarCodigo(int codigo);
        public void Inserir(Produto produto);
        public void Alterar(Produto produto);
    }
}
