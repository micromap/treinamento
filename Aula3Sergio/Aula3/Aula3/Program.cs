using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = 1;
            funcionario.Criacao = DateTime.Now;

            funcionario.CPF = "315.525.666-55";
            funcionario.DtNascimento = DateTime.Parse("10/09/1990");
            funcionario.Nome = "Carlos Mendes";

            funcionario.CTPS = "123456";
            funcionario.PIS = "12345678912";
            funcionario.Salario = 1200.00;

            Console.WriteLine("Pessoa");

            Console.WriteLine("Código " + funcionario.Codigo);
            Console.WriteLine("Criação " + funcionario.Criacao);

            Console.WriteLine("\nPessoa Fisica");
            Console.WriteLine("CPF " + funcionario.CPF);
            Console.WriteLine("Data Nascimento " + funcionario.DtNascimento);
            Console.WriteLine("Nome " + funcionario.Nome);

            Console.WriteLine("\nFuncionario");
            Console.WriteLine("CTPS " + funcionario.CTPS);
            Console.WriteLine("PIS " + funcionario.PIS);
            Console.WriteLine("Salário " + funcionario.Salario);
        }
    }
}
