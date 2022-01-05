using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_biblioteca_express
{
    class Cls_alumno : Cls_conexion
    {

        public void verifAlumno(int matricula)
        {
            string query = "SELECT * FROM tb_alumnos WHERE estatus = '1'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();

            reader = commandDatabase.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                   
                }
            }
            else
            {
                Console.WriteLine("No se encontro al alumno");
            }
        }
    }
}
