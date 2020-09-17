using System;

namespace DAula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria c1 = new Categoria();
            c1.codigo = 1;
            c1.nome = "Bebidas";

            Produto p1 = new Produto();
            p1.codigo = 1;
            p1.nome = "CHOPP 30l";
            p1.precoDeVenda = 240.50;
            p1.quantidade = 450;
            p1.ativo = true;
            p1.categoria = c1;
            
            Produto p2 = new Produto();
            p2.codigo = 2;
            p2.nome = "Skol";
            p2.precoDeVenda = 44.00;
            p2.quantidade = 40;
            p2.ativo = true;
            //p2.categoria = c1;
            p2.categoria = new Categoria();
            p2.categoria.codigo = 2;
            p2.categoria.nome = "Cervejas";


            Console.WriteLine("Codigo:" + p1.codigo);
            Console.WriteLine("Nome:" + p1.nome);
            Console.WriteLine("Preco de Venda:" + p1.precoDeVenda);
            Console.WriteLine("Quantidade:" + p1.quantidade);
            Console.WriteLine("      Categoria      " );
            Console.WriteLine("Codigo:" + p1.categoria.codigo);
            Console.WriteLine("Nome:" + p1.categoria.nome);

            Console.WriteLine("\nCodigo:" + p2.codigo);
            Console.WriteLine("Nome:" + p2.nome);
            Console.WriteLine("Preco de Venda:" + p2.precoDeVenda);
            Console.WriteLine("Quantidade:" + p2.quantidade);
            Console.WriteLine("      Categoria      ");
            Console.WriteLine("Codigo:" + p2.categoria.codigo);
            Console.WriteLine("Nome:" + p2.categoria.nome);

        }

    }
}
