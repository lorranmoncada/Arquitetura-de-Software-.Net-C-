using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace PATTERNS.Factory_Method
{
    public static class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlConect = DbFactory.Database(DataBase.Postgres)
                .CreateConnector("Server=ec2-52-1-115-6.compute-1.amazonaws.com;port=5432;user id = jzjloqyluahlcb; password = 5b3c3b902c1ba0489f6ae9b7cb7cb4606efde55cdab19f27e315d1ab4e3ac5ce;database=d6ofl3du8qq3kl;SSL Mode=Require;Trust Server Certificate=true;")
                .Connect();
            var comando = sqlConect.CreateCommand();
            try
            {
                comando.CommandText = "select * from tb_igrejasc LIMIT 2";
                DbDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader);
                    }
                }
                sqlConect.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                sqlConect.Close();
            }
           

            //var dt = new DataTable();
            //dt.Load(reader);
            //DataRow dr = dt.AsEnumerable().FirstOrDefault();
            //var teste = dt.Columns.Cast<dynamic>().ToList();
            
          
        }
    }
}
