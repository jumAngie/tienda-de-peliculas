namespace Tienda_de_Peliculas
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dgInventario.Location = new System.Drawing.Point(16, 418);
            this.dgInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.RowHeadersWidth = 51;
            this.dgInventario.Size = new System.Drawing.Size(1044, 204);
            this.dgInventario.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(555, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(16, 255);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(515, 64);
            this.txtDescripcion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descripción";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(281, 190);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(249, 24);
            this.txtDuracion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duración (Minutos)";
            // 
            // cboClasificacion
            // 
            this.cboClasificacion.FormattingEnabled = true;
            this.cboClasificacion.Location = new System.Drawing.Point(16, 190);
            this.cboClasificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboClasificacion.Name = "cboClasificacion";
            this.cboClasificacion.Size = new System.Drawing.Size(249, 24);
            this.cboClasificacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clasificación";
            // 
            // cboIdiomas
            // 
            this.cboIdiomas.FormattingEnabled = true;
            this.cboIdiomas.Location = new System.Drawing.Point(281, 124);
            this.cboIdiomas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboIdiomas.Name = "cboIdiomas";
            this.cboIdiomas.Size = new System.Drawing.Size(249, 24);
            this.cboIdiomas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idioma";
            // 
            // cboGeneros
            // 
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Location = new System.Drawing.Point(16, 124);
            this.cboGeneros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(249, 24);
            this.cboGeneros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Género";
            // 
            // txtAnioLanzamiento
            // 
            this.txtAnioLanzamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioLanzamiento.Location = new System.Drawing.Point(376, 58);
            this.txtAnioLanzamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnioLanzamiento.Name = "txtAnioLanzamiento";
            this.txtAnioLanzamiento.Size = new System.Drawing.Size(155, 24);
            this.txtAnioLanzamiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año de Lanzamiento";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(16, 58);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(351, 24);
            this.txtTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.pnlTitulo.Location = new System.Drawing.Point(17, 59);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(351, 27);
            this.pnlTitulo.TabIndex = 19;
            this.pnlTitulo.Visible = false;
            // 
            // pnlAnio
            // 
            this.pnlAnio.BackColor = System.Drawing.Color.DarkRed;
            this.pnlAnio.Location = new System.Drawing.Point(376, 59);
            this.pnlAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAnio.Name = "pnlAnio";
            this.pnlAnio.Size = new System.Drawing.Size(156, 27);
            this.pnlAnio.TabIndex = 20;
            this.pnlAnio.Visible = false;
            // 
            // pnlGenero
            // 
            this.pnlGenero.BackColor = System.Drawing.Color.DarkRed;
            this.pnlGenero.Location = new System.Drawing.Point(17, 127);
            this.pnlGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(249, 26);
            this.pnlGenero.TabIndex = 21;
            this.pnlGenero.Visible = false;
            // 
            // pnlIdioma
            // 
            this.pnlIdioma.BackColor = System.Drawing.Color.DarkRed;
            this.pnlIdioma.Location = new System.Drawing.Point(281, 127);
            this.pnlIdioma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlIdioma.Name = "pnlIdioma";
            this.pnlIdioma.Size = new System.Drawing.Size(249, 26);
            this.pnlIdioma.TabIndex = 22;
            this.pnlIdioma.Visible = false;
            // 
            // pnlClasificacion
            // 
            this.pnlClasificacion.BackColor = System.Drawing.Color.DarkRed;
            this.pnlClasificacion.Location = new System.Drawing.Point(17, 190);
            this.pnlClasificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClasificacion.Name = "pnlClasificacion";
            this.pnlClasificacion.Size = new System.Drawing.Size(249, 28);
            this.pnlClasificacion.TabIndex = 23;
            this.pnlClasificacion.Visible = false;
            // 
            // pnlDuracion
            // 
            this.pnlDuracion.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDuracion.Location = new System.Drawing.Point(281, 191);
            this.pnlDuracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDuracion.Name = "pnlDuracion";
            this.pnlDuracion.Size = new System.Drawing.Size(249, 27);
            this.pnlDuracion.TabIndex = 24;
            this.pnlDuracion.Visible = false;
            // 
            // pnlDesc
            // 
            this.pnlDesc.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDesc.Location = new System.Drawing.Point(19, 292);
            this.pnlDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(513, 32);
            this.pnlDesc.TabIndex = 25;
            this.pnlDesc.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.lblPrecioHNL);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboFormatos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboEstados);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pnlEstado);
            this.groupBox2.Controls.Add(this.pnlFormato);
            this.groupBox2.Location = new System.Drawing.Point(579, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(481, 350);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Venta";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(251, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 24);
            this.textBox2.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(251, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 27);
            this.panel2.TabIndex = 29;
            this.panel2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 24);
            this.textBox1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(20, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 27);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // lblPrecioHNL
            // 
            this.lblPrecioHNL.AutoSize = true;
            this.lblPrecioHNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioHNL.Location = new System.Drawing.Point(247, 102);
            this.lblPrecioHNL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioHNL.Name = "lblPrecioHNL";
            this.lblPrecioHNL.Size = new System.Drawing.Size(95, 18);
            this.lblPrecioHNL.TabIndex = 16;
            this.lblPrecioHNL.Text = "Precio (HNL)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Existencias";
            // 
            // cboFormatos
            // 
            this.cboFormatos.FormattingEnabled = true;
            this.cboFormatos.Location = new System.Drawing.Point(251, 58);
            this.cboFormatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFormatos.Name = "cboFormatos";
            this.cboFormatos.Size = new System.Drawing.Size(203, 24);
            this.cboFormatos.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Formato";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(20, 58);
            this.cboEstados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(203, 24);
            this.cboEstados.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estado";
            // 
            // pnlEstado
            // 
            this.pnlEstado.BackColor = System.Drawing.Color.DarkRed;
            this.pnlEstado.Location = new System.Drawing.Point(20, 66);
            this.pnlEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(204, 21);
            this.pnlEstado.TabIndex = 26;
            this.pnlEstado.Visible = false;
            // 
            // pnlFormato
            // 
            this.pnlFormato.BackColor = System.Drawing.Color.DarkRed;
            this.pnlFormato.Location = new System.Drawing.Point(251, 66);
            this.pnlFormato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFormato.Name = "pnlFormato";
            this.pnlFormato.Size = new System.Drawing.Size(204, 21);
            this.pnlFormato.TabIndex = 27;
            this.pnlFormato.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(721, 368);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 43);
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
            this.btnCancelar.Location = new System.Drawing.Point(895, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 639);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgInventario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}