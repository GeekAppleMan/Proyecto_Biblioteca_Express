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
            DateTime fecha_dev = new DateTime();
            fecha_dev = DateTime.Now;
            fecha_dev.AddDays(3);
            if (pedidos.Columns.Count == 0)
            {
                pedidos.Columns.Add("id_alumno");
                pedidos.Columns.Add("id_libro");
                pedidos.Columns.Add("fecha_salida");
                pedidos.Columns.Add("fecha_dev");
            }
            string query = "SELECT * FROM tb_libro WHERE codigo = '" + codigo + "'";
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
                MessageBox.Show("No se encontro el libro");
            }
        }
        public void registrar_pedido(Form principal)
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
            }
            MessageBox.Show("Se registro el pedido");
            pedidos.Rows.Clear();
            pedidos.Columns.Clear();
            principal.Close();
        }
    }
}
