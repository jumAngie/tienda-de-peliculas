namespace Tienda_de_Peliculas.Formularios
{
    partial class frmFactura
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
            this.pnlVenta = new System.Windows.Forms.Panel();
            this.lblTotalResultado = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbCompra = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.rbAlquiler = new System.Windows.Forms.RadioButton();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.cbxPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPago = new System.Windows.Forms.Panel();
            this.pnlDevolucion = new System.Windows.Forms.Panel();
            this.dtFechaDev = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbGenerales = new System.Windows.Forms.GroupBox();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.cbxPelicula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.pnlPelicula = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgFactura = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlVenta.SuspendLayout();
            this.gbCompra.SuspendLayout();
            this.pnlDevolucion.SuspendLayout();
            this.gbGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenta
            // 
            this.pnlVenta.Controls.Add(this.lblTotalResultado);
            this.pnlVenta.Controls.Add(this.txtImpuesto);
            this.pnlVenta.Controls.Add(this.txtDescuento);
            this.pnlVenta.Controls.Add(this.txtSubtotal);
            this.pnlVenta.Controls.Add(this.lblISV);
            this.pnlVenta.Controls.Add(this.lblDescuento);
            this.pnlVenta.Controls.Add(this.lblSubtotal);
            this.pnlVenta.Controls.Add(this.lblTotal);
            this.pnlVenta.Controls.Add(this.gbCompra);
            this.pnlVenta.Controls.Add(this.gbGenerales);
            this.pnlVenta.Controls.Add(this.btnCancelar);
            this.pnlVenta.Controls.Add(this.btnGuardar);
            this.pnlVenta.Location = new System.Drawing.Point(12, 27);
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Size = new System.Drawing.Size(783, 308);
            this.pnlVenta.TabIndex = 2;
            // 
            // lblTotalResultado
            // 
            this.lblTotalResultado.AutoSize = true;
            this.lblTotalResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResultado.Location = new System.Drawing.Point(162, 276);
            this.lblTotalResultado.Name = "lblTotalResultado";
            this.lblTotalResultado.Size = new System.Drawing.Size(78, 24);
            this.lblTotalResultado.TabIndex = 17;
            this.lblTotalResultado.Text = "L. 0.00 ";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(148, 243);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(130, 20);
            this.txtImpuesto.TabIndex = 16;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(148, 217);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(130, 20);
            this.txtDescuento.TabIndex = 15;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(148, 191);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(130, 20);
            this.txtSubtotal.TabIndex = 14;
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(28, 247);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(114, 16);
            this.lblISV.TabIndex = 13;
            this.lblISV.Text = "IMPUESTO (15%)";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(27, 221);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(92, 16);
            this.lblDescuento.TabIndex = 12;
            this.lblDescuento.Text = "DESCUENTO";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(27, 195);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(79, 16);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(26, 276);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 24);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "TOTAL";
            // 
            // gbCompra
            // 
            this.gbCompra.Controls.Add(this.lblCantidad);
            this.gbCompra.Controls.Add(this.txtCantidad);
            this.gbCompra.Controls.Add(this.lblAlquiler);
            this.gbCompra.Controls.Add(this.lblVenta);
            this.gbCompra.Controls.Add(this.rbAlquiler);
            this.gbCompra.Controls.Add(this.rbVenta);
            this.gbCompra.Controls.Add(this.lblFechaDev);
            this.gbCompra.Controls.Add(this.cbxPago);
            this.gbCompra.Controls.Add(this.label2);
            this.gbCompra.Controls.Add(this.pnlPago);
            this.gbCompra.Controls.Add(this.pnlDevolucion);
            this.gbCompra.Controls.Add(this.panel1);
            this.gbCompra.Location = new System.Drawing.Point(401, 14);
            this.gbCompra.Name = "gbCompra";
            this.gbCompra.Size = new System.Drawing.Size(366, 167);
            this.gbCompra.TabIndex = 9;
            this.gbCompra.TabStop = false;
            this.gbCompra.Text = "Datos de la Compra";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(25, 107);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(28, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAlquiler.Location = new System.Drawing.Point(163, 27);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(15, 20);
            this.lblAlquiler.TabIndex = 21;
            this.lblAlquiler.Text = "*";
            this.lblAlquiler.Visible = false;
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblVenta.Location = new System.Drawing.Point(73, 27);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(15, 20);
            this.lblVenta.TabIndex = 20;
            this.lblVenta.Text = "*";
            this.lblVenta.Visible = false;
            this.lblVenta.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbAlquiler
            // 
            this.rbAlquiler.AutoSize = true;
            this.rbAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlquiler.Location = new System.Drawing.Point(184, 27);
            this.rbAlquiler.Name = "rbAlquiler";
            this.rbAlquiler.Size = new System.Drawing.Size(66, 19);
            this.rbAlquiler.TabIndex = 12;
            this.rbAlquiler.TabStop = true;
            this.rbAlquiler.Text = "Alquiler";
            this.rbAlquiler.UseVisualStyleBackColor = true;
            this.rbAlquiler.CheckedChanged += new System.EventHandler(this.rbAlquiler_CheckedChanged);
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVenta.Location = new System.Drawing.Point(94, 27);
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Size = new System.Drawing.Size(56, 19);
            this.rbVenta.TabIndex = 11;
            this.rbVenta.TabStop = true;
            this.rbVenta.Text = "Venta";
            this.rbVenta.UseVisualStyleBackColor = true;
            this.rbVenta.CheckedChanged += new System.EventHandler(this.rbVenta_CheckedChanged);
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDev.Location = new System.Drawing.Point(131, 107);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(105, 15);
            this.lblFechaDev.TabIndex = 9;
            this.lblFechaDev.Text = "Fecha Devolución";
            this.lblFechaDev.Visible = false;
            // 
            // cbxPago
            // 
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Items.AddRange(new object[] {
            "Efectivo",
            "Trasnferencia",
            "Tarjeta "});
            this.cbxPago.Location = new System.Drawing.Point(28, 72);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(318, 21);
            this.cbxPago.TabIndex = 8;
            this.cbxPago.SelectedIndexChanged += new System.EventHandler(this.cbxPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Método de Pago";
            // 
            // pnlPago
            // 
            this.pnlPago.BackColor = System.Drawing.Color.DarkRed;
            this.pnlPago.Location = new System.Drawing.Point(28, 78);
            this.pnlPago.Name = "pnlPago";
            this.pnlPago.Size = new System.Drawing.Size(318, 18);
            this.pnlPago.TabIndex = 19;
            this.pnlPago.Visible = false;
            // 
            // pnlDevolucion
            // 
            this.pnlDevolucion.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDevolucion.Controls.Add(this.dtFechaDev);
            this.pnlDevolucion.Location = new System.Drawing.Point(135, 128);
            this.pnlDevolucion.Name = "pnlDevolucion";
            this.pnlDevolucion.Size = new System.Drawing.Size(200, 21);
            this.pnlDevolucion.TabIndex = 19;
            this.pnlDevolucion.Visible = false;
            // 
            // dtFechaDev
            // 
            this.dtFechaDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDev.Location = new System.Drawing.Point(0, -2);
            this.dtFechaDev.Name = "dtFechaDev";
            this.dtFechaDev.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDev.TabIndex = 10;
            this.dtFechaDev.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(28, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 20);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
            // 
            // gbGenerales
            // 
            this.gbGenerales.Controls.Add(this.lblNumFactura);
            this.gbGenerales.Controls.Add(this.cbxPelicula);
            this.gbGenerales.Controls.Add(this.label1);
            this.gbGenerales.Controls.Add(this.cbxCliente);
            this.gbGenerales.Controls.Add(this.lblName);
            this.gbGenerales.Controls.Add(this.pnlCliente);
            this.gbGenerales.Controls.Add(this.pnlPelicula);
            this.gbGenerales.Location = new System.Drawing.Point(17, 14);
            this.gbGenerales.Name = "gbGenerales";
            this.gbGenerales.Size = new System.Drawing.Size(366, 167);
            this.gbGenerales.TabIndex = 8;
            this.gbGenerales.TabStop = false;
            this.gbGenerales.Text = "Datos Generales";
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFactura.ForeColor = System.Drawing.Color.Black;
            this.lblNumFactura.Location = new System.Drawing.Point(127, 27);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(117, 24);
            this.lblNumFactura.TabIndex = 6;
            this.lblNumFactura.Text = "FAC#00001";
            this.lblNumFactura.Click += new System.EventHandler(this.lblNumFactura_Click);
            // 
            // cbxPelicula
            // 
            this.cbxPelicula.FormattingEnabled = true;
            this.cbxPelicula.Location = new System.Drawing.Point(81, 107);
            this.cbxPelicula.Name = "cbxPelicula";
            this.cbxPelicula.Size = new System.Drawing.Size(257, 21);
            this.cbxPelicula.TabIndex = 5;
            this.cbxPelicula.SelectedIndexChanged += new System.EventHandler(this.cbxPelicula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pelicula:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(81, 72);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(257, 21);
            this.cbxCliente.TabIndex = 3;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(22, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Cliente:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCliente.Location = new System.Drawing.Point(81, 78);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(257, 18);
            this.pnlCliente.TabIndex = 18;
            this.pnlCliente.Visible = false;
            // 
            // pnlPelicula
            // 
            this.pnlPelicula.BackColor = System.Drawing.Color.DarkRed;
            this.pnlPelicula.Location = new System.Drawing.Point(81, 111);
            this.pnlPelicula.Name = "pnlPelicula";
            this.pnlPelicula.Size = new System.Drawing.Size(257, 20);
            this.pnlPelicula.TabIndex = 19;
            this.pnlPelicula.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(643, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(513, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgFactura
            // 
            this.dgFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactura.Location = new System.Drawing.Point(12, 341);
            this.dgFactura.Name = "dgFactura";
            this.dgFactura.Size = new System.Drawing.Size(783, 166);
            this.dgFactura.TabIndex = 5;
            this.dgFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFactura_CellContentClick);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.dgFactura);
            this.Controls.Add(this.pnlVenta);
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.gbCompra.ResumeLayout(false);
            this.gbCompra.PerformLayout();
            this.pnlDevolucion.ResumeLayout(false);
            this.gbGenerales.ResumeLayout(false);
            this.gbGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbCompra;
        private System.Windows.Forms.GroupBox gbGenerales;
        private System.Windows.Forms.Label lblTotalResultado;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.DateTimePicker dtFechaDev;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.ComboBox cbxPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.ComboBox cbxPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbAlquiler;
        private System.Windows.Forms.RadioButton rbVenta;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlPelicula;
        private System.Windows.Forms.Panel pnlPago;
        private System.Windows.Forms.Panel pnlDevolucion;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}