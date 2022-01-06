using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_biblioteca_express
{
    class Cls_alumno : Cls_conexion
    {
        public static int id_alumno { get; set; }
        public static DataTable id_prestamos = new DataTable();

        public void verif_Alumno(int matricula,Form principal)
        {
            try
            {
                string query = "SELECT * FROM tb_alumno WHERE matricula = '" + matricula + "'";
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
                        Frm_inf_alumno frm_Inf_Alumno = new Frm_inf_alumno();
                        id_alumno = Convert.ToInt32(reader.GetString(0));
                        frm_Inf_Alumno.lbl_numero_control.Text = reader.GetString(1);
                        frm_Inf_Alumno.lbl_nombres.Text = reader.GetString(2);
                        frm_Inf_Alumno.lbl_apellidos.Text = reader.GetString(3);
                        frm_Inf_Alumno.lbl_carrera.Text = reader.GetString(4);
                        frm_Inf_Alumno.Show();
                        principal.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al alumno");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
        }

        public void prestamos_alumno(DataGridView prestamos)
        {
            try
            {
                if (id_prestamos.Columns.Count == 0)
                {
                    id_prestamos.Columns.Add("id_prestamo");
                    id_prestamos.Columns.Add("id_libro");
                }
                string query = "SELECT p.id_prestamo,l.codigo,l.nombre,p.fecha_salida,fecha_devolucion,p.id_libro FROM `tb_prestamos` AS p INNER JOIN tb_libro AS l ON p.id_libro = l.id_libro WHERE p.id_alumno = " + "'" + id_alumno + "'";
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
                        id_prestamos.Rows.Add(reader.GetString(0),reader.GetString(5));
                        prestamos.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema comuniquese con el equipo de sistemas");
            }
        }
    }
}
