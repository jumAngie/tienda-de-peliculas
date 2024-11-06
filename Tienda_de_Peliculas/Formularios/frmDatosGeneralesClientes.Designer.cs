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
            this.lblDirE = new System.Windows.Forms.Label();
            this.txbDirE = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cbxDepto = new System.Windows.Forms.ComboBox();
            this.cbxCiudad = new System.Windows.Forms.ComboBox();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.pnldireccion = new System.Windows.Forms.Panel();
            this.pnlciudad = new System.Windows.Forms.Panel();
            this.pnltel = new System.Windows.Forms.Panel();
            this.pnlemail = new System.Windows.Forms.Panel();
            this.pnldepto = new System.Windows.Forms.Panel();
            this.pnlpais = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgDatosCliente = new System.Windows.Forms.DataGridView();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblidentidad = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.mtxbDNI = new System.Windows.Forms.MaskedTextBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlnombre = new System.Windows.Forms.Panel();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.rbE = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.txbDNIE = new System.Windows.Forms.TextBox();
            this.lblDNIE = new System.Windows.Forms.Label();
            this.pnlDNI = new System.Windows.Forms.Panel();
            this.pnlDNIE = new System.Windows.Forms.Panel();
            this.gbDNI = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbDNI.SuspendLayout();
            this.SuspendLayout();
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
            this.txbDirE.Location = new System.Drawing.Point(20, 224);
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
            this.lblDir.BackColor = System.Drawing.SystemColors.Control;
            this.lblDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDir.ForeColor = System.Drawing.Color.White;
            this.lblDir.Location = new System.Drawing.Point(148, 83);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(72, 15);
            this.lblDir.TabIndex = 18;
            this.lblDir.Text = "Dirección:";
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
            this.txbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTel_KeyPress);

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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAdvertencia);
            this.groupBox2.Controls.Add(this.txbDirE);
            this.groupBox2.Controls.Add(this.txbTel);
            this.groupBox2.Controls.Add(this.lblTel);
            this.groupBox2.Controls.Add(this.txbemail);
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.lblDirE);
            this.groupBox2.Controls.Add(this.lblDir);
            this.groupBox2.Controls.Add(this.cbxCiudad);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.cbxPais);
            this.groupBox2.Controls.Add(this.pnldireccion);
            this.groupBox2.Controls.Add(this.lblDepto);
            this.groupBox2.Controls.Add(this.cbxDepto);
            this.groupBox2.Controls.Add(this.lblPais);
            this.groupBox2.Controls.Add(this.pnlciudad);
            this.groupBox2.Controls.Add(this.pnltel);
            this.groupBox2.Controls.Add(this.pnlemail);
            this.groupBox2.Controls.Add(this.pnldepto);
            this.groupBox2.Controls.Add(this.pnlpais);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(415, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 284);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Contacto";
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdvertencia.Location = new System.Drawing.Point(187, 0);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(193, 16);
            this.lblAdvertencia.TabIndex = 37;
            this.lblAdvertencia.Text = "¡Debe llenar todos los campos!";
            // 
            // pnldireccion
            // 
            this.pnldireccion.BackColor = System.Drawing.Color.DarkRed;
            this.pnldireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldireccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnldireccion.Location = new System.Drawing.Point(20, 237);
            this.pnldireccion.Name = "pnldireccion";
            this.pnldireccion.Size = new System.Drawing.Size(354, 24);
            this.pnldireccion.TabIndex = 31;
            this.pnldireccion.Visible = false;
            // 
            // pnlciudad
            // 
            this.pnlciudad.BackColor = System.Drawing.Color.DarkRed;
            this.pnlciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlciudad.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlciudad.Location = new System.Drawing.Point(20, 174);
            this.pnlciudad.Name = "pnlciudad";
            this.pnlciudad.Size = new System.Drawing.Size(354, 20);
            this.pnlciudad.TabIndex = 32;
            this.pnlciudad.Visible = false;
            // 
            // pnltel
            // 
            this.pnltel.BackColor = System.Drawing.Color.DarkRed;
            this.pnltel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltel.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnltel.Location = new System.Drawing.Point(20, 51);
            this.pnltel.Name = "pnltel";
            this.pnltel.Size = new System.Drawing.Size(151, 20);
            this.pnltel.TabIndex = 33;
            this.pnltel.Visible = false;
            // 
            // pnlemail
            // 
            this.pnlemail.BackColor = System.Drawing.Color.DarkRed;
            this.pnlemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlemail.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlemail.Location = new System.Drawing.Point(177, 51);
            this.pnlemail.Name = "pnlemail";
            this.pnlemail.Size = new System.Drawing.Size(197, 20);
            this.pnlemail.TabIndex = 34;
            this.pnlemail.Visible = false;
            // 
            // pnldepto
            // 
            this.pnldepto.BackColor = System.Drawing.Color.DarkRed;
            this.pnldepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldepto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnldepto.Location = new System.Drawing.Point(177, 118);
            this.pnldepto.Name = "pnldepto";
            this.pnldepto.Size = new System.Drawing.Size(197, 24);
            this.pnldepto.TabIndex = 35;
            this.pnldepto.Visible = false;
            // 
            // pnlpais
            // 
            this.pnlpais.BackColor = System.Drawing.Color.DarkRed;
            this.pnlpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlpais.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlpais.Location = new System.Drawing.Point(20, 122);
            this.pnlpais.Name = "pnlpais";
            this.pnlpais.Size = new System.Drawing.Size(151, 20);
            this.pnlpais.TabIndex = 36;
            this.pnlpais.Visible = false;
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
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaN.Location = new System.Drawing.Point(211, 83);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(127, 15);
            this.lblFechaN.TabIndex = 8;
            this.lblFechaN.Text = "Fecha de Nacimiento:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(17, 83);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(38, 15);
            this.lblSex.TabIndex = 27;
            this.lblSex.Text = "Sexo:";
            // 
            // lblidentidad
            // 
            this.lblidentidad.AutoSize = true;
            this.lblidentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentidad.Location = new System.Drawing.Point(10, 72);
            this.lblidentidad.Name = "lblidentidad";
            this.lblidentidad.Size = new System.Drawing.Size(126, 15);
            this.lblidentidad.TabIndex = 2;
            this.lblidentidad.Text = "Número de Identidad:";
            this.lblidentidad.Visible = false;
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
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(20, 48);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(354, 20);
            this.txbName.TabIndex = 1;
            // 
            // mtxbDNI
            // 
            this.mtxbDNI.Location = new System.Drawing.Point(13, 89);
            this.mtxbDNI.Mask = "0000-0000-00000";
            this.mtxbDNI.Name = "mtxbDNI";
            this.mtxbDNI.Size = new System.Drawing.Size(131, 20);
            this.mtxbDNI.TabIndex = 3;
            this.mtxbDNI.Visible = false;
            this.mtxbDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbDNI_KeyPress);

            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(214, 104);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.dtFechaNacimiento.TabIndex = 9;
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(13, 108);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 17);
            this.rbF.TabIndex = 28;
            this.rbF.TabStop = true;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(111, 108);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(73, 17);
            this.rbM.TabIndex = 29;
            this.rbM.TabStop = true;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.dtFechaNacimiento);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblFechaN);
            this.groupBox1.Controls.Add(this.pnlnombre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 142);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // pnlnombre
            // 
            this.pnlnombre.BackColor = System.Drawing.Color.DarkRed;
            this.pnlnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlnombre.Location = new System.Drawing.Point(20, 48);
            this.pnlnombre.Name = "pnlnombre";
            this.pnlnombre.Size = new System.Drawing.Size(354, 23);
            this.pnlnombre.TabIndex = 30;
            this.pnlnombre.Visible = false;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(17, 22);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(52, 13);
            this.lblNacionalidad.TabIndex = 41;
            this.lblNacionalidad.Text = "Usted es:";
            // 
            // rbE
            // 
            this.rbE.AutoSize = true;
            this.rbE.Location = new System.Drawing.Point(132, 38);
            this.rbE.Name = "rbE";
            this.rbE.Size = new System.Drawing.Size(72, 17);
            this.rbE.TabIndex = 40;
            this.rbE.TabStop = true;
            this.rbE.Text = "Extranjero";
            this.rbE.UseVisualStyleBackColor = true;
            this.rbE.CheckedChanged += new System.EventHandler(this.rbE_CheckedChanged);
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(20, 38);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(78, 17);
            this.rbH.TabIndex = 39;
            this.rbH.TabStop = true;
            this.rbH.Text = "Hondureño";
            this.rbH.UseVisualStyleBackColor = true;
            this.rbH.CheckedChanged += new System.EventHandler(this.rbH_CheckedChanged);
            // 
            // txbDNIE
            // 
            this.txbDNIE.Location = new System.Drawing.Point(189, 90);
            this.txbDNIE.MaxLength = 20;
            this.txbDNIE.Name = "txbDNIE";
            this.txbDNIE.Size = new System.Drawing.Size(185, 20);
            this.txbDNIE.TabIndex = 38;
            this.txbDNIE.Visible = false;
            // 
            // lblDNIE
            // 
            this.lblDNIE.AutoSize = true;
            this.lblDNIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIE.Location = new System.Drawing.Point(186, 73);
            this.lblDNIE.Name = "lblDNIE";
            this.lblDNIE.Size = new System.Drawing.Size(191, 15);
            this.lblDNIE.TabIndex = 38;
            this.lblDNIE.Text = "Número de Identidad Extranjeros:";
            this.lblDNIE.Visible = false;
            // 
            // pnlDNI
            // 
            this.pnlDNI.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDNI.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDNI.Location = new System.Drawing.Point(13, 94);
            this.pnlDNI.Name = "pnlDNI";
            this.pnlDNI.Size = new System.Drawing.Size(131, 19);
            this.pnlDNI.TabIndex = 37;
            this.pnlDNI.Visible = false;
            // 
            // pnlDNIE
            // 
            this.pnlDNIE.BackColor = System.Drawing.Color.DarkRed;
            this.pnlDNIE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDNIE.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlDNIE.Location = new System.Drawing.Point(189, 94);
            this.pnlDNIE.Name = "pnlDNIE";
            this.pnlDNIE.Size = new System.Drawing.Size(185, 19);
            this.pnlDNIE.TabIndex = 38;
            this.pnlDNIE.Visible = false;
            // 
            // gbDNI
            // 
            this.gbDNI.Controls.Add(this.lblidentidad);
            this.gbDNI.Controls.Add(this.txbDNIE);
            this.gbDNI.Controls.Add(this.mtxbDNI);
            this.gbDNI.Controls.Add(this.lblNacionalidad);
            this.gbDNI.Controls.Add(this.rbE);
            this.gbDNI.Controls.Add(this.rbH);
            this.gbDNI.Controls.Add(this.pnlDNI);
            this.gbDNI.Controls.Add(this.lblDNIE);
            this.gbDNI.Controls.Add(this.pnlDNIE);
            this.gbDNI.Location = new System.Drawing.Point(15, 164);
            this.gbDNI.Name = "gbDNI";
            this.gbDNI.Size = new System.Drawing.Size(394, 132);
            this.gbDNI.TabIndex = 43;
            this.gbDNI.TabStop = false;
            this.gbDNI.Text = "Datos de Identificación";
            // 
            // frmDatosGeneralesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 519);
            this.Controls.Add(this.gbDNI);
            this.Controls.Add(this.dgDatosCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDatosGeneralesClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmDatosGeneralesCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatosCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDNI.ResumeLayout(false);
            this.gbDNI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDirE;
        private System.Windows.Forms.TextBox txbDirE;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cbxDepto;
        private System.Windows.Forms.ComboBox cbxCiudad;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgDatosCliente;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblidentidad;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.MaskedTextBox mtxbDNI;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlnombre;
        private System.Windows.Forms.Panel pnldireccion;
        private System.Windows.Forms.Panel pnlciudad;
        private System.Windows.Forms.Panel pnltel;
        private System.Windows.Forms.Panel pnlemail;
        private System.Windows.Forms.Panel pnldepto;
        private System.Windows.Forms.Panel pnlpais;
        private System.Windows.Forms.Panel pnlDNI;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox txbDNIE;
        private System.Windows.Forms.Label lblDNIE;
        private System.Windows.Forms.Panel pnlDNIE;
        private System.Windows.Forms.RadioButton rbE;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.GroupBox gbDNI;
    }
}