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
            //CargarGeneros();
            //CargarIdiomas();
            //CargarClasificaciones();
            //CargarFormatos();
            //CargarEstados();

        }
    }
}
