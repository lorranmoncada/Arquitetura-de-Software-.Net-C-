using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Factory_Method
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public void Open()
        {
            Console.WriteLine("Abrindo conexão");
            Opened = true;
        }

        public void ExecuteCommand(string comando)
        {
            Console.WriteLine($"executando o comando: {comando}");
        }

        public void Close()
        {
            Console.WriteLine("Fechando coneexão");
            Opened = false;
        }

    }
}
