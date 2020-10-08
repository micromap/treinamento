using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04
{
    class PessoaRepositorioImpl : PessoaRepositorio
    {
        public void buscar(int codigo)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Codigo = 2;
            pessoa.Nome = "Alessandro Maitan Balielo";

            Console.WriteLine("\nPessoa buscada com sucesso!");
            Console.WriteLine("Código: " + pessoa.Codigo);
            Console.WriteLine("Nome: " + pessoa.Nome);

        }

        public void inserir(Pessoa pessoa)
        {
            Console.WriteLine("\nPessoa Inserida com sucesso!");
            Console.WriteLine("Código: " + pessoa.Codigo);
            Console.WriteLine("Nome: " + pessoa.Nome);

        }
    }
}
