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
        public static DataTable pedidos = new DataTable();
        public static int codigo_libro { get; set; }
        public static string nombre { get; set; }
        public static string fecha_devolucion { get; set; }

        public void verif_Libro(int codigo, Form principal)
        {   
            DateTime fecha_actual = Convert.ToDateTime(DateTime.Now.ToString("d"));
            DateTime fecha_dev = fecha_actual.AddDays(3);
            if (pedidos.Columns.Count == 0)
            {
                pedidos.Columns.Add("id_alumno");
                pedidos.Columns.Add("id_libro");
                pedidos.Columns.Add("fecha_salida");
                pedidos.Columns.Add("fecha_dev");
            }
            string query = "SELECT * FROM tb_libro WHERE codigo = '" + codigo + "'" + "AND estatus = '1'";
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
                    pedidos.Rows.Add(Cls_alumno.id_alumno, reader.GetString(0), DateTime.Now.ToString("d"), fecha_dev.ToString("d"));
                    codigo_libro = Convert.ToInt32(reader.GetString(1));
                    nombre = reader.GetString(2);
                    fecha_devolucion = fecha_dev.ToString("d");
                    principal.Close();
                }
            }
            else
            {
                MessageBox.Show("El libro no se encuentra en la biblioteca");
                codigo_libro = 0;
                nombre = null;
                fecha_devolucion = null;
            }
        }
        public void registrar_pedido(DataGridView pedidosdgv)
        {
            for (int i = 0; i < pedidos.Rows.Count; i++)
            {
                string query = "INSERT INTO `tb_prestamos`(`id_alumno`, `id_libro`, `fecha_salida`, `fecha_devolucion`) VALUES ('" + pedidos.Rows[i]["id_alumno"].ToString() + "', '" + pedidos.Rows[i]["id_libro"].ToString() + "', '" + pedidos.Rows[i]["fecha_salida"].ToString() + "', '" + pedidos.Rows[i]["fecha_dev"].ToString() + "');";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                cambiar_estatus_libro(pedidos.Rows[i]["id_libro"].ToString());
            }
            MessageBox.Show("Se registro el pedido");
            pedidosdgv.Rows.Clear();
            pedidos.Rows.Clear();
            pedidos.Columns.Clear();
        }

        public void cambiar_estatus_libro(string id_libro)
        {
            string query = "UPDATE `tb_libro` SET `estatus`='2' WHERE id_libro = " + "'" + id_libro + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
        }

        public void renovar_libro(string fecha_de_devolucion, int index)
        {
            DateTime fecha_actual = Convert.ToDateTime(fecha_de_devolucion);
            DateTime fecha_dev = fecha_actual.AddDays(3);
            string query = "UPDATE `tb_prestamos` SET `fecha_devolucion`= " + "'" + fecha_dev.ToString("d") + "'" + "WHERE id_prestamo = " + "'" + Cls_alumno.id_prestamos.Rows[index]["id_prestamo"].ToString() + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            MessageBox.Show("Se renovo el libro");
        }

        public void devolver_libro(int index)
        {
            string query = "UPDATE `tb_libro` SET `estatus`= '1'" + "WHERE id_libro = " + "'" + Cls_alumno.id_prestamos.Rows[index]["id_libro"].ToString() + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            eliminar_libro_prestamo(index);
            MessageBox.Show("Se devolvio el libro");
            Cls_alumno.id_prestamos.Rows.RemoveAt(index);
        }

        public void eliminar_libro_prestamo(int index)
        {
            string query = "DELETE FROM `tb_prestamos` WHERE id_prestamo = " + "'" + Cls_alumno.id_prestamos.Rows[index]["id_prestamo"].ToString() + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
        }
    }
}
