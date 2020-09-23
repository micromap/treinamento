using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public DateTime validade;
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime Validade { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, string nome, double preco)
        {
            this.codigo = codigo;
            this.nome   = nome;
            this.preco  = preco;
         }
    }
}
