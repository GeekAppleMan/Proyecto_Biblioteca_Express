using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

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
        private PrintDocument pdImprimir;

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
                    generar_QR(codigo_final);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        public void generar_QR(string codigo)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(codigo, out qrCode);

            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(180, 180)));
            pcbCodigoQR.Image = imagen;

            // Guardar en el disco duro la imagen (Carpeta del proyecto)
            //imagen.Save("imagen.png", ImageFormat.Png);


            pdImprimir = new System.Drawing.Printing.PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = "POS-58-Series";
            pdImprimir.PrinterSettings = ps;
            pdImprimir.PrintPage += Imprimir;
            pdImprimir.Print();
        }
        void Imprimir(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pcbCodigoQR.Image, new Point(0, 0));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
