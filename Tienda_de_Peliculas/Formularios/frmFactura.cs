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

        #region CLASES, IMPORTACIONES, DECLARACIONES, ETC
        FacturaDAL fac = new FacturaDAL();
        ClientesDAL clie = new ClientesDAL();
        MetodosPagoDAL meto = new MetodosPagoDAL(); 
        InventarioDAL inv = new InventarioDAL();  

        public DatosUsuarioViewModel UsuarioActual { get;}
        public DescuentoViewModel DescuentoActual { get;}

        private int id_filaSeleccionada;
        private decimal Subtotal;
        private decimal Descuento;
        private decimal ISV = 15;
        private decimal Impuesto;
        private decimal Total;
        

        // CALCULAR IMPORTE : CANTIDAD * PRODUCTO
        // CALULAR LOS IMPUESTOS: IMPORTE * 15 / 100
        // CALCULAR SUBTOTAL = IMPORTA + IMPUESTO
        // 

        #endregion

        #region DISEÑO
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

            lblDesc.BackColor = ThemeColor.PrimaryColor;
            lblDesc.ForeColor = Color.White;

        }
        #endregion

        #region CRUD
        public void Listado_Factura()
        {
           dgFactura.DataSource=FacturaDAL.listarfactura();
        }

        public void DibujarNumeroFactura()
        {
            string ultimoNum = FacturaDAL.UltimoNumeroFactura();
            string Anio = DateTime.Now.Year.ToString();
            string HollyWoodVideos = "HW";
            
            int numProximo = Convert.ToInt32(ultimoNum) + 1;
            

            string formatoNumeroFactura = HollyWoodVideos + Anio + "-" + numProximo.ToString("0000");

            lblNumFactura.Text = formatoNumeroFactura;
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

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void LimpiarCampos()
        {
            cbxCliente.SelectedIndex = 0;
            cbxPago.SelectedIndex = 0;
            cbxPelicula.SelectedIndex = 0;

            
            rbAlquiler.Checked = false;
            rbVenta.Checked = false;

            
            lblFechaDev.Visible = false;
            dtFechaDev.Visible = false;
            dtFechaDev.Value = DateTime.Now;

            txtStock.Clear();
            cbxCliente.Enabled = false;

            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtImpuesto.Clear();
            lblTotalResultado.Text = 0.ToString("C");

        }
        #endregion

        #region EVENTOS DEL FORMULARIO
        private void frmFactura_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Listado_Factura();
            CargarClientesCMB();
            CargarMetodosPagoCMB();
            CargarInventarioCMB();
            DibujarNumeroFactura();
           

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

        private void rbAlquiler_CheckedChanged(object sender, EventArgs e)
        {
            cbxPago.Visible = true;
            label2.Visible = true;

            lblFechaDev.Visible = true;
            dtFechaDev.Visible = true;
            txtCantidad.Visible = false;
            lblCantidad.Visible = false;
        }

        private void rbVenta_CheckedChanged(object sender, EventArgs e)
        {
            cbxPago.Visible = true;
            label2.Visible = true;

            lblCantidad.Visible= true;
            dtFechaDev.Visible = false;
            lblFechaDev.Visible = false;
            txtCantidad.Visible= true;
        }

        private void cbxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPelicula.SelectedValue == null || !(cbxPelicula.SelectedValue is int))
            {
               return;
            }

            int inve_ID = (int)cbxPelicula.SelectedValue;
            List<InventarioViewModel> pelicula = fac.PrecioPorPeli(inve_ID);
            if (pelicula != null && pelicula.Count > 0)
            {
                InventarioViewModel peli = pelicula[0];
                Subtotal = peli.inve_Precio;
                Impuesto = (Subtotal) * (ISV / 100);

                txtStock.Text = peli.inve_Cantidad.ToString();
                txtSubtotal.Text = Subtotal.ToString("C");
                txtImpuesto.Text = Impuesto.ToString("C");

                cbxCliente.Enabled = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();

        }

       

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedValue == null || !(cbxCliente.SelectedValue is int))
            {
                return;
            }

            int dato_Id = (int)cbxCliente.SelectedValue;
            List<DescuentoViewModel> descuentos = fac.DescuentoPorCliente(dato_Id);
            if (descuentos != null && descuentos.Count > 0)
            {
                DescuentoViewModel descuento = descuentos[0];
               
               
                Descuento = descuento.descu_Porcentaje * (Subtotal+Impuesto);
                Total = Subtotal - Descuento + Impuesto;

                lblDesc.Text = descuento.descu_Descripcion;
                txtDescuento.Text = Descuento.ToString("C");
                lblTotalResultado.Text = Total.ToString("C");
            }
            else
            {
                lblDesc.Text = "No hay descuento disponible";
                txtDescuento.Text = 0.ToString("C");
                Descuento = 0;
                

                Impuesto = (Subtotal) * (ISV / 100);
                Total = Subtotal - Descuento + Impuesto;
                txtDescuento.Text = Descuento.ToString("C");
                txtImpuesto.Text = Impuesto.ToString("C");
                lblTotalResultado.Text = Total.ToString("C");
            }

        }

        #endregion
    }



}
