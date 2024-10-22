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

        public frmInventario()
        {
            InitializeComponent();
        }

        #region Validaciones
        public void ValidacionVacio()
        {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidacionVacio();
        }
    }
}
