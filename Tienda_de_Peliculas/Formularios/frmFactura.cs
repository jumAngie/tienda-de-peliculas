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
using Tienda_de_Peliculas.View_Models;

namespace Tienda_de_Peliculas.Formularios
{
    public partial class frmFactura : Form
    {
        FacturaDAL fac = new FacturaDAL();
        ClientesDAL clie = new ClientesDAL();
        MetodosPagoDAL meto = new MetodosPagoDAL(); 
        InventarioDAL inv = new InventarioDAL();  

        public DatosUsuarioViewModel UsuarioActual { get;} 

        private int id_filaSeleccionada;

        #region Diseño
        public frmFactura()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.SecondaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;

            lblTotal.BackColor = ThemeColor.PrimaryColor;
            lblTotal.ForeColor = Color.White;

            lblSubtotal.ForeColor = ThemeColor.SecondaryColor;
            lblISV.ForeColor = ThemeColor.SecondaryColor;
            lblDescuento.ForeColor = ThemeColor.SecondaryColor;
            lblTotalResultado.ForeColor = ThemeColor.PrimaryColor;
            lblNumFactura.BackColor = ThemeColor.PrimaryColor;
            lblNumFactura.ForeColor = Color.White;

        }
        #endregion

        #region validaciones limpieza de campo 

        #endregion

        #region crud
        public void listado_factura()
        {
           dgFactura.DataSource=FacturaDAL.listarfactura();
        }

        #endregion
        
        #region LLENANDO COMBOBOX

        public void CargarMetodosPagoCMB()
        {
            cbxPago.DataSource = meto.CargarMetodosPago();
            cbxPago.ValueMember = "meto_Id";
            cbxPago.DisplayMember = "meto_Descripcion";
        }

        public void CargarClientesCMB()
        {
           cbxCliente.DataSource = clie.CargarClientes();
            cbxCliente.ValueMember = "dato_Id";
            cbxCliente.DisplayMember = "dato_NombreCompleto";
        }

        public void CargarInventarioCMB()
        {
            
            cbxPelicula.DataSource = inv.CargarPeliculas();
            cbxPelicula.ValueMember = "inve_Id";
            cbxPelicula.DisplayMember = "inve_Titulo";
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void frmFactura_Load(object sender, EventArgs e)
        {
            LoadTheme();
            listado_factura();
            CargarClientesCMB();
            CargarMetodosPagoCMB();
            CargarInventarioCMB();
            cbxCliente.Text = "Nombre de Cliente.";
            cbxPago.Text = "Seleccione un Metodo de Pago";
            cbxPelicula.Text= "Seleccione una Pelicula.";

            #endregion

        # region Añadiendo el boton de eliminar al final de cada registro.
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acciones";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.ForeColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.Font = new Font("Nobile", 9, FontStyle.Regular);
            dgFactura.Columns.Add(btnEliminar);

            LoadTheme();
        }
          #endregion

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void LimpiarCampos()
        {
           
            txtSubtotal.Clear();
            txtDescuento.Clear();          
            txtImpuesto.Clear();

            
            cbxCliente.SelectedIndex = 0;
            cbxPago.SelectedIndex = 0;
            cbxPelicula.SelectedIndex = 0;

            
            rbAlquiler.Checked = false;
            rbVenta.Checked = false;

            
            lblFechaDev.Visible = false;
            dtFechaDev.Visible = false;
            dtFechaDev.Value = DateTime.Now;
            

        }
        #endregion

        #region Alquiler/Venta
        private void rbAlquiler_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaDev.Visible = true;
            dtFechaDev.Visible = true;
        }

        private void rbVenta_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaDev.Visible=false;
            lblFechaDev.Visible = false;
        }

        #endregion

        #region #factura
        private void lblNumFactura_Click(object sender, EventArgs e)
        {
            int NumFactura = 1;
            lblNumFactura.Text = "FAC#" + NumFactura.ToString("D6");
            NumFactura++;

        }
        #endregion

        #region Boton de Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Boton de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();

        }
        #endregion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void cbxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPelicula.SelectedValue != null && cbxPelicula.SelectedValue is int)
            {
                cbxPelicula.Enabled = true;
                int inve_Id = (int)cbxPelicula.SelectedValue;
                CargarInventarioCMB(inve_Id);
            }
        }

        private void CargarInventarioCMB(int inve_Id)
        {
            throw new NotImplementedException();
        }

        private void dgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }



}
