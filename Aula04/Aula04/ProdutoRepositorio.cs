using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04
{
    class ProdutoRepositorio
    {
        public void Inserir(Produto produto)
        {
            Console.WriteLine("Produto inserido com sucesso!");
            Console.WriteLine("Código: " + produto.Codigo);
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Preço: " + produto.Preco);
            Console.WriteLine("Quantidade: " + produto.Quantidade);
        }
    }
}
