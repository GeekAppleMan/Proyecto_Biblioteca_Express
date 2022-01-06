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
        public Frm_escanear_libro()
        {
            InitializeComponent();
        }

        private void Frm_escanear_libro_Load(object sender, EventArgs e)
        {

        }
        public void Scan()
        {
            string codig = txtCodigo.Text;
            Cls_libro obj_libro = new Cls_libro();
            obj_libro.verif_Libro(codig,this);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            Cls_libro.codigo_libro = null;
            Cls_libro.nombre = null;
            Cls_libro.fecha_devolucion = null;
        }

    }
}
