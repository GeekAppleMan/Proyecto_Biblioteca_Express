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
    public partial class Frm_escanear_libro : Form
    {
        public static DataGridView dgv { get; set; }
        public static bool verificar { get; set; }
        private bool comprobar { get; set; }
        Cls_libro obj_libro = new Cls_libro();
        public Frm_escanear_libro()
        {
            InitializeComponent();
        }

        private void Frm_escanear_libro_Load(object sender, EventArgs e)
        {

        }

        public void Scan()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Por favor ingrese el codigo antes de continuar");
            }
            else
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (txtCodigo.Text == dgv[2, i].Value.ToString())
                    {
                        comprobar = true;
                    }
                }
                if (comprobar == true)
                {
                    MessageBox.Show("El libro ya fue agregado a tu lista de pedidos");
                    txtCodigo.Text = "";
                    verificar = false;
                }
                else
                {
                    obj_libro.verif_Libro(txtCodigo.Text, this);
                }
                comprobar = false;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Scan();
            }
        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {
            Scan();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_escanear_libro_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtCodigo.Text = "";
        }
    }
}
