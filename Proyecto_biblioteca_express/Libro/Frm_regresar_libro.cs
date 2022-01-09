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
        public static string codigo { get; set; }

        public static bool verificar_libro { get; set; }
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
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Por favor ingrese el codigo antes de continuar");
            }
            else
            {
                if (codigo == txtCodigo.Text)
                {
                    verificar_libro = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El codigo del libro no coincide");
                    verificar_libro = false;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                verificar();
                txtCodigo.Text = "";
            }
        }

        private void Frm_regresar_libro_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtCodigo.Text = "";
        }
    }
}
