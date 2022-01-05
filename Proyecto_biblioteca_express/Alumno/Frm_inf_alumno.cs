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
        public Frm_inf_alumno()
        {
            InitializeComponent();
        }

        private void Frm_inf_alumno_Load(object sender, EventArgs e)
        {
            cargar_prestamos();
        }

        private void cargar_prestamos()
        {
            obj_prestamos.prestamos_alumno(dgv_prestamos);
        }

        private void Frm_inf_alumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_escanear_matricula_alumno obj_alumno = new Frm_escanear_matricula_alumno();
            obj_alumno.Show();
        }
    }
}
