using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04
{
    class CategoriaRepositorioImpl : CategoriaRepositorio
    {
        public override void buscar(int codigo)
        {
            Categoria categoria = new Categoria();
            categoria.Codigo = 2;
            categoria.Nome = "Bebidas";

            Console.WriteLine("Categoria buscada com sucesso!");
            Console.WriteLine("Código: " + categoria.Codigo);
            Console.WriteLine("Nome: " + categoria.Nome);
        }

        public override void inserir(Categoria categoria)
        {
            Console.WriteLine("\nCategoria inserida com sucesso!");
            Console.WriteLine("Código: " + categoria.Codigo);
            Console.WriteLine("Nome: " + categoria.Nome);
        }

        public void editar()
        {

        }
    }
}
