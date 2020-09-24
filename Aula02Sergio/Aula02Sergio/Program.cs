using System;
using System.Threading.Tasks.Dataflow;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();

            Console.WriteLine("\n\nCódigo:" + produto1.codigo);
            Console.WriteLine("Nome:" + produto1.nome);
            Console.WriteLine("Quantidade:" + produto1.quantidade);
            Console.WriteLine("Preço:" + produto1.preco);

            Produto produto2 = new Produto(1, "Coca-Cola", 15, 8.99);

            Console.WriteLine("\n\nCódigo:" + produto2.codigo);
            Console.WriteLine("Nome:" + produto2.nome);
            Console.WriteLine("Quantidade:" + produto2.quantidade);
            Console.WriteLine("Preço:" + produto2.preco);

            Produto produto3 = new Produto("Fanta", 6);

            Console.WriteLine("\n\nCódigo:" + produto3.codigo);
            Console.WriteLine("Nome:" + produto3.nome);
            Console.WriteLine("Quantidade:" + produto3.quantidade);
            Console.WriteLine("Preço:" + produto3.preco);

        }
    }
}
