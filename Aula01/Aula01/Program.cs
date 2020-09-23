using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {

            Categoria c1 = new Categoria();
            c1.codigo = 1;
            c1.nome = "Bebida";


            Produto p1 = new Produto();
            p1.ativo = true;
            p1.codigo = 1;
            p1.nome = "Coca-Cola";
            p1.precoDeVenda = 8.50;
            p1.quantidade = 10;
            p1.categoria = c1;

            Produto p2 = new Produto();
            p2.ativo = true;
            p2.codigo = 2;
            p2.nome = "Heiniken";
            p2.precoDeVenda = 6.99;
            p2.quantidade = 12;
            p2.categoria = new Categoria();
            p2.categoria.codigo = 2;
            p2.categoria.nome = "Cervejas";

            Console.WriteLine("Código:" + p1.codigo);
            Console.WriteLine("Nome:" + p1.nome);
            Console.WriteLine("Preço de venda:" + p1.precoDeVenda);
            Console.WriteLine("Quantidade:" + p1.quantidade);
            Console.WriteLine("Ativo:" + p1.ativo);
            Console.WriteLine("Categoria");
            Console.WriteLine("Código:" + p1.categoria.codigo);  //ou Console.WriteLine("Código:" + c1.codigo);
            Console.WriteLine("Nome:" + p1.categoria.nome);  //ou Console.WriteLine("Nome:" + c1.nome);



            Console.WriteLine("\nCódigo:" + p2.codigo);
            Console.WriteLine("Nome:" + p2.nome);
            Console.WriteLine("Preço de venda:" + p2.precoDeVenda);
            Console.WriteLine("Quantidade:" + p2.quantidade);
            Console.WriteLine("Ativo:" + p2.ativo);
            Console.WriteLine("Categoria");
            Console.WriteLine("Código:" + p2.categoria.codigo);
            Console.WriteLine("Nome:" + p2.categoria.nome);

        }
    }
}
