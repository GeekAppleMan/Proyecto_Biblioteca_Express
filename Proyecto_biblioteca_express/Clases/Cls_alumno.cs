using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_biblioteca_express
{
    class Cls_alumno : Cls_conexion
    {
        Frm_inf_alumno frminfoalumno = new Frm_inf_alumno();
        public void verifAlumno(int matricula,Form pricipal)
        {
            

            string query = "SELECT * FROM tb_alumno WHERE matricula = '"+ matricula +"'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();

            reader = commandDatabase.ExecuteReader();

            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    frminfoalumno.Show();
                    pricipal.Hide();
                }
            }
            else
            {
                MessageBox.Show("No se encontro al alumno");
            }
        }
    }
}
