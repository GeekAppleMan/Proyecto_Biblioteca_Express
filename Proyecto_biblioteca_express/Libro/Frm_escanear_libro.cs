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
    }
}
