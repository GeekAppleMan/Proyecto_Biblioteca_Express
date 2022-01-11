using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_biblioteca_express
{
    class Cls_bitacora : Cls_conexion
    {

        public void Registrar_bitacora(string codigo, string usuario,int concepto)
        {
            string query = "INSERT INTO `tb_bitacora`(`codigo`, `usuario`, `fecha`, `concepto`) VALUES ('" + codigo + "', '" + usuario + "', '" + DateTime.Now.ToString("d") + "', '" + concepto + "');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
        }


    }
}
