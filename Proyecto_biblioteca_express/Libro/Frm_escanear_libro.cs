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
            Cls_libro.codigo_libro = 17340346;
        }
        public void Scan()
        {
            int codig = Convert.ToInt32(txtCodigo.Text);
            Cls_libro obj_libro = new Cls_libro();

            obj_libro.verif_Libro(codig, this);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Scan();
            }
        }
    }
}
