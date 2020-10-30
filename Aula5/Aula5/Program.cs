using System;
using System.Collections.Generic;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos produtos = new Produtos();
    
            produtos.Nome = "Carro";
            produtos.Preco = 30.000;
            produtos.Quantidade = 5;

            ProdutoDAO objetoProdutoDAO = new ProdutoDAO();

            objetoProdutoDAO.InserirProduto(produtos);


            List<Produtos> carrinho = objetoProdutoDAO.ListarProdutos();

            foreach(Produtos item in carrinho)
            {
                Console.WriteLine(item.Codigo);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Preco);
                Console.WriteLine(item.Quantidade + "\n");
            }

        }
    }
}
