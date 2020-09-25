using System;

namespace Aula2Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            produto.Codigo = 10;
            produto.Nome = "COLA COLA";
            produto.Preco = 5.8;
            produto.Quantidade = 2;

            Console.WriteLine("Código     : " + produto.Codigo);
            Console.WriteLine("Nome       : " + produto.Nome);
            Console.WriteLine("Preço      : " + produto.Preco);
            Console.WriteLine("Quantidade : " + produto.Quantidade);

            Console.WriteLine("Quantidade X Preço : " + produto.calculaPrecoTotal(produto.Preco,produto.Quantidade));

            Console.WriteLine(" ");

            Produto produto1 = new Produto(1,"ARROZ",180.25,1);
            Console.WriteLine("Código     : " + produto1.Codigo);
            Console.WriteLine("Nome       : " + produto1.Nome);
            Console.WriteLine("Preço      : " + produto1.Preco);
            Console.WriteLine("Quantidade : " + produto1.Quantidade);

            Console.WriteLine("Quantidade X Preço : " + produto.calculaPrecoTotal(produto1.Preco, produto1.Quantidade));

            Console.WriteLine(" ");

            Console.WriteLine(produto1.ToString());
        }
    }
}
