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
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        PaisesDAL pa = new PaisesDAL();
        DepartamentosDAL dep = new DepartamentosDAL();

        #region CRUD
        public void Listado_Ciudades()
        {
            dgCiudades.DataSource = CiudadesDAL.ListarCiudades();
        }

        public void Insertar_Ciudades()
        {
            Ciudades nuevaCiudad = new Ciudades
            {
                ciud_Descripcion = txtNombreCiudad.Text,
                dept_Id = Convert.ToInt32(cboDepartamentos.SelectedValue),
                usua_UsuarioCreacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                ciud_FechaCreacion = DateTime.Now
            };

            string resultado = CiudadesDAL.InsertarCiudades(nuevaCiudad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Llenado de ComboBoxs
        public void CargarPaisesCMB()
        {
            cboPaises.DataSource = pa.CargarPaises();
            cboPaises.DisplayMember = "pais_Descripcion";
            cboPaises.ValueMember = "pais_Id";
        }

        public void CargarDepartamentosPorPaisCMB(int pais_Id)
        {
            cboDepartamentos.DataSource = dep.CargarDepartamentosPorPais(pais_Id);
            cboDepartamentos.DisplayMember = "dept_Descripcion";
            cboDepartamentos.ValueMember = "dept_Id";
        }
        #endregion

        #region Validaciones y Limpieza de Campos
        public void LimpiarCampos()
        {
            cboDepartamentos.SelectedIndex = 0;
            cboPaises.SelectedIndex = 0;
            txtNombreCiudad.Clear();
        }

        public bool ValidarVacio()
        {
            bool esValido = false;
            // Que aparezca el panel que indica error
            if(cboPaises.SelectedIndex == 0){ pnlPais.Visible = true; }
            if (cboDepartamentos.SelectedIndex == -1 || cboDepartamentos.SelectedIndex == 0) { pnlDepartamento.Visible = true; }
            if (txtNombreCiudad.Text == "") { pnlNombre.Visible = true; }

            // Que desaparezca el panel que indica error
            if (cboPaises.SelectedIndex != 0) { pnlPais.Visible = false; }
            if (cboDepartamentos.SelectedIndex != -1 && cboDepartamentos.SelectedIndex != 0) { pnlDepartamento.Visible = false; }
            if (txtNombreCiudad.Text != "") { pnlNombre.Visible = false; }

            if(cboPaises.SelectedIndex != 0 && cboDepartamentos.SelectedIndex != 0 && txtNombreCiudad.Text != "")
            { 
                esValido = true;
            }
            else
            {
                esValido = false;
            }

            return esValido;
        }
        #endregion

        #region Mensajes
        public void MensajeAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }
        public void MensajeAdvertencia_Hide()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            Listado_Ciudades();
            CargarPaisesCMB();
            cboDepartamentos.Enabled = false;
            cboDepartamentos.Text = "Debe seleccionar un Pais.";
        }

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaises.SelectedValue != null && cboPaises.SelectedValue is int)
            {
                cboDepartamentos.Enabled = true;
                int pais_Id = (int)cboPaises.SelectedValue;
                CargarDepartamentosPorPaisCMB(pais_Id);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidarVacio();
                if (esValido) 
                {
                    Insertar_Ciudades();
                    Listado_Ciudades();
                    LimpiarCampos();
                }
                else
                { 
                    MensajeAdvertencia();
                    await Task.Delay(4000);
                    MensajeAdvertencia_Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
