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

        public void ListarClientes()
        {
            dgDatosCliente.DataSource = ClientesDAL.ListarClientes();
        }

        public void InsertarClientes()
        {
            DatosGenerales Dg = new DatosGenerales
            {
                dato_NombreCompleto = txbName.Text,
                dato_DNI = mtxbDNI.Text,
                dato_Telefono = txbTel.Text,
                dato_FechaNacimiento = DateTime.Now,
                sexo_Id = 1,
                dato_email= txbemail.Text,
                ciud_Id = cbxCiudad.SelectedIndex,
                dato_Direccion = txbDirE.Text,
            };

            string resultados = ClientesDAL.InsertarClientes(Dg);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmDatosGeneralesCliente_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ListarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarClientes();
        }
    }
}
