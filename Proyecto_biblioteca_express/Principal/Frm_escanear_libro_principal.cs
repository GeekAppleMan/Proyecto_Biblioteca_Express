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
    public partial class Frm_escanear_libro_principal : Form
    {
        Cls_libro obj_libro = new Cls_libro();
        public Frm_escanear_libro_principal()
        {
            InitializeComponent();
        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {
            verificar_libro();
        }

        private void verificar_libro()
        {
            obj_libro.verif_Libro(txtCodigo.Text, this, 1);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificar_libro();
            }
        }

        private void Frm_escanear_libro_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
