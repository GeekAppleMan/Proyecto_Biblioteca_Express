using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_biblioteca_express
{
    class Cls_libro : Cls_conexion
    {
        public static int codigo_libro { get; set; }

        public void verif_Libro(int codigo, Form principal)
        {
            string query = "SELECT * FROM tb_libro WHERE matricula = '" + codigo + "'";
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
                    Frm_inf_alumno frm_info_alumno = new Frm_inf_alumno();
                    codigo_libro = Convert.ToInt32(reader.GetString(0));
                    frm_info_alumno.Show();
                    principal.Hide();
                }
            }
            else
            {
                MessageBox.Show("No se encontro el libro");
            }
        }

    }
}
