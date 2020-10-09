using System;

namespace Aula4Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Codigo = 1;
            produto.Nome = "Teclado";
            produto.Preco = 56.80;
            produto.Quantidade = 2;

            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.BuscarCodigo(produto.Codigo);

            produtoDAO.Inserir(produto);

            produtoDAO.Alterar(produto);
        }
    }
}
