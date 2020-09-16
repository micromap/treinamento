using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula1
{
    class Program
    {
         
        static void Main(string[] args)
        {
         
            /* Chamar Objeto da Classe*/
            Categoria c1 = new Categoria();

            c1.codigo = 1;
            c1.nome = "Cerveja";

            Console.WriteLine("Cód. Categoria: " + c1.codigo);
            Console.WriteLine("Nome Categoria: " + c1.nome);


            Produto p1 = new Produto();     

            p1.codigo = 1;
            p1.nome = "Coca-Cola";
            p1.categoria = c1;

            Console.WriteLine("\nCódigo: " + p1.codigo);
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Cat. Código: " + p1.categoria.codigo);
            Console.WriteLine("Cat. Nome: " + p1.categoria.nome);

            Produto p2 = new Produto();

            p2.codigo = 1;
            p2.nome = "Coca-Cola";
           
            p2.categoria = new Categoria();

            Console.WriteLine("\nCódigo: " + p2.codigo);
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Cat. Código: " + p2.categoria.codigo);
            Console.WriteLine("Cat. Nome: " + p2.categoria.nome);



        }
    }
}
