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

        private void frmFactura_Load(object sender, EventArgs e)
        {
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
    }
}
