using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4Sergio
{
    class ProdutoDAO : ProdutoInterface
    {
        public void Alterar(Produto produto)
        {
            Console.WriteLine("Produto alterado com Sucesso");
        }

        public Produto BuscarCodigo(int codigo)
        {
            Produto produto = new Produto();
            Console.WriteLine("Produto localizado por Código");

            return produto;
        }

        public void Inserir(Produto produto)
        {
            Console.WriteLine("Produto inserido com Sucesso");
        }
    }
}
