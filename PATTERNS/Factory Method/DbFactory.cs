using System;

namespace PATTERNS.Factory_Method
{
    // Abstract Creator
    public abstract class DbFactory
    {
        //Factory Method
        // retorna um produto abstrato
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase database)
        {
            if (database == DataBase.SqlServe)
            {
                return new SqlFactory();
            }
            if (database == DataBase.Oracle)
            {
                return new OracleFactory();
            }
            else
            {
                return new PostgresFactory();
            }

            throw new Exception("Erro");
        }

    }
}
