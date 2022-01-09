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
        public static string codigo_libro { get; set; }
        public void verif_Libro(string codigo, Form principal)
        {
            try
            {
                string query = "SELECT * FROM tb_libro WHERE codigo = '" + codigo + "'" + "AND estatus = '1'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

               
                if (reader.Read())
                {
                    codigo_libro = codigo;
                    Frm_escanear_libro.verificar = true;
                    principal.Close();
                }
                else
                {
                    MessageBox.Show("El libro no se encuentra en la biblioteca");
                    Frm_escanear_libro.verificar = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
           
        }

        public void agregar_libro(DataGridView dgv, string codigo)
        {
            try
            {
                //trae el codigo del libro que se escaneo y lo busca para ver si hay disoibles en la base e datos
                //y tambien trae la forma para cerrala desde aqui---------------------------------------------------------------

                DateTime fecha_actual = Convert.ToDateTime(DateTime.Now.ToString("d"));
                DateTime fecha_dev = fecha_actual.AddDays(3);

                //verifica si existe el codigo del libro en la base de datos y si ya esta en uso o esta disponible--------------
                string query = "SELECT * FROM tb_libro WHERE codigo = '" + codigo + "'" + "AND estatus = '1'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

               
                if (reader.Read())
                {
                    //se agrega el id del alumno, id del libro y las fechas tato de saida como de devolucion----------------
                    dgv.Rows.Add(Cls_alumno.id_alumno, reader.GetString(0), reader.GetString(1), reader.GetString(2), fecha_dev.ToString("d"));
                }
                
                else
                {
                    MessageBox.Show("El libro no se encuentra en la biblioteca");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
           
        }
        public void registrar_pedido(DataGridView pedidosdgv)
        {
            try
            {
                //despues de tener los libros que se prestaran listos en la tabla de prestamos, se guadan en la tabla de prestamos
                for (int i = 0; i < pedidosdgv.Rows.Count; i++)
                {
                    string query = "INSERT INTO `tb_prestamos`(`id_alumno`, `id_libro`, `fecha_salida`, `fecha_devolucion`) VALUES ('" + pedidosdgv[0, i].Value.ToString() + "', '" + pedidosdgv[1, i].Value.ToString() + "', '" + DateTime.Now.ToString("d") + "', '" + pedidosdgv[4, i].Value.ToString() + "');";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    cambiar_estatus_libro(pedidosdgv[1, i].Value.ToString()); //cambiar estado de disponibilidad de los libros
                }
                MessageBox.Show("Se registro el pedido");
                pedidosdgv.Rows.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
           
        }

        public void cambiar_estatus_libro(string id_libro)
        {
            try
            {
                string query = "UPDATE `tb_libro` SET `estatus`='2' WHERE id_libro = " + "'" + id_libro + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
          
        }

        public void renovar_libro(string fecha_de_devolucion, string id_prestamo)
        {
            try
            {
                DateTime fecha_actual = Convert.ToDateTime(fecha_de_devolucion);
                DateTime fecha_dev = fecha_actual.AddDays(3);
                string query = "UPDATE `tb_prestamos` SET `fecha_devolucion`= " + "'" + fecha_dev.ToString("d") + "'" + "WHERE id_prestamo = " + "'" + id_prestamo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Se renovo el libro");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
            
        }

        public void devolver_libro(string id_libro,string id_prestamo)
        {
            try
            {
                string query = "UPDATE `tb_libro` SET `estatus`= '1'" + "WHERE id_libro = " + "'" + id_libro + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                eliminar_libro_prestamo(id_prestamo);

                MessageBox.Show("Se devolvio el libro");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
          
        }

        public void eliminar_libro_prestamo(string id_prestamo)
        {
            try
            {
                string query = "DELETE FROM `tb_prestamos` WHERE id_prestamo = " + "'" + id_prestamo + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema, comuniquese con el equipo de sistemas");
            }
           
        }
    }
}
