using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.DAL;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Xml.Linq;
using Tienda_de_Peliculas.Properties;


namespace Tienda_de_Peliculas.Reportes
{
    public partial class frmReporteVentas : Form
    {
        private InventarioDAL inv = new InventarioDAL();
        private ReportesDAL reportes = new ReportesDAL();
        public frmReporteVentas()
        {
            InitializeComponent();
        }

        #region DISEÑO
        private void LoadTheme()
        {
            lblTitulo.ForeColor = ThemeColor.PrimaryColor;
            lblTotalTexto.BackColor = ThemeColor.PrimaryColor;
            lblTotalTexto.ForeColor = Color.White;
            lblTotal.ForeColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnImprimir.BackColor = ThemeColor.PrimaryColor;
            btnImprimir.ForeColor = Color.White;
            btnImprimir.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblVolver.ForeColor = Color.White;
            lblVolver.BackColor = ThemeColor.PrimaryColor;
            btnBuscar.BackColor = ThemeColor.PrimaryColor;
            btnBuscar.ForeColor = Color.White;
        }
        #endregion

        public void CargarPeliculas()
        {
            cmbPelicula.DataSource = inv.CargarPeliculas();
            cmbPelicula.ValueMember = "inve_Id";
            cmbPelicula.DisplayMember = "inve_Titulo";
        }

        public void CargarVentas()
        {
            int pelicula = (int)cmbPelicula.SelectedValue;
            DateTime rI = dtFechaInicio.Value;
            DateTime rF = dtFechaFinal.Value;

            dgReporte.DataSource = reportes.VentasPorPeliculas(pelicula, rI, rF);
            lblTotal.Text = reportes.VentasPorPelicula_TOTAL(pelicula,rI,rF).ToString("C");
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            LoadTheme();
            CargarPeliculas();
            cmbPelicula.Focus();
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           CargarVentas();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "REPORTE VENTAS POR PELICULAS - " + string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));
            

           
        }
    }
}
