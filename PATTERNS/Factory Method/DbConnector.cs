using System.Data.Common;

namespace PATTERNS.Factory_Method
{
    // Abstract Product
    // Classe para se conectar com qualquer banco de dados
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public abstract DbConnection Connect();
        protected string ConnectionString {get;set;}
    }
}
