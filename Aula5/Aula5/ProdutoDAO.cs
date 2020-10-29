using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5
{
    class ProdutoDAO
    {

        public void InserirProduto(Produtos produto)
        {

            using var conectar = Conexao.ConectarNaBase();

            conectar.Open();

            string sqlinserir = @"INSERT INTO produtos (nome, preco, quantidade)
                            VALUES (@nome, @preco, @quantidade)";

            using var comando = new NpgsqlCommand(sqlinserir, conectar);

            comando.Parameters.AddWithValue("nome", produto.Nome);
            comando.Parameters.AddWithValue("preco", produto.Preco);
            comando.Parameters.AddWithValue("quantidade", produto.Quantidade);

            comando.ExecuteNonQuery();
        }


        public List<Produtos> ListarProdutos()
        {

            Produtos produto = new Produtos();
            List<Produtos> listaprodutos = new List<Produtos>();

            using var conectar = Conexao.ConectarNaBase();

            conectar.Open();

            string sql = @"SELECT codigo,nome,preco,quantidade FROM produtos";

            using var comando = new NpgsqlCommand(sql, conectar);

            using var resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                produto = new Produtos();

                produto.Codigo     = resultado.GetInt32(0);
                produto.Nome       = resultado.GetString(1);
                produto.Preco      = resultado.GetDouble(2);
                produto.Quantidade = resultado.GetInt32(3);

                listaprodutos.Add(produto);
            }

            return listaprodutos;

        }

    }
}
