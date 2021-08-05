using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Factory_Method
{
    // Creador Concreto
    public class PostgresFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new PostgresDbConection(connectionString);
        }
    }
}
