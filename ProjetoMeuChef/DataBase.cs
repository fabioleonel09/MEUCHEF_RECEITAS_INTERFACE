using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMeuChef
{
    public class DataBase
    {
        private static string connectionString = @"Data Source=DESKTOP-N8EH36C\PARTICULARSQL;Initial Catalog=MEUCHEFRECEITAS;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
