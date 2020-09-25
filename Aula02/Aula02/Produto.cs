using System;

namespace Aula02
{
    class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime Validade { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, string nome, double preco, DateTime validade)
        {
            Codigo = codigo;
            Nome   = nome;
            Preco  = preco;
            Validade = validade;
         }
    }
}
