using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.ativo = true;
            p1.codigo = 1;
            p1.nome = "Guarana";
            p1.precoDeVenda = 3.85;
            p1.quantidade = 15;

            Console.WriteLine("Codigo:" + p1.codigo);
            Console.WriteLine("Nome:" + p1.nome);
            Console.WriteLine("Preço de venda:" + p1.precoDeVenda);
            Console.WriteLine("Quantidade:" + p1.quantidade);
            Console.WriteLine("Ativo:" + p1.ativo);
            Console.WriteLine();

            Produto p2 = new Produto();
            p2.ativo = true;
            p2.codigo = 2;
            p2.nome = "Pacoca";
            p2.precoDeVenda = 2.29;
            p2.quantidade = 3;

            Console.WriteLine("Codigo:" + p2.codigo);
            Console.WriteLine("Nome:" + p2.nome);
            Console.WriteLine("Preço de Venda:" + p2.precoDeVenda);
            Console.WriteLine("Quantidade:" + p1.quantidade);
            Console.WriteLine("Ativo:" + p1.ativo);
            Console.WriteLine();

            Produto p3 = new Produto();
            p3.ativo = true;
            p3.codigo = 3;
            p3.nome = "sal";
            p3.precoDeVenda = 4.65;
            p3.quantidade = 3;

            Console.WriteLine("Codigo:" + p3.codigo);
            Console.WriteLine("Nome:" + p3.nome);
            Console.WriteLine("Preço de venda:" + p3.precoDeVenda);
            Console.WriteLine("Quantidade:" + p3.quantidade);
            
            Console.WriteLine();


        }
    }
}
