using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Npgsql;

namespace Aula5
{
    class Conexao
    {

        private static string textoDaConexao = "Host=localhost;Username=postgres;Password=oramap82;Database=gemmap";

        public static NpgsqlConnection ConectarNaBase()
        {
            var conexao = new NpgsqlConnection(textoDaConexao);

            return conexao;

        }
       
    }
}
