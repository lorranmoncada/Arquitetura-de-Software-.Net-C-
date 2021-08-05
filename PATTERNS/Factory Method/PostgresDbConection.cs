using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Factory_Method
{
    // Produto concreto
    public class PostgresDbConection : DbConnector
    {
        public PostgresDbConection(string connectionString):base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override DbConnection Connect()
        {
            Console.WriteLine("conectando com banco postgres");
            var conexao = new NpgsqlConnection(ConnectionString);
            conexao.Open();

            return conexao;
        }
    }
}
