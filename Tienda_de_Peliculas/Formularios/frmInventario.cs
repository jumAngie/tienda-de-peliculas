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
    public partial class frmInventario : Form
    {
        
        GeneroDAL ge = new GeneroDAL();
        IdiomasDAL          idi = new IdiomasDAL();
        ClasificacionesDAL  cl = new ClasificacionesDAL();
        FormatosDAL         frm = new FormatosDAL();
        EstadosDAL          est = new EstadosDAL();
       
        private int usuario_Id = 1;

        public frmInventario()
        {
            InitializeComponent();
        }

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public bool ValidacionVacio()
        {
            bool esValido = false;
            // Mostrar error
            if(txtTitulo.Text == "")            pnlTitulo.Visible = true;
            if (txtAnioLanzamiento.Text == "")  pnlAnio.Visible = true;
            if(cboGeneros.SelectedIndex == 0 || cboGeneros.SelectedIndex == -1)   pnlGenero.Visible = true;
            if(cboIdiomas.SelectedIndex == 0 || cboIdiomas.SelectedIndex == -1) pnlIdioma.Visible = true;
            if(cboClasificacion.SelectedIndex == 0 || cboClasificacion.SelectedIndex == -1) pnlClasificacion.Visible = true;
            if (txtDuracion.Text == "") pnlDuracion.Visible = true;
            if (txtDescripcion.Text == "") pnlDesc.Visible = true;
            if (cboFormatos.SelectedIndex == 0 || cboFormatos.SelectedIndex == -1) pnlFormato.Visible = true;
            if (cboEstados.SelectedIndex == 0 || cboEstados.SelectedIndex == -1) pnlEstado.Visible = true;
            if (txtExistencias.Text == "") pnlExistencias.Visible = true;
            if (txtPrecio.Text == "") pnlPrecio.Visible = true;

            // Esconder error
            if (txtTitulo.Text != "")           pnlTitulo.Visible = false;
            if (txtAnioLanzamiento.Text != "")  pnlAnio.Visible = false;
            if (cboGeneros.SelectedIndex != 0 && cboGeneros.SelectedIndex != -1) pnlGenero.Visible=false;
            if (cboIdiomas.SelectedIndex != 0 && cboIdiomas.SelectedIndex != -1) pnlIdioma.Visible = false;
            if (cboClasificacion.SelectedIndex != 0 && cboClasificacion.SelectedIndex != -1) pnlClasificacion.Visible = false;
            if (txtDuracion.Text != "") pnlDuracion.Visible = false;
            if (txtDescripcion.Text != "") pnlDesc.Visible = false;
            if (cboFormatos.SelectedIndex != 0 && cboFormatos.SelectedIndex != -1) pnlFormato.Visible = false;
            if (cboEstados.SelectedIndex != 0 && cboEstados.SelectedIndex != -1) pnlEstado.Visible = false;
            if (txtExistencias.Text != "") pnlExistencias.Visible = false;
            if (txtPrecio.Text != "") pnlPrecio.Visible = false;

            if(txtTitulo.Text != "" && txtAnioLanzamiento.Text != "" && cboGeneros.SelectedIndex != 0 && cboGeneros.SelectedIndex != -1
                && cboIdiomas.SelectedIndex != 0 && cboIdiomas.SelectedIndex != -1 && cboClasificacion.SelectedIndex != 0 && cboClasificacion.SelectedIndex != -1
                && txtDuracion.Text != "" && txtDescripcion.Text != "" && cboFormatos.SelectedIndex != 0 && cboFormatos.SelectedIndex != -1
                && cboEstados.SelectedIndex != 0 && cboEstados.SelectedIndex != -1 && txtExistencias.Text != ""
                && txtPrecio.Text != "")
            {
                esValido = true;
            }
            else
            {
                esValido = false;
            }


            return esValido;
        }

        public void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAnioLanzamiento.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtExistencias.Clear();
            txtPrecio.Clear();
            cboGeneros.SelectedIndex = 0;
            cboEstados.SelectedIndex = 0;
            cboFormatos.SelectedIndex = 0;
            cboIdiomas.SelectedIndex = 0;
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

        #region DISEÑO
        private void LoadTheme()
        {
                  btnGuardar.BackColor = ThemeColor.PrimaryColor;
                  btnGuardar.ForeColor = Color.White;
                  btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                  btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                  lblPrecioHNL.ForeColor = Color.White;
                  lblPrecioHNL.BackColor = ThemeColor.PrimaryColor;
            
        }
        #endregion

        #region CRUD
        public void Listado_Inventario()
        {
            dgInventario.DataSource = InventarioDAL.ListarInventario();
        }

        public void Insertar_Inventario()
        {
            Inventario inve = new Inventario
            {
                inve_Titulo = txtTitulo.Text,
                inve_Anio = txtAnioLanzamiento.Text,
                gene_Id = Convert.ToInt32(cboGeneros.SelectedValue),
                inve_Duracion = Convert.ToInt32(txtDuracion.Text),
                form_Id = Convert.ToInt32(cboFormatos.SelectedValue),
                esta_Id = Convert.ToInt32(cboEstados.SelectedValue),
                inve_Descripcion = txtDescripcion.Text,
                idio_Id = Convert.ToInt32(cboIdiomas.SelectedValue),
                inve_Cantidad = Convert.ToInt32(txtExistencias.Text),
                inve_Precio = Convert.ToDouble(txtPrecio.Text),
                clas_Id = Convert.ToInt32(cboClasificacion.SelectedValue),
                usua_UsuarioCreacion = usuario_Id,
                inve_FechaCreacion = DateTime.Now,
            };

            string resultados = InventarioDAL.InsertarInventario(inve);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region COMBOBOXS
        public void CargarGeneros()
        {
            cboGeneros.DataSource = ge.CargarGeneros();
            cboGeneros.ValueMember = "gene_Id";
            cboGeneros.DisplayMember = "gene_Descripcion";
        }

        public void CargarIdiomas()
        {
            cboIdiomas.DataSource = idi.CargaIdiomas();
            cboIdiomas.ValueMember = "idio_Id";
            cboIdiomas.DisplayMember = "idio_Descripcion";
        }

        public void CargarClasificaciones()
        {
            cboClasificacion.DataSource = cl.CargarClasificaciones();
            cboClasificacion.ValueMember = "clas_Id";
            cboClasificacion.DisplayMember = "clas_Descripcion";
        }

        public void CargarFormatos()
        {
            cboFormatos.DataSource = frm.CargarFormatos();
            cboFormatos.ValueMember = "form_Id";
            cboFormatos.DisplayMember = "form_Descripcion";
        }

        public void CargarEstados()
        {
            cboEstados.DataSource = est.CargarEstados();
            cboEstados.ValueMember = "esta_Id";
            cboEstados.DisplayMember = "esta_Descripcion";
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void frmInventario_Load(object sender, EventArgs e)
        {
            LoadTheme();
            txtTitulo.Focus();
            Listado_Inventario();
            CargarGeneros();
            CargarIdiomas();
            CargarClasificaciones();
            CargarFormatos();
            CargarEstados();

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionVacio();
            if (esValido)
            {
                Insertar_Inventario();
                Listado_Inventario();
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion

    }
}
