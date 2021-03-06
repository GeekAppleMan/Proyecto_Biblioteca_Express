using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Proyecto_biblioteca_express
{
    class Cls_alumno : Cls_conexion
    {
        public static int id_alumno { get; set; }

        public void verif_Alumno(int matricula,Form principal)
        {
            try
            {
                Frm_escanear_matricula_alumno.escaneo = false;
                string query = "SELECT A.id_usuario,A.no_control,A.nombre,A.apellido_p,A.apellido_m,C.carrera,A.foto_perfil FROM tb_usuarios AS A INNER JOIN tb_carrera AS C ON A.id_carrera = C.id_carrera WHERE A.no_control = '" + matricula + "'";
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
                        if (Cls_libro.devolver_libro_2 == true)
                        {
                            Frm_escanear_matricula_alumno.escaneo = true;
                            id_alumno = Convert.ToInt32(reader.GetString(0));
                            principal.Close();
                        }
                        if (Cls_libro.devolver_libro_2 == false)
                        {
                            Frm_escanear_matricula_alumno.escaneo = false;
                            Frm_inf_alumno frm_Inf_Alumno = new Frm_inf_alumno();
                            id_alumno = Convert.ToInt32(reader.GetString(0));

                            frm_Inf_Alumno.lbl_numero_control.Text = reader.GetString(1);
                            frm_Inf_Alumno.lbl_nombres.Text = reader.GetString(2);
                            frm_Inf_Alumno.lbl_apellidos.Text = reader.GetString(3) + " " + reader.GetString(4);
                            frm_Inf_Alumno.lbl_carrera.Text = reader.GetString(5);
                            frm_Inf_Alumno.pic_imagen_alumno.ImageLocation = reader.GetString(6);
                            frm_Inf_Alumno.Show();
                            principal.Hide();
                        }  
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al alumno");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
        }

        public void prestamos_alumno(DataGridView prestamos)
        {
            try
            {
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
                        prestamos.Rows.Add(reader.GetString(0), reader.GetString(5), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
        }
    }
}
