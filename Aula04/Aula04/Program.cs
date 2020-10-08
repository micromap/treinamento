using System;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Codigo = 1;
            produto.Nome = "Coca Coca";
            produto.Preco = 10.00;
            produto.Quantidade = 15;

            ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Inserir(produto);

            Console.WriteLine("\n");

            Categoria categoria = new Categoria();
            categoria.Codigo = 1;
            categoria.Nome = "Doces";

            CategoriaRepositorioImpl categoriaRepositorio = new CategoriaRepositorioImpl();
            categoriaRepositorio.inserir(categoria);
            categoriaRepositorio.buscar(2);

            Console.WriteLine("\n");

            Pessoa pessoa = new Pessoa();
            pessoa.Codigo = 1;
            pessoa.Nome = "Marlon Vieira Balielo";

            PessoaRepositorioImpl pessoaRepositorio = new PessoaRepositorioImpl();
            pessoaRepositorio.inserir(pessoa);
            pessoaRepositorio.buscar(2);
        }
    }
}
