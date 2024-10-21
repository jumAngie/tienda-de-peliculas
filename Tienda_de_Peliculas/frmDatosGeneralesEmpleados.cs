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
    public partial class frmDatosGeneralesEmpleados : Form
    {
        public frmDatosGeneralesEmpleados()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.PrimaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblDir.BackColor = ThemeColor.SecondaryColor;
            lblDir.ForeColor = Color.White;

        }

        private void frmDatosGeneralesEmpleados_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
