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

namespace Tienda_de_Peliculas
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        public void RefrescarListado()
        {
            dgCiudades.DataSource = CiudadesDAL.ListarCiudades();
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            RefrescarListado();
        }
    }
}
