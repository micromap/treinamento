using Npgsql;

namespace Aula06Sergio
{
    class ProdutoRepositorio
    {
        private string textoDaConexão = "Host=192.168.0.206;UserName=postgres;Password=oramap82;Database=Tamara";
        public void Inserir(Produto produto)
        {
            using var conexao = new NpgsqlConnection(textoDaConexão);

            conexao.Open();

            string sql = @"
                         INSERT INTO produtos (nome, preco, quantidade)
                         VALUES (@nome, @preco, @quantidade)
            ";

            using var comando = new NpgsqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("nome", produto.Descricao);
            comando.Parameters.AddWithValue("preco", produto.Preco);
            comando.Parameters.AddWithValue("quantidade", produto.Quantidade);

            comando.ExecuteNonQuery();
        }

        public void Excluir(int codigo)
        {
            using var conexao = new NpgsqlConnection(textoDaConexão);

            conexao.Open();

            string sql = @"
                         DELETE FROM produtos
                         WHERE codigo = @codigo
            ";

            using var comando = new NpgsqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("codigo", codigo);

            comando.ExecuteNonQuery();
        }

        public void Editar(Produto produto)
        {
            using var conexao = new NpgsqlConnection(textoDaConexão);

            conexao.Open();

            string sql = @"
                         UPDATE produtos 
                         SET nome = @nome, preco = @preco, quantidade = @quantidade
                         WHERE codigo = @codigo
            ";

            using var comando = new NpgsqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("codigo", produto.Codigo);
            comando.Parameters.AddWithValue("nome", produto.Descricao);
            comando.Parameters.AddWithValue("preco", produto.Preco);
            comando.Parameters.AddWithValue("quantidade", produto.Quantidade);

            comando.ExecuteNonQuery();
        }
    }
    
}
