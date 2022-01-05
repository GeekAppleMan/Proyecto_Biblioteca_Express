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
        public Frm_escanear_matricula_alumno()
        {
            InitializeComponent();
        }

        public void Scan()
        {
            int matric = Convert.ToInt32(txtMatricula.Text);
            Cls_alumno clsalumno = new Cls_alumno();

            clsalumno.verifAlumno(matric,this);
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Scan();
            }
        }
    }
}
