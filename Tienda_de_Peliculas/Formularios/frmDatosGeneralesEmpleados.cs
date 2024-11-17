using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.DAL;

namespace Tienda_de_Peliculas
{
    public partial class frmDatosGeneralesEmpleados : Form
    {
        #region CLASES
        PaisesDAL paises = new PaisesDAL();
        DepartamentosDAL depto = new DepartamentosDAL();
        CiudadesDAL ciudad = new CiudadesDAL();
        #endregion
        #region VARIABLES
        private int sexo = 0;
        private int empleado = 1;
        #endregion
        public frmDatosGeneralesEmpleados()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.PrimaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblDir.BackColor = ThemeColor.SecondaryColor;
            lblDir.ForeColor = Color.White;

        }

        private void frmDatosGeneralesEmpleados_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }


        #region CRUD
        public void ListarEmpleados()
        {
            dgDatosEmpleado.DataSource = EmpleadosDAL.ListarEmpleados();
        }

        public void InsertarEmpleados()
        {
            if (rbF.Checked) sexo = 1;
            if (rbM.Checked) sexo = 2;

            DatosGenerales Dg = new DatosGenerales
            {
                dato_NombreCompleto = txbName.Text,
                dato_DNI = mtxbDNI.Text,
                dato_Telefono = txbTel.Text,
                dato_FechaNacimiento = dtFechaNacimiento.Value,
                sexo_Id = sexo,
                dato_email = txbemail.Text,
                ciud_Id = Convert.ToInt32(cbxCiudad.SelectedValue),
                dato_Direccion = txbDirE.Text,
                cate_Id = empleado,
                dato_FechaCreacion = DateTime.Now,
                usua_UsuarioCreacion = 1
            };

            string resultados = EmpleadosDAL.InsertarEmpleados(Dg);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region LLENANDO COMBOBOX
        public void CargarPaisesCMB()
        {
            cbxPais.DataSource = paises.CargarPaises();
            cbxPais.ValueMember = "pais_Id";
            cbxPais.DisplayMember = "pais_Descripcion";
        }

        private void CargarDeptoPorPaisCMB(int pais_Id)
        {
            cbxDepto.DataSource = depto.CargarDepartamentosPorPais(pais_Id);
            cbxDepto.ValueMember = "dept_Id";
            cbxDepto.DisplayMember = "dept_Descripcion";
        }
        public void CargarCiudadesporDepartamentoCMB(int dept_Id)
        {
            cbxCiudad.DataSource = ciudad.CargarCiudadesPorDepto(dept_Id);
            cbxCiudad.ValueMember = "ciud_Id";
            cbxCiudad.DisplayMember = "ciud_Descripcion";
        }
        #endregion
        #region VALIDACIONES Y LIMPIEZA DE CAMPOS

        public bool ValidandoVacios()
        {
            bool esvalido = true;

            // mostrar error
            if (txbName.Text == "") { pnlname.Visible = true; esvalido = false; }
            if (txbemail.Text == "") { pnlemail.Visible = true; esvalido = false; }
            if (txbTel.Text == "") { pnltel.Visible = true; esvalido = false; }

            // Validación condicional del DNI y DNIE
            if (rbH.Checked && !mtxbDNI.MaskFull) // Si está seleccionado el radio button de DNI
            {
                pnlDNI.Visible = true;
                esvalido = false;
            }
            else
            {
                pnlDNI.Visible = false;
            }

            if (rbE.Checked && txbDNIE.Text == "") // Si está seleccionado el radio button de DNIE
            {
                pnlDNIE.Visible = true;
                esvalido = false;
            }
            else
            {
                pnlDNIE.Visible = false;
            }

            if (cbxPais.SelectedIndex == 0 || cbxPais.SelectedIndex == -1) { pnlpais.Visible = true; esvalido = false; }
            if (cbxDepto.SelectedIndex == 0 || cbxDepto.SelectedIndex == -1) { pnldepto.Visible = true; esvalido = false; }
            if (cbxCiudad.SelectedIndex == 0 || cbxCiudad.SelectedIndex == -1) { pnlciudad.Visible = true; esvalido = false; }
            if (txbDirE.Text == "") { pnldirE.Visible = true; esvalido = false; }

            // esconder error
            pnlname.Visible = txbName.Text == "";
            pnlemail.Visible = txbemail.Text == "";
            pnltel.Visible = txbTel.Text == "";
            pnlpais.Visible = cbxPais.SelectedIndex == 0 || cbxPais.SelectedIndex == -1;
            pnldepto.Visible = cbxDepto.SelectedIndex == 0 || cbxDepto.SelectedIndex == -1;
            pnlciudad.Visible = cbxCiudad.SelectedIndex == 0 || cbxCiudad.SelectedIndex == -1;
            pnldirE.Visible = txbDirE.Text == "";

            return esvalido;
        }

        //VALIDACIONES NÚMEROS
        ErrorProvider errortelefono = new ErrorProvider();
        private void txbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errortelefono.SetError(txbTel, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errortelefono.Clear();
            }
        }



        ErrorProvider errorDNI = new ErrorProvider();
        private void mtxbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorDNI.SetError(mtxbDNI, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorDNI.Clear();
            }
        }

        //VALIDACIONES EMAIL
        ErrorProvider erroremail = new ErrorProvider();
        private void txbemail_Leave(object sender, EventArgs e)
        {
            if (!Validaciones.validarEmail(txbemail.Text))
                erroremail.SetError(txbemail, "Correo no válido");
            else
                erroremail.Clear();
        }

        public void LimpiarCampos()
        {
            txbName.Clear();
            txbTel.Clear();
            txbDirE.Clear();
            txbemail.Clear();
            mtxbDNI.Clear();
            txbDNIE.Clear();
            rbH.Checked = false;
            rbE.Checked = false;
            rbF.Checked = false;
            rbM.Checked = false;
            cbxCiudad.Enabled = false;
            cbxDepto.Enabled = false;
            cbxDepto.Text = "Seleccione un país.";
            cbxCiudad.Text = "Seleccione un departamento.";
            cbxPais.SelectedIndex = 0;
            dtFechaNacimiento.Value = DateTime.Now;
            lblidentidad.Visible = false;
            mtxbDNI.Visible = false;
            lblDNIE.Visible = false;
            txbDNIE.Visible = false;
        }


        //OCULTAR VALIDACIONES
        public void panel_OcultarValidaciones()
        {
            pnlname.Visible = false;
            pnlDNI.Visible = false;
            pnltel.Visible = false;
            pnlemail.Visible = false;

            pnlpais.Visible = false;
            pnldepto.Visible = false;
            pnlciudad.Visible = false;

            pnldirE.Visible = false;
            pnlDNIE.Visible = false;
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void frmDatosGeneralesEmpleado_Load (object sender, EventArgs e)
        {
            LoadTheme();
            ListarEmpleados();
            CargarPaisesCMB();
            cbxDepto.Text = "Seleccione un país.";
            cbxCiudad.Text = "Seleccione un departamento.";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidandoVacios();
            if (esValido)
            {
                InsertarEmpleados();
                ListarEmpleados();
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }
        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPais.SelectedValue != null && cbxPais.SelectedValue is int)
            {
                cbxDepto.Enabled = true;
                int pais_Id = (int)cbxPais.SelectedValue;
                CargarDeptoPorPaisCMB(pais_Id);
            }
        }

        private void cbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepto.SelectedValue != null && cbxDepto.SelectedValue is int)
            {

                int dept_Id = (int)cbxDepto.SelectedValue;
                if (dept_Id > 0) // verifica que sea un valor válidop
                {
                    cbxCiudad.Enabled = true;
                    CargarCiudadesporDepartamentoCMB(dept_Id);
                }
            }
            else
            {
                cbxCiudad.DataSource = null;
                cbxCiudad.Enabled = false;
            }
        }

        
        #endregion
        #region MENSAJES
        public void MensajeAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }
        public void MensajeAdvertencia_Hide()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion
        private void rbH_CheckedChanged(object sender, EventArgs e)
        {
            lblidentidad.Visible = true;
            mtxbDNI.Visible = true;
            lblDNIE.Visible = false;
            txbDNIE.Visible = false;
        }

        private void rbE_CheckedChanged(object sender, EventArgs e)
        {
            lblDNIE.Visible = true;
            txbDNIE.Visible = true;
            lblidentidad.Visible = false;
            mtxbDNI.Visible = false;
        }
    }
}
