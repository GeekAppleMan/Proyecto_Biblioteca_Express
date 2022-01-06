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
    public partial class Frm_regresar_libro : Form
    {
        Cls_libro obj_libro = new Cls_libro();
        public static int index { get; set; }
        public static string codigo { get; set; }
        public Frm_regresar_libro()
        {
            InitializeComponent();
        }

        private void Frm_regresar_libro_Load(object sender, EventArgs e)
        {

        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {
            verificar();
        }

        private void verificar()
        {
            if (codigo == txtCodigo.Text)
            {
                obj_libro.devolver_libro(index);
                this.Close();
            }
            else
            {
                MessageBox.Show("El codigo del libro no coincide");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificar();
                txtCodigo.Text = "";
            }
        }
    }
}
