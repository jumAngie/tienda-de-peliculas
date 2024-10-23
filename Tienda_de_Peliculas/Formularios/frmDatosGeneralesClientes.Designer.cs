namespace Tienda_de_Peliculas
{
    partial class frmDatosGeneralesClientes
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
            this.lblSex = new System.Windows.Forms.Label();
            this.lblDirE = new System.Windows.Forms.Label();
            this.txbDirE = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbxDepto = new System.Windows.Forms.ComboBox();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblidentidad = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.mtxbDNI = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgDatosCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(23, 150);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(38, 15);
            this.lblSex.TabIndex = 27;
            this.lblSex.Text = "Sexo:";
            // 
            // lblDirE
            // 
            this.lblDirE.AutoSize = true;
            this.lblDirE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirE.Location = new System.Drawing.Point(17, 202);
            this.lblDirE.Name = "lblDirE";
            this.lblDirE.Size = new System.Drawing.Size(101, 15);
            this.lblDirE.TabIndex = 26;
            this.lblDirE.Text = "Dirección exacta:";
            // 
            // txbDirE
            // 
            this.txbDirE.Location = new System.Drawing.Point(20, 220);
            this.txbDirE.MaxLength = 200;
            this.txbDirE.Multiline = true;
            this.txbDirE.Name = "txbDirE";
            this.txbDirE.Size = new System.Drawing.Size(354, 33);
            this.txbDirE.TabIndex = 20;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(17, 152);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(49, 15);
            this.lblCiudad.TabIndex = 24;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepto.Location = new System.Drawing.Point(174, 100);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(89, 15);
            this.lblDepto.TabIndex = 23;
            this.lblDepto.Text = "Departamento:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(17, 100);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 22;
            this.lblPais.Text = "País:";
            // 
            // cbxDepto
            // 
            this.cbxDepto.Enabled = false;
            this.cbxDepto.FormattingEnabled = true;
            this.cbxDepto.Location = new System.Drawing.Point(177, 118);
            this.cbxDepto.Name = "cbxDepto";
            this.cbxDepto.Size = new System.Drawing.Size(197, 21);
            this.cbxDepto.TabIndex = 21;
            this.cbxDepto.SelectedIndexChanged += new System.EventHandler(this.cbxDepto_SelectedIndexChanged);
            // 
            // cbxCiudad
            // 
            this.cbxCiudad.Enabled = false;
            this.cbxCiudad.FormattingEnabled = true;
            this.cbxCiudad.Location = new System.Drawing.Point(20, 170);
            this.cbxCiudad.Name = "cbxCiudad";
            this.cbxCiudad.Size = new System.Drawing.Size(354, 21);
            this.cbxCiudad.TabIndex = 20;
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(20, 118);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(151, 21);
            this.cbxPais.TabIndex = 19;
            this.cbxPais.SelectedIndexChanged += new System.EventHandler(this.cbxPais_SelectedIndexChanged);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.White;
            this.lblDir.Location = new System.Drawing.Point(148, 83);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(72, 15);
            this.lblDir.TabIndex = 18;
            this.lblDir.Text = "Dirección:";
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaN.Location = new System.Drawing.Point(172, 83);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(127, 15);
            this.lblFechaN.TabIndex = 8;
            this.lblFechaN.Text = "Fecha de Nacimiento:";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(177, 48);
            this.txbemail.MaxLength = 100;
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(197, 20);
            this.txbemail.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(174, 30);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 15);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "E-mail:";
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(20, 48);
            this.txbTel.MaxLength = 20;
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(151, 20);
            this.txbTel.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(17, 29);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 15);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Teléfono:";
            // 
            // lblidentidad
            // 
            this.lblidentidad.AutoSize = true;
            this.lblidentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentidad.Location = new System.Drawing.Point(17, 83);
            this.lblidentidad.Name = "lblidentidad";
            this.lblidentidad.Size = new System.Drawing.Size(126, 15);
            this.lblidentidad.TabIndex = 2;
            this.lblidentidad.Text = "Número de Identidad:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(20, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(354, 20);
            this.txbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre Completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.dtFechaNacimiento);
            this.groupBox1.Controls.Add(this.mtxbDNI);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblidentidad);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblFechaN);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 284);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(110, 174);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(73, 17);
            this.rbM.TabIndex = 29;
            this.rbM.TabStop = true;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(26, 174);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 17);
            this.rbF.TabIndex = 28;
            this.rbF.TabStop = true;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(175, 104);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(199, 20);
            this.dtFechaNacimiento.TabIndex = 9;
            // 
            // mtxbDNI
            // 
            this.mtxbDNI.Location = new System.Drawing.Point(20, 104);
            this.mtxbDNI.Mask = "0000-0000-00000";
            this.mtxbDNI.Name = "mtxbDNI";
            this.mtxbDNI.Size = new System.Drawing.Size(131, 20);
            this.mtxbDNI.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTel);
            this.groupBox2.Controls.Add(this.lblTel);
            this.groupBox2.Controls.Add(this.txbemail);
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.txbDirE);
            this.groupBox2.Controls.Add(this.lblDirE);
            this.groupBox2.Controls.Add(this.lblDir);
            this.groupBox2.Controls.Add(this.cbxCiudad);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.cbxPais);
            this.groupBox2.Controls.Add(this.lblDepto);
            this.groupBox2.Controls.Add(this.cbxDepto);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 284);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(671, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(541, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 35);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgDatosCliente
            // 
            this.dgDatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatosCliente.Location = new System.Drawing.Point(12, 343);
            this.dgDatosCliente.Name = "dgDatosCliente";
            this.dgDatosCliente.Size = new System.Drawing.Size(783, 166);
            this.dgDatosCliente.TabIndex = 42;
            // 
            // frmDatosGeneralesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.dgDatosCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatosGeneralesClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmDatosGeneralesCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblDirE;
        private System.Windows.Forms.TextBox txbDirE;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cbxDepto;
        private System.Windows.Forms.ComboBox cbxCiudad;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblidentidad;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mtxbDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgDatosCliente;
    }
}