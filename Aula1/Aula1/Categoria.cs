using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    class Categoria
    {
        public int codigo;
        public string nome;

        // Aqui eu usei o exemplo com o THIS, utilizando o mesmo nome dos argumentos com o da Classe
        public Categoria(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome   = nome;
        }

    }

}
