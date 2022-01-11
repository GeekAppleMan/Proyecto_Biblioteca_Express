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
        Frm_regresar_libro obj_regresar = new Frm_regresar_libro();
        public Frm_inf_alumno()
        {
            InitializeComponent();
        }

        private void Frm_inf_alumno_Load(object sender, EventArgs e)
        {
            cargar_prestamos();
            Frm_escanear_libro.dgv = dgv_pedidos;
            obj_libro.agregar_libro(dgv_pedidos, Cls_libro.codigo_libro);
            Frm_escanear_libro.verificar = false;
        }

        private void cargar_prestamos()
        {
            dgv_prestamos.Rows.Clear();
            obj_prestamos.prestamos_alumno(dgv_prestamos);
        }

        private void Frm_inf_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_escanear_libro_principal obj_alumno = new Frm_escanear_libro_principal();
            obj_alumno.Show();
            dgv_prestamos.Rows.Clear();
        }

 
        private void dgv_pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    dgv_pedidos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgv_prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {

            }
            else
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere renovar?", "ALERTA", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        obj_libro.renovar_libro(dgv_prestamos[5, e.RowIndex].Value.ToString(), dgv_prestamos[0,e.RowIndex].Value.ToString());
                        cargar_prestamos();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }
                   
                }
            }
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            Frm_escanear_libro.dgv = dgv_pedidos;
            Frm_escanear_libro obj_escanear_libro = new Frm_escanear_libro();
            obj_escanear_libro.ShowDialog();
            if (Frm_escanear_libro.verificar == true)
            {
                obj_libro.agregar_libro(dgv_pedidos, Cls_libro.codigo_libro);
            }
            Frm_escanear_libro.verificar = false;
            cargar_prestamos();
        }

        private void btn_registrar_pedido_Click_1(object sender, EventArgs e)
        {
            if (dgv_pedidos.Rows.Count == 0)
            {
                MessageBox.Show("No se han agregado libros");
            }
            else
            {
                obj_libro.registrar_pedido(dgv_pedidos);
                cargar_prestamos();
            }
        }
    }
}
