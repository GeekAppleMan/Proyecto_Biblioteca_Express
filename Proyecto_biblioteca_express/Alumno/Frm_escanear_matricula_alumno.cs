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
    public partial class Frm_escanear_matricula_alumno : Form
    {
        public static bool escaneo { get; set; }
        public static Form frm_matricula { get; set; }
        public Frm_escanear_matricula_alumno()
        {
            InitializeComponent();
            frm_matricula = this;
        }

        public void Scan()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Por favor ingrese la matricula del estudiante antes de continuar");
            }
            else
            {
                Cls_alumno clsalumno = new Cls_alumno();
                clsalumno.verif_Alumno(Convert.ToInt32(txtMatricula.Text), this);
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Frm_escanear_matricula_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_escanear_libro_principal.frm_principal_codigo.Show();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_virificar_Click_1(object sender, EventArgs e)
        {
            Scan();
        }

        private void Frm_escanear_matricula_alumno_Load(object sender, EventArgs e)
        {

        }
    }
}
