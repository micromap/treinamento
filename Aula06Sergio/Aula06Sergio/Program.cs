using System;

namespace Aula06Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var produto = new Produto();
            produto.Descricao = "Fanta 2 Litros";
            produto.Preco = 12.50;
            produto.Quantidade = 50;

            var repositorio = new ProdutoRepositorio();
            repositorio.Inserir(produto);
            */

            /*
            int codigo = 1;
            var repositorio = new ProdutoRepositorio();

            repositorio.Excluir(codigo);
            */

            var produto = new Produto();
            produto.Codigo = 2;
            produto.Descricao = "Carvão 25KG";
            produto.Preco = 25.00;
            produto.Quantidade = 20;

            var repositorio = new ProdutoRepositorio();

            repositorio.Editar(produto);
        }
    }
}
