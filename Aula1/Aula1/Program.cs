using System;
using System.Security.Cryptography.X509Certificates;

namespace Aula1
{
    class Program
    {
         
        static void Main(string[] args)
        {
         
            /* Chamar Objeto da Classe, já criando o objeto*/
            Categoria c1 = new Categoria(1, "Cerveja");

            // Isso teria que fazer caso não tivesse o construtor completo.
            //            c1.codigo = 1;
            //            c1.nome = "Cerveja";
            // Aqui só imprime a linha, não de importancia
            //            Console.WriteLine("Cód. Categoria: " + c1.codigo);
            //            Console.WriteLine("Nome Categoria: " + c1.nome);
            

            Produto p1 = new Produto(1, "Heineken", 10, true, DateTime.Now, Categoria);
            
            // Isso teria que fazer caso não tivesse o construtor completo.
            //            p1.codigo = 1;
            //            p1.nome = "Coca-Cola";
            //            p1.categoria = c1;

            //Console.WriteLine("\nCódigo: " + p1.codigo);
            //Console.WriteLine("Nome: " + p1.nome);
            //Console.WriteLine("Cat. Código: " + p1.categoria.codigo);
            //Console.WriteLine("Cat. Nome: " + p1.categoria.nome);

            // Aqui eu já usei o exemplo de utilizar o construtor padrão
            Produto p2 = new Produto();

            p2.codigo = 2;
            p2.nome = "Coca-Cola";
           

            // Este erro é porque não criei o construtor padrão na Classe Categoria. Fiz isso de propósito em Car....
            p2.categoria = new Categoria();

            // Aqui só imprime na tela, não quero imprimir Saporra
            //Console.WriteLine("\nCódigo: " + p2.codigo);
            //Console.WriteLine("Nome: " + p2.nome);
            //Console.WriteLine("Cat. Código: " + p2.categoria.codigo);
            //Console.WriteLine("Cat. Nome: " + p2.categoria.nome);



        }
    }
}
