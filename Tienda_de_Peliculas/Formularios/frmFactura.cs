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
        //MetodosPagoDAL meto = new MetodosPagoDAL(); 
        InventarioDAL inv = new InventarioDAL();  

        public DatosUsuarioViewModel UsuarioActual { get;} 

        private int id_filaSeleccionada;

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

        #region validaciones limpieza de campo 

        #endregion

        #region crud
        public void listado_factura()
        {
           dgFactura.DataSource=FacturaDAL.listarfactura();
        }

        #endregion
        //combobox 
        #region LLENANDO COMBOBOX

        public void CargarMetodosPagoCMB()
        {
            //cbxPago.DataSource = metodosPago.CargarMetodosPago();
            cbxPago.ValueMember = "meto_Id";
            cbxPago.DisplayMember = "meto_Descripcion";
        }

        public void CargarClientesCMB()
        {
           //cbxCliente.DataSource = Clientes.CargarClientes();
            cbxCliente.ValueMember = "dato_Id";
            cbxCliente.DisplayMember = "dato_NombreCompleto";
        }

        public void CargarInventarioCMB()
        {
            
            //cbxPelicula.DataSource = inventario.CargarInventario();
            cbxPelicula.ValueMember = "inve_Id";
            cbxPelicula.DisplayMember = "inve_Titulo";
        }
        #endregion
        private void frmFactura_Load(object sender, EventArgs e)
        {   

            listado_factura();

            LoadTheme();
        }


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNumFactura_Click(object sender, EventArgs e)
        {
            int NumFactura = 1;
            lblNumFactura.Text = "FAC#" + NumFactura.ToString("D6"); 
            NumFactura++;

        }

        private void cbxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

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
