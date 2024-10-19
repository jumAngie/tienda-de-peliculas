namespace Tienda_de_Peliculas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClientesRegistrados = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVentasSemanales = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAlquileresSemanales = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentaAlquiler = new System.Windows.Forms.Button();
            this.btnRegistroEmpleados = new System.Windows.Forms.Button();
            this.btnRegistroClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Nobile", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(18, 8);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(293, 33);
            this.lblMensajeBienvenida.TabIndex = 5;
            this.lblMensajeBienvenida.Text = "¡Bienvenido Angie!";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblMensajeBienvenida);
            this.panelHeader.Controls.Add(this.lblHora);
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.pcbFoto);
            this.panelHeader.Controls.Add(this.lblRol);
            this.panelHeader.Controls.Add(this.lblNombre);
            this.panelHeader.Location = new System.Drawing.Point(218, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(767, 75);
            this.panelHeader.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(265, 41);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(67, 15);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "12:20 p.m.";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(24, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(145, 15);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "15 de Octubre del 2025";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbFoto.Image = global::Tienda_de_Peliculas.Properties.Resources.pelicula;
            this.pcbFoto.Location = new System.Drawing.Point(697, 11);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(47, 45);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Nobile", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(601, 37);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(90, 16);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Administrador";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(562, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Angie Campos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblClientesRegistrados);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(271, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 82);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Tienda_de_Peliculas.Properties.Resources.agregar_usuario;
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Clientes Registrados";
            // 
            // lblClientesRegistrados
            // 
            this.lblClientesRegistrados.AutoSize = true;
            this.lblClientesRegistrados.Font = new System.Drawing.Font("Nobile", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesRegistrados.ForeColor = System.Drawing.Color.White;
            this.lblClientesRegistrados.Location = new System.Drawing.Point(64, 12);
            this.lblClientesRegistrados.Name = "lblClientesRegistrados";
            this.lblClientesRegistrados.Size = new System.Drawing.Size(92, 41);
            this.lblClientesRegistrados.TabIndex = 0;
            this.lblClientesRegistrados.Text = "001";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblVentasSemanales);
            this.panel3.Location = new System.Drawing.Point(499, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 82);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Tienda_de_Peliculas.Properties.Resources.bienes;
            this.pictureBox3.Location = new System.Drawing.Point(9, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ventas Semanales";
            // 
            // lblVentasSemanales
            // 
            this.lblVentasSemanales.AutoSize = true;
            this.lblVentasSemanales.Font = new System.Drawing.Font("Nobile", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasSemanales.ForeColor = System.Drawing.Color.White;
            this.lblVentasSemanales.Location = new System.Drawing.Point(57, 12);
            this.lblVentasSemanales.Name = "lblVentasSemanales";
            this.lblVentasSemanales.Size = new System.Drawing.Size(102, 41);
            this.lblVentasSemanales.TabIndex = 0;
            this.lblVentasSemanales.Text = "000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Nobile", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(267, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblAlquileresSemanales);
            this.panel4.Location = new System.Drawing.Point(740, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 82);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Tienda_de_Peliculas.Properties.Resources.pelicula__2_;
            this.pictureBox5.Location = new System.Drawing.Point(16, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nobile", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Alquileres Semanales";
            // 
            // lblAlquileresSemanales
            // 
            this.lblAlquileresSemanales.AutoSize = true;
            this.lblAlquileresSemanales.Font = new System.Drawing.Font("Nobile", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileresSemanales.ForeColor = System.Drawing.Color.White;
            this.lblAlquileresSemanales.Location = new System.Drawing.Point(63, 12);
            this.lblAlquileresSemanales.Name = "lblAlquileresSemanales";
            this.lblAlquileresSemanales.Size = new System.Drawing.Size(102, 41);
            this.lblAlquileresSemanales.TabIndex = 0;
            this.lblAlquileresSemanales.Text = "000";
            // 
            // tHora
            // 
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVentaAlquiler);
            this.panelMenu.Controls.Add(this.btnRegistroEmpleados);
            this.panelMenu.Controls.Add(this.btnRegistroClientes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 461);
            this.panelMenu.TabIndex = 11;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 315);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(220, 60);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "    Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Inventario;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 255);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(220, 60);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "    Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnVentaAlquiler
            // 
            this.btnVentaAlquiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentaAlquiler.FlatAppearance.BorderSize = 0;
            this.btnVentaAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaAlquiler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentaAlquiler.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Venta_Alquiler;
            this.btnVentaAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaAlquiler.Location = new System.Drawing.Point(0, 195);
            this.btnVentaAlquiler.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnVentaAlquiler.Name = "btnVentaAlquiler";
            this.btnVentaAlquiler.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnVentaAlquiler.Size = new System.Drawing.Size(220, 60);
            this.btnVentaAlquiler.TabIndex = 3;
            this.btnVentaAlquiler.Text = "    Venta / Alquiler";
            this.btnVentaAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaAlquiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnRegistroEmpleados
            // 
            this.btnRegistroEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRegistroEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistroEmpleados.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Empleados;
            this.btnRegistroEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleados.Location = new System.Drawing.Point(0, 135);
            this.btnRegistroEmpleados.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnRegistroEmpleados.Name = "btnRegistroEmpleados";
            this.btnRegistroEmpleados.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnRegistroEmpleados.Size = new System.Drawing.Size(220, 60);
            this.btnRegistroEmpleados.TabIndex = 2;
            this.btnRegistroEmpleados.Text = "    Registro de Empleados\r\n";
            this.btnRegistroEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnRegistroClientes
            // 
            this.btnRegistroClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroClientes.FlatAppearance.BorderSize = 0;
            this.btnRegistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistroClientes.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Clientes;
            this.btnRegistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroClientes.Location = new System.Drawing.Point(0, 75);
            this.btnRegistroClientes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnRegistroClientes.Name = "btnRegistroClientes";
            this.btnRegistroClientes.Padding = new System.Windows.Forms.Padding(11, 2, 0, 0);
            this.btnRegistroClientes.Size = new System.Drawing.Size(220, 60);
            this.btnRegistroClientes.TabIndex = 1;
            this.btnRegistroClientes.Text = "    Registro de Clientes";
            this.btnRegistroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroClientes.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Tienda_de_Peliculas.Properties.Resources._572828_200;
            this.pictureBox4.Location = new System.Drawing.Point(241, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClientesRegistrados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVentasSemanales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAlquileresSemanales;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRegistroClientes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentaAlquiler;
        private System.Windows.Forms.Button btnRegistroEmpleados;
    }
}

