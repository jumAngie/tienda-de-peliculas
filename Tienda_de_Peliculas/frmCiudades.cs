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
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        PaisesDAL pa = new PaisesDAL();
        DepartamentosDAL dep = new DepartamentosDAL();

        #region CRUD
        public void Listado_Ciudades()
        {
            dgCiudades.DataSource = CiudadesDAL.ListarCiudades();
        }
        #endregion

        #region Llenado de ComboBoxs
        public void CargarPaisesCMB()
        {
            cboPaises.DataSource = pa.CargarPaises();
            cboPaises.DisplayMember = "pais_Descripcion";
            cboPaises.ValueMember = "pais_Id";
        }

        public void CargarDepartamentosPorPaisCMB(int pais_Id)
        {
            cboDepartamentos.DataSource = dep.CargarDepartamentosPorPais(pais_Id);
            cboDepartamentos.DisplayMember = "dept_Descripcion";
            cboDepartamentos.ValueMember = "dept_Id";
        }
        #endregion


        private void frmCiudades_Load(object sender, EventArgs e)
        {
            Listado_Ciudades();
            CargarPaisesCMB();
            cboDepartamentos.Enabled = false;
            cboDepartamentos.Text = "Debe seleccionar un Pais.";
        }

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaises.SelectedValue != null && cboPaises.SelectedValue is int)
            {
                cboDepartamentos.Enabled = true;
                int pais_Id = (int)cboPaises.SelectedValue;
                CargarDepartamentosPorPaisCMB(pais_Id);
            }
        }
    }
}
