using System;

namespace Aula03Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();                          // Pessoa
            pessoa.Codigo = 1;
            pessoa.Email = "tamara@gemmap.com.br";
            pessoa.Celular = "14-997583486";
            pessoa.Criacao = DateTime.Now;

            Console.WriteLine("PESSOA");
            Console.WriteLine("Código:" + pessoa.Codigo);
            Console.WriteLine("E-mail:" + pessoa.Email);
            Console.WriteLine("Celular:" + pessoa.Celular);
            Console.WriteLine("Criação:" + pessoa.Criacao);

            PessoaJuridica pessoaJuridica = new PessoaJuridica();  // Pessoa Jurídica
            pessoaJuridica.Codigo = 2;
            pessoaJuridica.Email = "produtos@gmail.com";
            pessoaJuridica.Celular = "14-998561234";
            pessoaJuridica.Criacao = DateTime.Now;
            pessoaJuridica.CNPJ = "01.012.012/0001-12";
            pessoaJuridica.InscricaoEstadual = "123456789";
            pessoaJuridica.RazaoSocial = "Produtos S.A.";
            pessoaJuridica.NomeFantasia = "Produtos Brasil";

            Console.WriteLine("\n");
            Console.WriteLine("PESSOA JURÍDICA");
            Console.WriteLine("Código:" + pessoaJuridica.Codigo);
            Console.WriteLine("E-mail:" + pessoaJuridica.Email);
            Console.WriteLine("Celular:" + pessoaJuridica.Celular);
            Console.WriteLine("Criação:" + pessoaJuridica.Criacao);

            Console.WriteLine("CNPJ:" + pessoaJuridica.CNPJ);
            Console.WriteLine("Inscrição Estadual:" + pessoaJuridica.InscricaoEstadual);
            Console.WriteLine("Razão Social:" + pessoaJuridica.RazaoSocial);
            Console.WriteLine("Nome Fantasia:" + pessoaJuridica.NomeFantasia);

            PessoaFisica pessoaFisica = new PessoaFisica();     //Pessoa Física
            pessoaFisica.Codigo = 3;
            pessoaFisica.Email = "camila@gemmap.com.br";
            pessoaFisica.Celular = "14-996021712";
            pessoaFisica.Criacao = DateTime.Now;
            pessoaFisica.Nome = "Camila Cunha";
            pessoaFisica.CPF = "132.135.463-80";
            pessoaFisica.RG = "47.456.753-3";

            Console.WriteLine("\n");
            Console.WriteLine("PESSOA FÍSICA");
            Console.WriteLine("Código:" + pessoaFisica.Codigo);
            Console.WriteLine("E-mail:" + pessoaFisica.Email);
            Console.WriteLine("Celular:" + pessoaFisica.Celular);
            Console.WriteLine("Nome:" + pessoaFisica.Nome);
            Console.WriteLine("Criação:" + pessoaFisica.Criacao);
            Console.WriteLine("CPF:" + pessoaFisica.CPF);
            Console.WriteLine("RG:" + pessoaFisica.RG);

            Funcionario funcionario = new Funcionario();    //Funcionário
            funcionario.Codigo = 4;
            funcionario.Email = "joao@gemmap.com.br";
            funcionario.Celular = "14-998852634";           //classe Pessoa
            funcionario.Criacao = DateTime.Now;

            funcionario.Nome = "João da Silva";     
            funcionario.CPF = "407.698.587-58";             //classe Pessoa Física
            funcionario.RG = "46.265.389-3";

            funcionario.CTPS = "35697854213";               //classe Funcionário
            funcionario.PIS = "52631544123";

            Console.WriteLine("\n");
            Console.WriteLine("FUNCIONÁRIO");
            Console.WriteLine("Código:" + funcionario.Codigo);
            Console.WriteLine("E-mail:" + funcionario.Email);
            Console.WriteLine("Celular:" + funcionario.Celular);
            Console.WriteLine("Criação:" + funcionario.Criacao);
            Console.WriteLine("Nome:" + funcionario.Nome);
            Console.WriteLine("CPF:" + funcionario.CPF);
            Console.WriteLine("RG:" + funcionario.RG);
            Console.WriteLine("CTPS:" + funcionario.CTPS);
            Console.WriteLine("PIS:" + funcionario.PIS);
        }
    }
}
