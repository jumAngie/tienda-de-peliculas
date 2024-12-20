﻿namespace Tienda_de_Peliculas
{
    partial class frmInventario
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
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboClasificacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboIdiomas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnioLanzamiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlAnio = new System.Windows.Forms.Panel();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.pnlIdioma = new System.Windows.Forms.Panel();
            this.pnlClasificacion = new System.Windows.Forms.Panel();
            this.pnlDuracion = new System.Windows.Forms.Panel();
            this.pnlDesc = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.pnlPrecio = new System.Windows.Forms.Panel();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.pnlExistencias = new System.Windows.Forms.Panel();
            this.lblPrecioHNL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboFormatos = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.pnlFormato = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInventario
            // 
            this.dgInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Location = new System.Drawing.Point(12, 340);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.RowHeadersWidth = 51;
            this.dgInventario.Size = new System.Drawing.Size(783, 166);
            this.dgInventario.TabIndex = 0;
            this.dgInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventario_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboClasificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboIdiomas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboGeneros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAnioLanzamiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pnlTitulo);
            this.groupBox1.Controls.Add(this.pnlAnio);
            this.groupBox1.Controls.Add(this.pnlGenero);
            this.groupBox1.Controls.Add(this.pnlIdioma);
            this.groupBox1.Controls.Add(this.pnlClasificacion);
            this.groupBox1.Controls.Add(this.pnlDuracion);
            this.groupBox1.Controls.Add(this.pnlDesc);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 207);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(387, 53);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(211, 154);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(188, 21);
            this.txtDuracion.TabIndex = 11;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duración (Minutos)";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(12, 154);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(188, 21);
            this.cboClasificacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clasificación";
            // 
            // cboIdiomas
            // 
            this.cboIdiomas.FormattingEnabled = true;
            this.cboIdiomas.Location = new System.Drawing.Point(211, 101);
            this.cboIdiomas.Name = "cboIdiomas";
            this.cboIdiomas.Size = new System.Drawing.Size(188, 21);
            this.cboIdiomas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idioma";
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(12, 101);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(188, 21);
            this.cboGeneros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Género";
            // 
            // txtAnioLanzamiento
            // 
            this.txtAnioLanzamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioLanzamiento.Location = new System.Drawing.Point(282, 47);
            this.txtAnioLanzamiento.MaxLength = 4;
            this.txtAnioLanzamiento.Name = "txtAnioLanzamiento";
            this.txtAnioLanzamiento.Size = new System.Drawing.Size(117, 21);
            this.txtAnioLanzamiento.TabIndex = 3;
            this.txtAnioLanzamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnioLanzamiento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año de Lanzamiento";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 47);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(264, 21);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTitulo.Location = new System.Drawing.Point(13, 48);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(263, 22);
            this.pnlTitulo.TabIndex = 19;
            this.pnlTitulo.Visible = false;
            // 
            // pnlAnio
            // 
            this.pnlAnio.BackColor = System.Drawing.Color.DarkRed;
            this.pnlAnio.Location = new System.Drawing.Point(282, 48);
            this.pnlAnio.Name = "pnlAnio";
            this.pnlAnio.Size = new System.Drawing.Size(117, 22);
            this.pnlAnio.TabIndex = 20;
            this.pnlAnio.Visible = false;
            // 
            // pnlGenero
            // 
            this.pnlGenero.BackColor = System.Drawing.Color.DarkRed;
            this.pnlGenero.Location = new System.Drawing.Point(13, 103);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(187, 21);
            this.pnlGenero.TabIndex = 21;
            this.pnlGenero.Visible = false;
            // 
            // pnlIdioma
            // 
            this.pnlIdioma.BackColor = System.Drawing.Color.DarkRed;
            this.pnlIdioma.Location = new System.Drawing.Point(211, 103);
            this.pnlIdioma.Name = "pnlIdioma";
            this.pnlIdioma.Size = new System.Drawing.Size(187, 21);
            this.pnlIdioma.TabIndex = 22;
            this.pnlIdioma.Visible = false;
            // 
            // pnlClasificacion
            // 
            this.pnlClasificacion.BackColor = System.Drawing.Color.DarkRed;
            this.pnlClasificacion.Location = new System.Drawing.Point(13, 154);
            this.pnlClasificacion.Name = "pnlClasificacion";
            this.pnlClasificacion.Size = new System.Drawing.Size(187, 23);
            this.pnlClasificacion.TabIndex = 23;
            this.pnlClasificacion.Visible = false;
            // 
            // pnlDuracion
            // 
            this.pnlDuracion.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDuracion.Location = new System.Drawing.Point(211, 155);
            this.pnlDuracion.Name = "pnlDuracion";
            this.pnlDuracion.Size = new System.Drawing.Size(187, 22);
            this.pnlDuracion.TabIndex = 24;
            this.pnlDuracion.Visible = false;
            // 
            // pnlDesc
            // 
            this.pnlDesc.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDesc.Location = new System.Drawing.Point(14, 237);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(385, 26);
            this.pnlDesc.TabIndex = 25;
            this.pnlDesc.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.pnlPrecio);
            this.groupBox2.Controls.Add(this.txtExistencias);
            this.groupBox2.Controls.Add(this.pnlExistencias);
            this.groupBox2.Controls.Add(this.lblPrecioHNL);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboFormatos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboEstados);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pnlEstado);
            this.groupBox2.Controls.Add(this.pnlFormato);
            this.groupBox2.Location = new System.Drawing.Point(434, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Venta";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(188, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(153, 21);
            this.txtPrecio.TabIndex = 28;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // pnlPrecio
            // 
            this.pnlPrecio.BackColor = System.Drawing.Color.DarkRed;
            this.pnlPrecio.Location = new System.Drawing.Point(188, 104);
            this.pnlPrecio.Name = "pnlPrecio";
            this.pnlPrecio.Size = new System.Drawing.Size(153, 22);
            this.pnlPrecio.TabIndex = 29;
            this.pnlPrecio.Visible = false;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.Location = new System.Drawing.Point(15, 103);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(153, 21);
            this.txtExistencias.TabIndex = 26;
            this.txtExistencias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencias_KeyPress);
            // 
            // pnlExistencias
            // 
            this.pnlExistencias.BackColor = System.Drawing.Color.DarkRed;
            this.pnlExistencias.Location = new System.Drawing.Point(15, 104);
            this.pnlExistencias.Name = "pnlExistencias";
            this.pnlExistencias.Size = new System.Drawing.Size(153, 22);
            this.pnlExistencias.TabIndex = 27;
            this.pnlExistencias.Visible = false;
            // 
            // lblPrecioHNL
            // 
            this.lblPrecioHNL.AutoSize = true;
            this.lblPrecioHNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioHNL.Location = new System.Drawing.Point(185, 83);
            this.lblPrecioHNL.Name = "lblPrecioHNL";
            this.lblPrecioHNL.Size = new System.Drawing.Size(78, 15);
            this.lblPrecioHNL.TabIndex = 16;
            this.lblPrecioHNL.Text = "Precio (HNL)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Existencias";
            // 
            // cboFormatos
            // 
            this.cboFormatos.FormattingEnabled = true;
            this.cboFormatos.Location = new System.Drawing.Point(188, 47);
            this.cboFormatos.Name = "cboFormatos";
            this.cboFormatos.Size = new System.Drawing.Size(153, 21);
            this.cboFormatos.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Formato";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(15, 47);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(153, 21);
            this.cboEstados.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estado";
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.DarkRed;
            this.pnlEstado.Location = new System.Drawing.Point(15, 54);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(153, 17);
            this.pnlEstado.TabIndex = 26;
            this.pnlEstado.Visible = false;
            // 
            // pnlFormato
            // 
            this.pnlFormato.BackColor = System.Drawing.Color.DarkRed;
            this.pnlFormato.Location = new System.Drawing.Point(188, 54);
            this.pnlFormato.Name = "pnlFormato";
            this.pnlFormato.Size = new System.Drawing.Size(153, 17);
            this.pnlFormato.TabIndex = 27;
            this.pnlFormato.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(541, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(671, 299);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.LightCoral;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdvertencia.Location = new System.Drawing.Point(619, 9);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(176, 15);
            this.lblAdvertencia.TabIndex = 22;
            this.lblAdvertencia.Text = "¡Debe llenar todos los campos!";
            this.lblAdvertencia.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(541, 299);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 35);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgInventario);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnioLanzamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboClasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboIdiomas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFormatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrecioHNL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlAnio;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.Panel pnlIdioma;
        private System.Windows.Forms.Panel pnlClasificacion;
        private System.Windows.Forms.Panel pnlDuracion;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Panel pnlFormato;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel pnlPrecio;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Panel pnlExistencias;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.Button btnEditar;
    }
}