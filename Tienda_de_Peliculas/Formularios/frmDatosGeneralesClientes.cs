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
    public partial class frmDatosGeneralesClientes : Form
    {
        #region CLASES
        PaisesDAL paises = new PaisesDAL();
        DepartamentosDAL depto = new DepartamentosDAL();
        CiudadesDAL ciudad = new CiudadesDAL();
        #endregion
        #region VARIABLES
        private int sexo = 0;
        private int cliente = 2;
        #endregion

        public frmDatosGeneralesClientes()
        {
            InitializeComponent();
        }

        #region DISEÑO
        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.PrimaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblDir.BackColor = ThemeColor.PrimaryColor;

        }
        #endregion

        #region CRUD
        public void ListarClientes()
        {
            dgDatosCliente.DataSource = ClientesDAL.ListarClientes();
        }

        public void InsertarClientes()
        {
            if (rbF.Checked) sexo = 1;
            if(rbM.Checked) sexo = 2;

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
                cate_Id = cliente,
                dato_FechaCreacion = DateTime.Now,
                usua_UsuarioCreacion = 1
            };

            string resultados = ClientesDAL.InsertarClientes(Dg);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region LLENANDO COMBOBOX
        public void CargarPaisesCMB()
        {
            cbxPais.DataSource  = paises.CargarPaises();
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
        public void panel_OcultarValidaciones()
        {
            pnlnombre.Visible = false;
            pnlDNI.Visible = false;
            pnltel.Visible = false;
            pnlemail.Visible = false;

            pnlpais.Visible = false;
            pnldepto.Visible = false;
            pnlciudad.Visible = false;

            pnldireccion.Visible = false;
            pnlDNIE.Visible = false;
        }
        public bool ValidacionesVacio()
        {
            bool esvalido = true;

            // mostrar error
            if (txbName.Text == "") { pnlnombre.Visible = true; esvalido = false; }
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
            if (txbDirE.Text == "") { pnldireccion.Visible = true; esvalido = false; }

            // esconder error
            pnlnombre.Visible = txbName.Text == "";
            pnlemail.Visible = txbemail.Text == "";
            pnltel.Visible = txbTel.Text == "";
            pnlpais.Visible = cbxPais.SelectedIndex == 0 || cbxPais.SelectedIndex == -1;
            pnldepto.Visible = cbxDepto.SelectedIndex == 0 || cbxDepto.SelectedIndex == -1;
            pnlciudad.Visible = cbxCiudad.SelectedIndex == 0 || cbxCiudad.SelectedIndex == -1;
            pnldireccion.Visible = txbDirE.Text == "";

            return esvalido;
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
        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void frmDatosGeneralesCliente_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarClientes();
            CargarPaisesCMB();
            cbxDepto.Text = "Seleccione un país.";
            cbxCiudad.Text = "Seleccione un departamento.";
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();        
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                InsertarClientes();
                ListarClientes();
                LimpiarCampos();
                
            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
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
