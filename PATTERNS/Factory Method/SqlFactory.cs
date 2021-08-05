namespace PATTERNS.Factory_Method
{
    // Concrete Creator
    public class SqlFactory : DbFactory
    {
        // Factory Methos da classe abstrata DbFactory
        public override DbConnector CreateConnector(string connectionString)
        {
            // Retorna o produto concreto
            return new SqlServerDbConnection(connectionString);
        }
    }
}
