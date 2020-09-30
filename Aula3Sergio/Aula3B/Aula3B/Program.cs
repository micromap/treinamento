using System;

namespace Aula3B
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            pessoaJuridica.Pessoa = new Pessoa();
            pessoaJuridica.Pessoa.Codigo = 1;
            pessoaJuridica.Pessoa.Criacao = DateTime.Now;

            pessoaJuridica.CNPJ = "45.252.365/0001-55";
            pessoaJuridica.RazaoSocial = "GEMMAP INFORMATICA";
            pessoaJuridica.NomeFantasia = "GEMMAP";

            Console.WriteLine("Codigo : " + pessoaJuridica.Pessoa.Codigo);
            Console.WriteLine("Criacao : " + pessoaJuridica.Pessoa.Criacao);
            
            Console.WriteLine("CNPJ : " + pessoaJuridica.CNPJ);
            Console.WriteLine("Razao Social : " + pessoaJuridica.RazaoSocial);
            Console.WriteLine("Nome Fantasia : " + pessoaJuridica.NomeFantasia);
        }
    }
}
