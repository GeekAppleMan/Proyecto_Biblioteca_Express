using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
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

namespace Proyecto_biblioteca_express
{
    public partial class Frm_generar_qr_reemplazo : Form
    {
        private PrintDocument pdImprimir;

        public Frm_generar_qr_reemplazo()
        {
            InitializeComponent();
        }

        private void btn_virificar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea generar el codigo qr?", "ALERTA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("El campo codigo debe ser completado");
                }
                else
                {
                    generar_QR(txtCodigo.Text.ToUpper());
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
            MessageBox.Show("Se genero el codigo qr");
            this.Close();
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
