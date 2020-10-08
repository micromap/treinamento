using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04
{
    abstract class CategoriaRepositorio
    {
        public abstract void inserir(Categoria categoria);

        public abstract void buscar(int codigo);
    }
}
