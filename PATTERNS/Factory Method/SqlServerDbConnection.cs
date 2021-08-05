using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace PATTERNS.Factory_Method
{
    // CONCRETE PRODUCT
    public class SqlServerDbConnection: DbConnector
    {
        public SqlServerDbConnection(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override DbConnection Connect()
        {
            Console.WriteLine("conectando ao SqlServer");
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
