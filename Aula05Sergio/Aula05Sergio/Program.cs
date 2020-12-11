using System;
using Npgsql;

namespace Aula05Sergio
{
    class Program
    {
        static void Main1(string[] args)
        {
            string textoDaConexao = "Host=192.168.0.206;UserName=postgres;Password=oramap82;Database=Tamara";

            using var conexao = new NpgsqlConnection(textoDaConexao); //~usar o using para não precisar encerrar a conexão

            conexao.Open();

            string sql = @"
                         INSERT INTO produtos (nome, preco, quantidade) 
                         VALUES (@nome, @preco, @quantidade)
                         ";

            using var comando = new NpgsqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("nome", "Heineken");
            comando.Parameters.AddWithValue("preco", 8.00);
            comando.Parameters.AddWithValue("quantidade", 25);

            comando.ExecuteNonQuery(); //executa o comando INSERT, DELETE E UPDATE
        }

        static void Main(string[] args)
        {
            string textoDaConexao = "Host=192.168.0.206;UserName=postgres;Password=oramap82;Database=Tamara";

            using var conexao = new NpgsqlConnection(textoDaConexao); //~usar o using para não precisar encerrar a conexão

            conexao.Open();

            string sql = @"
                         SELECT codigo, nome, preco, quantidade
                         FROM produtos
                         ORDER BY nome
                         ";

            using var comando = new NpgsqlCommand(sql, conexao);

            using var resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                Console.WriteLine("Código: " + resultado.GetInt32(0));
                Console.WriteLine("Nome: " + resultado.GetString(1));
                Console.WriteLine("Preço: " + resultado.GetDecimal(2));
                Console.WriteLine("Quantidade: " + resultado.GetInt32(3) + "\n");
            }
        }
    }
}
