namespace Tienda_de_Peliculas
{
    partial class frmCiudades
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.dgCiudades = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.registroToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 461);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Info;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 19);
            this.toolStripMenuItem1.Text = "   Principal";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.registrarEmpleadosToolStripMenuItem});
            this.registroToolStripMenuItem.Font = new System.Drawing.Font("Nobile", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registroToolStripMenuItem.Image = global::Tienda_de_Peliculas.Properties.Resources.agregar_archivo;
            this.registroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registroToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(112, 41);
            this.registroToolStripMenuItem.Text = "   Registro";
            // 
            // registrarClientesToolStripMenuItem
            // 
            this.registrarClientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
            this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.registrarClientesToolStripMenuItem.Text = "Registrar Clientes";
            // 
            // registrarEmpleadosToolStripMenuItem
            // 
            this.registrarEmpleadosToolStripMenuItem.Name = "registrarEmpleadosToolStripMenuItem";
            this.registrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.registrarEmpleadosToolStripMenuItem.Text = "Registrar Empleados";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPeliculasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Nobile", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventarioToolStripMenuItem.Image = global::Tienda_de_Peliculas.Properties.Resources.inventario;
            this.inventarioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventarioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.inventarioToolStripMenuItem.Text = "   Inventario";
            // 
            // registrarPeliculasToolStripMenuItem
            // 
            this.registrarPeliculasToolStripMenuItem.Name = "registrarPeliculasToolStripMenuItem";
            this.registrarPeliculasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registrarPeliculasToolStripMenuItem.Text = "Registrar Peliculas";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.registrarAlquilerToolStripMenuItem});
            this.facturaToolStripMenuItem.Font = new System.Drawing.Font("Nobile", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.facturaToolStripMenuItem.Image = global::Tienda_de_Peliculas.Properties.Resources.factura;
            this.facturaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facturaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.facturaToolStripMenuItem.Text = "  Factura";
            this.facturaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // registrarAlquilerToolStripMenuItem
            // 
            this.registrarAlquilerToolStripMenuItem.Name = "registrarAlquilerToolStripMenuItem";
            this.registrarAlquilerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registrarAlquilerToolStripMenuItem.Text = "Registrar Alquiler";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Nobile", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reporteToolStripMenuItem.Image = global::Tienda_de_Peliculas.Properties.Resources.analitica;
            this.reporteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reporteToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 15);
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.reporteToolStripMenuItem.Text = "  Reportes";
            this.reporteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMensajeBienvenida);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.pcbFoto);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(106, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 89);
            this.panel1.TabIndex = 12;
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Nobile", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(27, 17);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(167, 36);
            this.lblMensajeBienvenida.TabIndex = 5;
            this.lblMensajeBienvenida.Text = "Ciudades";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHora.Location = new System.Drawing.Point(271, 53);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(67, 15);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "12:20 p.m.";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Location = new System.Drawing.Point(30, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(145, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "15 de Octubre del 2025";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbFoto.Image = global::Tienda_de_Peliculas.Properties.Resources.pelicula;
            this.pcbFoto.Location = new System.Drawing.Point(573, 3);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(82, 81);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRol.Location = new System.Drawing.Point(456, 41);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(96, 15);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Administrador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(438, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Angie Campos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNombreCiudad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboDepartamentos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPaises);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(140, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(446, 83);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 26);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreCiudad
            // 
            this.txtNombreCiudad.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCiudad.Location = new System.Drawing.Point(409, 44);
            this.txtNombreCiudad.Name = "txtNombreCiudad";
            this.txtNombreCiudad.Size = new System.Drawing.Size(185, 21);
            this.txtNombreCiudad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de la Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento";
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(209, 43);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(194, 21);
            this.cboDepartamentos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pais";
            // 
            // cboPaises
            // 
            this.cboPaises.Font = new System.Drawing.Font("Nobile", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Location = new System.Drawing.Point(19, 43);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(184, 21);
            this.cboPaises.TabIndex = 0;
            this.cboPaises.SelectedIndexChanged += new System.EventHandler(this.cboPaises_SelectedIndexChanged);
            // 
            // dgCiudades
            // 
            this.dgCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCiudades.Location = new System.Drawing.Point(140, 230);
            this.dgCiudades.Name = "dgCiudades";
            this.dgCiudades.Size = new System.Drawing.Size(624, 219);
            this.dgCiudades.TabIndex = 14;
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(776, 461);
            this.Controls.Add(this.dgCiudades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCiudades";
            this.Text = "frmCiudades";
            this.Load += new System.EventHandler(this.frmCiudades_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPaises;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepartamentos;
        private System.Windows.Forms.DataGridView dgCiudades;
    }
}