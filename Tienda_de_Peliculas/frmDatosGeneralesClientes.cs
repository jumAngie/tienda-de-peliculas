using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Peliculas
{
    public partial class frmDatosGeneralesClientes : Form
    {
        public frmDatosGeneralesClientes()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.PrimaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblDir.BackColor = ThemeColor.PrimaryColor;

        }

        private void frmDatosGeneralesCliente_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
