using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula1
{
    class Produto
    {

        public int codigo;
        public string nome;
        public double preco;
        public bool ativo;
        public DateTime data;
        public Categoria categoria;

        public Produto()
        {

        }

        // Aqui eu já utilizei os argumentos diferentes da classe, por isso não foi necessário o THIS.
        public Produto(int c, string n, double p, bool a, DateTime d, Categoria cat)
        {
            codigo    = c;
            nome      = n;
            preco     = p;
            ativo     = a;
            data      = d;
            categoria = cat;
        }    
    }
}
