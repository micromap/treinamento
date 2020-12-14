using System;
using System.Collections.Generic;


namespace Aula07Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Produto();
            p1.Codigo = 1;
            p1.Nome = "Coca Cola";
            p1.Preco = 12.50;
            p1.Quantidade = 15;

            var p2 = new Produto()
            {
                Codigo = 2,
                Nome = "Sprite",
                Preco = 7.50,
                Quantidade = 10
            };

            var p3 = new Produto()
            {
                Codigo = 3,
                Nome = "Fanta",
                Preco = 9.50,
                Quantidade = 17
            };

            //List<Produto> lista = new List<Produto>();
            var lista = new List<Produto>();

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            // Console.WriteLine(lista[1]); //Imprimir a lista

            /*  
            for(int posicao = 0; posicao < lista.Count; posicao++)
              {
                  Console.WriteLine(lista[posicao]);
              }
            */

            foreach (Produto p in lista)
            {
                Console.WriteLine(p);
            }

            var p4 = new Produto();
            p4.Codigo = 2;

            bool achou = lista.Contains(p4);
            Console.WriteLine($"Achou: {achou}");
        }
    }
}
