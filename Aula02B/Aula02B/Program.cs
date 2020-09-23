using System;

namespace Aula02B
{
    class Program
    {
        static void Main(string[] args)
        {

            // Observe que o nome dos atributos ou variáveis estão Maiúsculos



            Produto produto = new Produto();

            produto.Codigo = 1;

            Console.WriteLine("Código: " + produto.Codigo);



            Pessoa pessoa = new Pessoa();

            

            pessoa.Codigo = 1;
            pessoa.Nome = "Marcelo";

            Console.WriteLine("Código: " + pessoa.Codigo);
            Console.WriteLine("Nome: " + pessoa.Nome);
        }
    }
}
