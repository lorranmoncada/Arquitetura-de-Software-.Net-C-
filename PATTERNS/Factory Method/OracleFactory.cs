namespace PATTERNS.Factory_Method
{
    // Concrete Creator
    public class OracleFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new OracleDbConnection(connectionString);
        }
    }
}
