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
            savefile.FileName = "REPORTE VENTAS POR PELICULAS - " + string.Format("{0}.pdf", DateTime.Now.ToString("dd/MM/yyyy"));

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPOREPORTE", lblTitulo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA",  dtFechaInicio.Value.ToString("d") + " - " + dtFechaFinal.Value.ToString("d"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USERNAME", "jumAngie");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMISION", DateTime.Now.ToString("g"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgReporte.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["inve_Id"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["inve_Titulo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["fact_NumFactura"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["inve_Total"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["inve_Total"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }

        }
    }
}
