using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_biblioteca_express
{
    public partial class Frm_inf_alumno : Form
    {
        Cls_alumno obj_prestamos = new Cls_alumno();
        Cls_libro obj_libro = new Cls_libro();
        public static DataTable pedidos = new DataTable();
        public Frm_inf_alumno()
        {
            InitializeComponent();
        }

        private void Frm_inf_alumno_Load(object sender, EventArgs e)
        {
            if (pedidos.Columns.Count == 0)
            {
                pedidos.Columns.Add("id_alumno");
                pedidos.Columns.Add("id_libro");
                pedidos.Columns.Add("fecha_salida");
                pedidos.Columns.Add("fecha_dev");
            }
            cargar_prestamos();
        }

        private void cargar_prestamos()
        {
            dgv_prestamos.Rows.Clear();
            obj_prestamos.prestamos_alumno(dgv_prestamos);
        }

        private void Frm_inf_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_escanear_matricula_alumno obj_alumno = new Frm_escanear_matricula_alumno();
            obj_alumno.Show();
            dgv_prestamos.Rows.Clear();
            Cls_libro.pedidos.Rows.Clear();
            Cls_libro.pedidos.Columns.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_escanear_libro obj_escanear_libro = new Frm_escanear_libro();
            obj_escanear_libro.ShowDialog();
            if (Cls_libro.codigo_libro == 0 || Cls_libro.nombre == null || Cls_libro.fecha_devolucion == null)
            {

            }
            else
            {
                dgv_pedidos.Rows.Add(Cls_libro.codigo_libro, Cls_libro.nombre, Cls_libro.fecha_devolucion);
            }
        }

        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 3)
                {
                    Cls_libro.pedidos.Rows.RemoveAt(e.RowIndex);
                    dgv_pedidos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_registrar_pedido_Click(object sender, EventArgs e)
        {
            obj_libro.registrar_pedido(dgv_pedidos);
            cargar_prestamos();
        }

        private void dgv_prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 4)
                {
                    obj_libro.renovar_libro(dgv_prestamos[3, e.RowIndex].Value.ToString(), e.RowIndex);
                    cargar_prestamos();
                }
                if (e.ColumnIndex == 5)
                {
                    obj_libro.devolver_libro(e.RowIndex);
                    cargar_prestamos();
                }
            }
        }
    }
}
