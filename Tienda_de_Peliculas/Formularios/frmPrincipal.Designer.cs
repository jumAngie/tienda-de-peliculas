﻿namespace Tienda_de_Peliculas
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbltTitle = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentaAlquiler = new System.Windows.Forms.Button();
            this.btnRegistroEmpleados = new System.Windows.Forms.Button();
            this.btnRegistroClientes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAlquileresSemanales = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVentasSemanales = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblClientesRegistrados = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelDesktopPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblHora);
            this.panelTitleBar.Controls.Add(this.lblFecha);
            this.panelTitleBar.Controls.Add(this.lbltTitle);
            this.panelTitleBar.Controls.Add(this.pcbFoto);
            this.panelTitleBar.Controls.Add(this.lblRol);
            this.panelTitleBar.Controls.Add(this.lblNombre);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1365, 92);
            this.panelTitleBar.TabIndex = 6;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImage = global::Tienda_de_Peliculas.Properties.Resources.hogar;
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(313, 18);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(67, 52);
            this.btnCloseChildForm.TabIndex = 17;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(404, 46);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 20);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "12:20 p.m.";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(404, 27);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(183, 20);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "15 de Octubre del 2025";
            // 
            // lbltTitle
            // 
            this.lbltTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltTitle.AutoSize = true;
            this.lbltTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTitle.ForeColor = System.Drawing.Color.White;
            this.lbltTitle.Location = new System.Drawing.Point(752, 22);
            this.lbltTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltTitle.Name = "lbltTitle";
            this.lbltTitle.Size = new System.Drawing.Size(134, 42);
            this.lbltTitle.TabIndex = 12;
            this.lbltTitle.Text = "INICIO";
            // 
            // pcbFoto
            // 
            this.pcbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbFoto.Image = global::Tienda_de_Peliculas.Properties.Resources.cerrar_sesion;
            this.pcbFoto.Location = new System.Drawing.Point(1283, 15);
            this.pcbFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(67, 55);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.Click += new System.EventHandler(this.pcbFoto_Click);
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(1123, 52);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(133, 18);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "role_descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(1129, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "dato_Usuario";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tHora
            // 
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnVentaAlquiler);
            this.panelMenu.Controls.Add(this.btnRegistroEmpleados);
            this.panelMenu.Controls.Add(this.btnRegistroClientes);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 737);
            this.panelMenu.TabIndex = 11;
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 0);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(15, 2, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(293, 110);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "    Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Visible = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Inventario;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(15, 2, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(293, 98);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "    Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Visible = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentaAlquiler
            // 
            this.btnVentaAlquiler.FlatAppearance.BorderSize = 0;
            this.btnVentaAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaAlquiler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentaAlquiler.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Venta_Alquiler;
            this.btnVentaAlquiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaAlquiler.Location = new System.Drawing.Point(0, 0);
            this.btnVentaAlquiler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnVentaAlquiler.Name = "btnVentaAlquiler";
            this.btnVentaAlquiler.Padding = new System.Windows.Forms.Padding(15, 2, 0, 0);
            this.btnVentaAlquiler.Size = new System.Drawing.Size(293, 97);
            this.btnVentaAlquiler.TabIndex = 3;
            this.btnVentaAlquiler.Text = "    Venta / Alquiler";
            this.btnVentaAlquiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaAlquiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaAlquiler.UseVisualStyleBackColor = true;
            this.btnVentaAlquiler.Visible = false;
            this.btnVentaAlquiler.Click += new System.EventHandler(this.btnVentaAlquiler_Click);
            // 
            // btnRegistroEmpleados
            // 
            this.btnRegistroEmpleados.FlatAppearance.BorderSize = 0;
            this.btnRegistroEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistroEmpleados.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Empleados;
            this.btnRegistroEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroEmpleados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnRegistroEmpleados.Name = "btnRegistroEmpleados";
            this.btnRegistroEmpleados.Padding = new System.Windows.Forms.Padding(15, 2, 0, 0);
            this.btnRegistroEmpleados.Size = new System.Drawing.Size(293, 113);
            this.btnRegistroEmpleados.TabIndex = 2;
            this.btnRegistroEmpleados.Text = "    Empleados\r\n";
            this.btnRegistroEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroEmpleados.UseVisualStyleBackColor = true;
            this.btnRegistroEmpleados.Visible = false;
            this.btnRegistroEmpleados.Click += new System.EventHandler(this.btnRegistroEmpleados_Click);
            // 
            // btnRegistroClientes
            // 
            this.btnRegistroClientes.FlatAppearance.BorderSize = 0;
            this.btnRegistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistroClientes.Image = global::Tienda_de_Peliculas.Properties.Resources.Icono_Registrar_Clientes;
            this.btnRegistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroClientes.Location = new System.Drawing.Point(0, 0);
            this.btnRegistroClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnRegistroClientes.Name = "btnRegistroClientes";
            this.btnRegistroClientes.Padding = new System.Windows.Forms.Padding(15, 2, 0, 0);
            this.btnRegistroClientes.Size = new System.Drawing.Size(293, 89);
            this.btnRegistroClientes.TabIndex = 1;
            this.btnRegistroClientes.Text = "    Clientes";
            this.btnRegistroClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroClientes.UseVisualStyleBackColor = true;
            this.btnRegistroClientes.Visible = false;
            this.btnRegistroClientes.Click += new System.EventHandler(this.btnRegistroClientes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "V I D E O";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOLLYWOOD";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::Tienda_de_Peliculas.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(16, 18);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(125, 52);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPanel.Controls.Add(this.lblMensajeBienvenida);
            this.panelDesktopPanel.Controls.Add(this.panel4);
            this.panelDesktopPanel.Controls.Add(this.pictureBox4);
            this.panelDesktopPanel.Controls.Add(this.label11);
            this.panelDesktopPanel.Controls.Add(this.panel3);
            this.panelDesktopPanel.Controls.Add(this.panel2);
            this.panelDesktopPanel.ForeColor = System.Drawing.Color.Black;
            this.panelDesktopPanel.Location = new System.Drawing.Point(291, 92);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1075, 645);
            this.panelDesktopPanel.TabIndex = 12;
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(32, 26);
            this.lblMensajeBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(267, 31);
            this.lblMensajeBienvenida.TabIndex = 11;
            this.lblMensajeBienvenida.Text = "mensajeBienvenida";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblAlquileresSemanales);
            this.panel4.Location = new System.Drawing.Point(704, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 100);
            this.panel4.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Tienda_de_Peliculas.Properties.Resources.pelicula__2_;
            this.pictureBox5.Location = new System.Drawing.Point(21, 10);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Alquileres Semanales";
            // 
            // lblAlquileresSemanales
            // 
            this.lblAlquileresSemanales.AutoSize = true;
            this.lblAlquileresSemanales.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileresSemanales.ForeColor = System.Drawing.Color.White;
            this.lblAlquileresSemanales.Location = new System.Drawing.Point(84, 15);
            this.lblAlquileresSemanales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlquileresSemanales.Name = "lblAlquileresSemanales";
            this.lblAlquileresSemanales.Size = new System.Drawing.Size(104, 54);
            this.lblAlquileresSemanales.TabIndex = 0;
            this.lblAlquileresSemanales.Text = "000";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Tienda_de_Peliculas.Properties.Resources._572828_200;
            this.pictureBox4.Location = new System.Drawing.Point(36, 85);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label11.Location = new System.Drawing.Point(71, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 31);
            this.label11.TabIndex = 15;
            this.label11.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblVentasSemanales);
            this.panel3.Location = new System.Drawing.Point(383, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 100);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Tienda_de_Peliculas.Properties.Resources.bienes;
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ventas Semanales";
            // 
            // lblVentasSemanales
            // 
            this.lblVentasSemanales.AutoSize = true;
            this.lblVentasSemanales.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasSemanales.ForeColor = System.Drawing.Color.White;
            this.lblVentasSemanales.Location = new System.Drawing.Point(76, 15);
            this.lblVentasSemanales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasSemanales.Name = "lblVentasSemanales";
            this.lblVentasSemanales.Size = new System.Drawing.Size(104, 54);
            this.lblVentasSemanales.TabIndex = 0;
            this.lblVentasSemanales.Text = "000";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblClientesRegistrados);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(79, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 100);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Tienda_de_Peliculas.Properties.Resources.agregar_usuario;
            this.pictureBox2.Location = new System.Drawing.Point(19, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Clientes Registrados";
            // 
            // lblClientesRegistrados
            // 
            this.lblClientesRegistrados.AutoSize = true;
            this.lblClientesRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesRegistrados.ForeColor = System.Drawing.Color.White;
            this.lblClientesRegistrados.Location = new System.Drawing.Point(85, 15);
            this.lblClientesRegistrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientesRegistrados.Name = "lblClientesRegistrados";
            this.lblClientesRegistrados.Size = new System.Drawing.Size(104, 54);
            this.lblClientesRegistrados.TabIndex = 0;
            this.lblClientesRegistrados.Text = "001";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1365, 737);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRegistroClientes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentaAlquiler;
        private System.Windows.Forms.Button btnRegistroEmpleados;
        private System.Windows.Forms.Label lbltTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAlquileresSemanales;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVentasSemanales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblClientesRegistrados;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

