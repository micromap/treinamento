using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.SqlTypes;

namespace Aula5Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Data Source=(DESCRIPTION =(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.0.246)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORC)));User ID=SCRUZ;Password=A";
            
            using (OracleConnection connection = new OracleConnection(con))
            {
                connection.Open();

                Console.WriteLine($"Conexão Realizada com Sucesso Versão : {connection.ServerVersion}  HostName: {connection.HostName}");

                String SQL = @"INSERT INTO B_MARCA_EPI (NRO,DESCRICAO) VALUES (:NRO, :DESCRICAO)";

                using var comando = new OracleCommand(SQL, connection);
                comando.Parameters.Add(new OracleParameter("NRO", 2));
                comando.Parameters.Add(new OracleParameter("DESCRICAO", "ADIDDAS"));
                comando.ExecuteNonQuery();

                Console.WriteLine($"Inclusão Realizada com Sucesso Tabela B_MARCA_EPI");

                String SQL2 = @"SELECT NRO, DESCRICAO FROM B_VINCX ORDER BY 1";

                using var comando2 = new OracleCommand(SQL2, connection);

                using var resultSql = comando2.ExecuteReader();

                while (resultSql.Read())
                {
                    Console.WriteLine($"Código Vínculo    : {resultSql.GetInt32(0)}");
                    Console.WriteLine($"Descrição Vínculo : {resultSql.GetString(1)}");
                }
            }
        }
    }
}
