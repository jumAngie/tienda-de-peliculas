using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Peliculas.Formularios
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            btnVenta.BackColor = ThemeColor.PrimaryColor;
            btnVenta.ForeColor = Color.White;
            btnVenta.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnAlquiler.BackColor = ThemeColor.SecondaryColor;
            btnAlquiler.ForeColor = Color.White;
            btnAlquiler.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;

            btnGuardar.BackColor = ThemeColor.SecondaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;

            lblTotal.BackColor = ThemeColor.PrimaryColor;
            lblTotal.ForeColor = Color.White;

            lblSubtotal.ForeColor = ThemeColor.SecondaryColor;
            lblISV.ForeColor = ThemeColor.SecondaryColor;
            lblDescuento.ForeColor = ThemeColor.SecondaryColor;
            lblTotalResultado.ForeColor = ThemeColor.PrimaryColor;

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            pnlVenta.Visible = true;
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            
            pnlVenta.Visible = false;
        }
    }
}
