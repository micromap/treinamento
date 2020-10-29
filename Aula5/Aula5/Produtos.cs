using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5
{
    class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        public Produtos()
        {

        }

        public Produtos(int codigo, string nome, double preco, int quantidade)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
