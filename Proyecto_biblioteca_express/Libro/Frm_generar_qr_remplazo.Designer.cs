
namespace Proyecto_biblioteca_express
{
    partial class Frm_generar_qr_reemplazo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_virificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pcbCodigoQR = new System.Windows.Forms.PictureBox();
            this.txtHepter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(159, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 1);
            this.panel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_virificar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 58);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // btn_virificar
            // 
            this.btn_virificar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_virificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_virificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_virificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_virificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_virificar.Location = new System.Drawing.Point(2, 2);
            this.btn_virificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_virificar.Name = "btn_virificar";
            this.btn_virificar.Size = new System.Drawing.Size(275, 54);
            this.btn_virificar.TabIndex = 6;
            this.btn_virificar.Text = "Generar";
            this.btn_virificar.UseVisualStyleBackColor = false;
            this.btn_virificar.Click += new System.EventHandler(this.btn_virificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Location = new System.Drawing.Point(281, 2);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(275, 54);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo del Libro";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(159, 95);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(239, 31);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // pcbCodigoQR
            // 
            this.pcbCodigoQR.Location = new System.Drawing.Point(1256, 18);
            this.pcbCodigoQR.Name = "pcbCodigoQR";
            this.pcbCodigoQR.Size = new System.Drawing.Size(108, 111);
            this.pcbCodigoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCodigoQR.TabIndex = 19;
            this.pcbCodigoQR.TabStop = false;
            // 
            // txtHepter
            // 
            this.txtHepter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHepter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHepter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHepter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHepter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHepter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHepter.Location = new System.Drawing.Point(533, 179);
            this.txtHepter.Name = "txtHepter";
            this.txtHepter.Size = new System.Drawing.Size(25, 31);
            this.txtHepter.TabIndex = 20;
            this.txtHepter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHepter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHepter_KeyPress);
            // 
            // Frm_generar_qr_reemplazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(558, 271);
            this.Controls.Add(this.txtHepter);
            this.Controls.Add(this.pcbCodigoQR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_generar_qr_reemplazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar QR";
            this.Load += new System.EventHandler(this.Frm_generar_qr_reemplazo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCodigoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_virificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pcbCodigoQR;
        private System.Windows.Forms.TextBox txtHepter;
    }
}