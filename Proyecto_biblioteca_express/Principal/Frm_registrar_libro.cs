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
            Cls_libro ob = new Cls_libro();
            if (ob.veriricar_codigo_libro(codigo) == true)
            {
                generar_codigo();
            }
            else
            {
                codigo_final = codigo;
            }
        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Registrar El Libro Con El Nombre "+ txtNombre.Text + "?", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Necesita Ingresar Un Nombre Para El Libro");
                }
                else
                {
                    new Cls_libro().Registrar_libro(txtNombre.Text, codigo_final,this);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
