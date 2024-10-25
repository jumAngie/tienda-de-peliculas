using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.Reportes;

namespace Tienda_de_Peliculas
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            pnlReporteVentas.BackColor = ThemeColor.PrimaryColor;
            pnlReporteAlquileres.BackColor = ThemeColor.PrimaryColor;
            pnlReporteClientes.BackColor = ThemeColor.SecondaryColor;
            pnlReporteInventario.BackColor = ThemeColor.SecondaryColor;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void pnlReporteVentas_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pnlReporteVentas_MouseClick(object sender, MouseEventArgs e)
        {
            frmReporteVentas reporteVentasForm = new frmReporteVentas();
            reporteVentasForm.Show();
        }
    }
}
