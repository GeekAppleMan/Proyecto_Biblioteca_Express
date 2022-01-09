
namespace Proyecto_biblioteca_express
{
    partial class Frm_inf_alumno
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
            this.panel_prestamos_pedidos_botones = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbx_pedidos = new System.Windows.Forms.GroupBox();
            this.panel_pedidos = new System.Windows.Forms.Panel();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_libro2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbx_prestamos = new System.Windows.Forms.GroupBox();
            this.dgv_prestamos = new System.Windows.Forms.DataGridView();
            this.id_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renovar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Devolver = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_registrar_pedido = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pic_imagen_alumno = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.lbl_numero_control = new System.Windows.Forms.Label();
            this.panel_datos_alumno = new System.Windows.Forms.Panel();
            this.panel_prestamos_pedidos_botones.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbx_pedidos.SuspendLayout();
            this.panel_pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.gbx_prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen_alumno)).BeginInit();
            this.panel_datos_alumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_prestamos_pedidos_botones
            // 
            this.panel_prestamos_pedidos_botones.Controls.Add(this.tableLayoutPanel2);
            this.panel_prestamos_pedidos_botones.Controls.Add(this.tableLayoutPanel1);
            this.panel_prestamos_pedidos_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_prestamos_pedidos_botones.Location = new System.Drawing.Point(0, 184);
            this.panel_prestamos_pedidos_botones.Margin = new System.Windows.Forms.Padding(2);
            this.panel_prestamos_pedidos_botones.Name = "panel_prestamos_pedidos_botones";
            this.panel_prestamos_pedidos_botones.Size = new System.Drawing.Size(796, 526);
            this.panel_prestamos_pedidos_botones.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbx_pedidos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbx_prestamos, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(796, 469);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // gbx_pedidos
            // 
            this.gbx_pedidos.Controls.Add(this.panel_pedidos);
            this.gbx_pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_pedidos.Location = new System.Drawing.Point(2, 236);
            this.gbx_pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_pedidos.Name = "gbx_pedidos";
            this.gbx_pedidos.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_pedidos.Size = new System.Drawing.Size(792, 231);
            this.gbx_pedidos.TabIndex = 4;
            this.gbx_pedidos.TabStop = false;
            this.gbx_pedidos.Text = "Pedidos";
            // 
            // panel_pedidos
            // 
            this.panel_pedidos.Controls.Add(this.dgv_pedidos);
            this.panel_pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pedidos.Location = new System.Drawing.Point(2, 17);
            this.panel_pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.panel_pedidos.Name = "panel_pedidos";
            this.panel_pedidos.Size = new System.Drawing.Size(788, 212);
            this.panel_pedidos.TabIndex = 0;
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToResizeColumns = false;
            this.dgv_pedidos.AllowUserToResizeRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.id_libro2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn2});
            this.dgv_pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pedidos.Location = new System.Drawing.Point(0, 0);
            this.dgv_pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            this.dgv_pedidos.RowHeadersVisible = false;
            this.dgv_pedidos.RowHeadersWidth = 51;
            this.dgv_pedidos.RowTemplate.Height = 24;
            this.dgv_pedidos.Size = new System.Drawing.Size(788, 212);
            this.dgv_pedidos.TabIndex = 2;
            this.dgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellClick);
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "id_alumno";
            this.id_alumno.MinimumWidth = 6;
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.ReadOnly = true;
            this.id_alumno.Visible = false;
            // 
            // id_libro2
            // 
            this.id_libro2.HeaderText = "id_libro";
            this.id_libro2.MinimumWidth = 6;
            this.id_libro2.Name = "id_libro2";
            this.id_libro2.ReadOnly = true;
            this.id_libro2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Libro";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de devolucion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Proyecto_biblioteca_express.Properties.Resources.cerrar__1_;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // gbx_prestamos
            // 
            this.gbx_prestamos.Controls.Add(this.dgv_prestamos);
            this.gbx_prestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_prestamos.Location = new System.Drawing.Point(2, 2);
            this.gbx_prestamos.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_prestamos.Name = "gbx_prestamos";
            this.gbx_prestamos.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_prestamos.Size = new System.Drawing.Size(792, 230);
            this.gbx_prestamos.TabIndex = 2;
            this.gbx_prestamos.TabStop = false;
            this.gbx_prestamos.Text = "Prestamos";
            // 
            // dgv_prestamos
            // 
            this.dgv_prestamos.AllowUserToAddRows = false;
            this.dgv_prestamos.AllowUserToResizeColumns = false;
            this.dgv_prestamos.AllowUserToResizeRows = false;
            this.dgv_prestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_prestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prestamo,
            this.id_libro,
            this.Codigo,
            this.Libro,
            this.Fecha_salida,
            this.Fecha_devolucion,
            this.Renovar,
            this.Devolver});
            this.dgv_prestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_prestamos.Location = new System.Drawing.Point(2, 17);
            this.dgv_prestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_prestamos.Name = "dgv_prestamos";
            this.dgv_prestamos.ReadOnly = true;
            this.dgv_prestamos.RowHeadersVisible = false;
            this.dgv_prestamos.RowHeadersWidth = 51;
            this.dgv_prestamos.RowTemplate.Height = 24;
            this.dgv_prestamos.Size = new System.Drawing.Size(788, 211);
            this.dgv_prestamos.TabIndex = 0;
            this.dgv_prestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prestamos_CellClick);
            // 
            // id_prestamo
            // 
            this.id_prestamo.HeaderText = "id_prestamo";
            this.id_prestamo.MinimumWidth = 6;
            this.id_prestamo.Name = "id_prestamo";
            this.id_prestamo.ReadOnly = true;
            this.id_prestamo.Visible = false;
            // 
            // id_libro
            // 
            this.id_libro.HeaderText = "id_libro";
            this.id_libro.MinimumWidth = 6;
            this.id_libro.Name = "id_libro";
            this.id_libro.ReadOnly = true;
            this.id_libro.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.MinimumWidth = 6;
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            // 
            // Fecha_salida
            // 
            this.Fecha_salida.HeaderText = "Fecha de salida";
            this.Fecha_salida.MinimumWidth = 6;
            this.Fecha_salida.Name = "Fecha_salida";
            this.Fecha_salida.ReadOnly = true;
            // 
            // Fecha_devolucion
            // 
            this.Fecha_devolucion.HeaderText = "Fecha de devolucion";
            this.Fecha_devolucion.MinimumWidth = 6;
            this.Fecha_devolucion.Name = "Fecha_devolucion";
            this.Fecha_devolucion.ReadOnly = true;
            // 
            // Renovar
            // 
            this.Renovar.HeaderText = "Renovar";
            this.Renovar.Image = global::Proyecto_biblioteca_express.Properties.Resources.agregar;
            this.Renovar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Renovar.MinimumWidth = 6;
            this.Renovar.Name = "Renovar";
            this.Renovar.ReadOnly = true;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "Devolver";
            this.Devolver.Image = global::Proyecto_biblioteca_express.Properties.Resources.atras;
            this.Devolver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Devolver.MinimumWidth = 6;
            this.Devolver.Name = "Devolver";
            this.Devolver.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_agregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_registrar_pedido, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 469);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_agregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(2, 5);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(394, 50);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // btn_registrar_pedido
            // 
            this.btn_registrar_pedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registrar_pedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_registrar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_pedido.Location = new System.Drawing.Point(400, 5);
            this.btn_registrar_pedido.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar_pedido.Name = "btn_registrar_pedido";
            this.btn_registrar_pedido.Size = new System.Drawing.Size(394, 50);
            this.btn_registrar_pedido.TabIndex = 3;
            this.btn_registrar_pedido.Text = "Registrar pedido";
            this.btn_registrar_pedido.UseVisualStyleBackColor = false;
            this.btn_registrar_pedido.Click += new System.EventHandler(this.btn_registrar_pedido_Click_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Renovar";
            this.dataGridViewImageColumn1.Image = global::Proyecto_biblioteca_express.Properties.Resources.agregar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 143;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Devolver";
            this.dataGridViewImageColumn3.Image = global::Proyecto_biblioteca_express.Properties.Resources.devolver;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 143;
            // 
            // pic_imagen_alumno
            // 
            this.pic_imagen_alumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_imagen_alumno.Location = new System.Drawing.Point(600, 0);
            this.pic_imagen_alumno.Margin = new System.Windows.Forms.Padding(2);
            this.pic_imagen_alumno.Name = "pic_imagen_alumno";
            this.pic_imagen_alumno.Size = new System.Drawing.Size(196, 184);
            this.pic_imagen_alumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagen_alumno.TabIndex = 0;
            this.pic_imagen_alumno.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carrera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. de control:";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(80, 29);
            this.lbl_nombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(77, 20);
            this.lbl_nombres.TabIndex = 5;
            this.lbl_nombres.Text = "Nombres";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(81, 58);
            this.lbl_apellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(77, 20);
            this.lbl_apellidos.TabIndex = 6;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carrera.Location = new System.Drawing.Point(73, 89);
            this.lbl_carrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(66, 20);
            this.lbl_carrera.TabIndex = 7;
            this.lbl_carrera.Text = "Carrera";
            // 
            // lbl_numero_control
            // 
            this.lbl_numero_control.AutoSize = true;
            this.lbl_numero_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_control.Location = new System.Drawing.Point(115, 119);
            this.lbl_numero_control.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numero_control.Name = "lbl_numero_control";
            this.lbl_numero_control.Size = new System.Drawing.Size(93, 20);
            this.lbl_numero_control.TabIndex = 8;
            this.lbl_numero_control.Text = "No. Control";
            // 
            // panel_datos_alumno
            // 
            this.panel_datos_alumno.Controls.Add(this.lbl_numero_control);
            this.panel_datos_alumno.Controls.Add(this.lbl_carrera);
            this.panel_datos_alumno.Controls.Add(this.lbl_apellidos);
            this.panel_datos_alumno.Controls.Add(this.lbl_nombres);
            this.panel_datos_alumno.Controls.Add(this.label4);
            this.panel_datos_alumno.Controls.Add(this.label3);
            this.panel_datos_alumno.Controls.Add(this.label2);
            this.panel_datos_alumno.Controls.Add(this.label1);
            this.panel_datos_alumno.Controls.Add(this.pic_imagen_alumno);
            this.panel_datos_alumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_datos_alumno.Location = new System.Drawing.Point(0, 0);
            this.panel_datos_alumno.Margin = new System.Windows.Forms.Padding(2);
            this.panel_datos_alumno.Name = "panel_datos_alumno";
            this.panel_datos_alumno.Size = new System.Drawing.Size(796, 184);
            this.panel_datos_alumno.TabIndex = 0;
            // 
            // Frm_inf_alumno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(796, 710);
            this.Controls.Add(this.panel_prestamos_pedidos_botones);
            this.Controls.Add(this.panel_datos_alumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_inf_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion del alumno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_inf_alumno_FormClosed);
            this.Load += new System.EventHandler(this.Frm_inf_alumno_Load);
            this.panel_prestamos_pedidos_botones.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbx_pedidos.ResumeLayout(false);
            this.panel_pedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.gbx_prestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestamos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen_alumno)).EndInit();
            this.panel_datos_alumno.ResumeLayout(false);
            this.panel_datos_alumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_prestamos_pedidos_botones;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbx_prestamos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_registrar_pedido;
        private System.Windows.Forms.GroupBox gbx_pedidos;
        private System.Windows.Forms.Panel panel_pedidos;
        public System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.DataGridView dgv_prestamos;
        public System.Windows.Forms.PictureBox pic_imagen_alumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_nombres;
        public System.Windows.Forms.Label lbl_apellidos;
        public System.Windows.Forms.Label lbl_carrera;
        public System.Windows.Forms.Label lbl_numero_control;
        private System.Windows.Forms.Panel panel_datos_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_libro2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_devolucion;
        private System.Windows.Forms.DataGridViewImageColumn Renovar;
        private System.Windows.Forms.DataGridViewImageColumn Devolver;
    }
}