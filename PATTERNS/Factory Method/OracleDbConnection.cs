using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.Common;

namespace PATTERNS.Factory_Method
{
    public class OracleDbConnection : DbConnector
    {
        public OracleDbConnection(string connectionString): base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override DbConnection Connect()
        {
            Console.WriteLine("conectando ao Oracle");
            var connection = new OracleConnection(ConnectionString);
            connection.Open();

            return connection;
        }


    }
}
