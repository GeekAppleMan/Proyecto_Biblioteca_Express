using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_biblioteca_express.Principal
{
    public partial class Frm_registrar_libro : Form
    {
        public Frm_registrar_libro()
        {
            InitializeComponent();
        }
        Random rdm_caracter = new Random();
        string codigo_final;

        private void Frm_registrar_libro_Load(object sender, EventArgs e)
        {
            generar_codigo();
        }
        
        public void generar_codigo()
        {
            string codigo = "";
            for (int i = 0; i < 8; i++)
            {
                char letra = (char)(((int)'A') + rdm_caracter.Next(26));
                codigo += letra;
                codigo += rdm_caracter.Next(9);
            }
            codigo_final = codigo;
        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {

        }
    }
}
