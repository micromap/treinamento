using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Codigo     = 1;
            produto1.Nome       = "Violão";
            produto1.Preco      = 1500.00;
            produto1.Validade   = DateTime.Now;

            Produto produto2 = new Produto(2,"Corda", 15.50,DateTime.Now);


            Console.WriteLine(" O produto " + produto1.Codigo + " " + produto1.Nome + "\n Custa: R$" + produto1.Preco + "\n Valido até " + produto1.Validade);
            Console.WriteLine("\n O produto " + produto2.Codigo + " " + produto2.Nome + "\n Custa: R$" + produto2.Preco + "\n Valido até " + produto2.Validade);
        }
    }
}
