using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_biblioteca_express
{
    class Cls_conexion
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;database=database_itn_test;";
        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
