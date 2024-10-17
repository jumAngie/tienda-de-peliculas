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
            tHora.Enabled = true;
        }

        PaisesDAL pa = new PaisesDAL();
        DepartamentosDAL dep = new DepartamentosDAL();
        private int id_filaSeleccionada;

        #region CRUD
        public void Listado_Ciudades()
        {
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acciones";  
            btnEliminar.Name = "btnEliminar";     
            btnEliminar.Text = "Eliminar";        
            btnEliminar.UseColumnTextForButtonValue = true;
            dgCiudades.DataSource = CiudadesDAL.ListarCiudades();
            dgCiudades.Columns.Add(btnEliminar);
        }

        public void Insertar_Ciudades()
        {
            Ciudades nuevaCiudad = new Ciudades
            {
                ciud_Descripcion = txtNombreCiudad.Text,
                dept_Id = Convert.ToInt32(cboDepartamentos.SelectedValue),
                usua_UsuarioCreacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                ciud_FechaCreacion = DateTime.Now
            };

            string resultado = CiudadesDAL.InsertarCiudades(nuevaCiudad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Editar_CargarDatos(int ciud_Id)
        {
            Ciudades ciudades = CiudadesDAL.Editar_CargarDatos(ciud_Id);
            if (ciudades != null)
            {
                txtNombreCiudad.Text = ciudades.ciud_Descripcion;
                cboPaises.SelectedValue = ciudades.pais_Id;
                CargarDepartamentosPorPaisCMB(ciudades.pais_Id);
                cboDepartamentos.SelectedValue = ciudades.dept_Id;

            }
        }

        public void Editar_Ciudades(int ciud_Id)
        {
            Ciudades ciudad = new Ciudades
            {
                ciud_Id = ciud_Id,
                ciud_Descripcion = txtNombreCiudad.Text,
                dept_Id = Convert.ToInt32(cboDepartamentos.SelectedValue),
                usua_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                ciud_FechaModificacion = DateTime.Now
            };

            string resultado = CiudadesDAL.EditarCiudades(ciudad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Eliminar_Ciudades(int ciud_Id)
        {
            Ciudades ciudad = new Ciudades
            {
                ciud_Id = ciud_Id,
                usua_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                ciud_FechaModificacion = DateTime.Now
            };

            string resultado = CiudadesDAL.EliminarCiudades(ciudad);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Validaciones y Limpieza de Campos
        public void LimpiarCampos()
        {
            cboDepartamentos.SelectedIndex = -1;
            cboPaises.SelectedIndex = 0;
            txtNombreCiudad.Clear();
        }

        public bool ValidarVacio()
        {
            bool esValido = false;
            // Que aparezca el panel que indica error
            if (cboPaises.SelectedIndex == 0) { pnlPais.Visible = true; }
            if (cboDepartamentos.SelectedIndex == -1 || cboDepartamentos.SelectedIndex == 0) { pnlDepartamento.Visible = true; }
            if (txtNombreCiudad.Text == "") { pnlNombre.Visible = true; }

            // Que desaparezca el panel que indica error
            if (cboPaises.SelectedIndex != 0) { pnlPais.Visible = false; }
            if (cboDepartamentos.SelectedIndex != -1 && cboDepartamentos.SelectedIndex != 0) { pnlDepartamento.Visible = false; }
            if (txtNombreCiudad.Text != "") { pnlNombre.Visible = false; }

            if (cboPaises.SelectedIndex != 0 && cboDepartamentos.SelectedIndex != 0 && txtNombreCiudad.Text != "")
            {
                esValido = true;
            }
            else
            {
                esValido = false;
            }

            return esValido;
        }

        public void boton_mostrarEditar()
        {
            btnEditar.Visible = true;
            btnGuardar.Visible = false;
        }

        public void boton_mostrarGuardar()
        {
            btnEditar.Visible = false;
            btnGuardar.Visible = true;

        }

        public void panel_OcultarValidaciones()
        {
            pnlDepartamento.Visible=false;
            pnlPais.Visible=false;
            pnlNombre.Visible=false;
        }
        #endregion

        #region Mensajes
        public void MensajeAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }
        public void MensajeAdvertencia_Hide()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            Listado_Ciudades();
            CargarPaisesCMB();
            cboDepartamentos.Enabled = false;
            cboDepartamentos.Text = "Debe seleccionar un Pais.";
            boton_mostrarGuardar();
            lblFecha.Text = DateTime.Now.ToLongDateString();
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidarVacio();
                if (esValido) 
                {
                    Insertar_Ciudades();
                    Listado_Ciudades();
                    LimpiarCampos();
                    boton_mostrarGuardar();
                }
                else
                { 
                    MensajeAdvertencia();
                    await Task.Delay(4000);
                    MensajeAdvertencia_Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void dgCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCiudades.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {

                int ciud_Id = Convert.ToInt32(dgCiudades.Rows[e.RowIndex].Cells["CiudadID"].Value);
                var result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Eliminar_Ciudades(ciud_Id);
                    Listado_Ciudades();
                }
            }
            else if (e.RowIndex >= 0)
            {
                boton_mostrarEditar();
                DataGridViewRow fila = dgCiudades.Rows[e.RowIndex];

                int ciud_Id = Convert.ToInt32(fila.Cells["CiudadID"].Value);
                id_filaSeleccionada = ciud_Id;

                LimpiarCampos();
                panel_OcultarValidaciones();
                Editar_CargarDatos(ciud_Id);
            }

            
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidarVacio();
                if (esValido)
                {
                    Editar_Ciudades(id_filaSeleccionada); 
                    Listado_Ciudades();
                    LimpiarCampos();
                    boton_mostrarGuardar();
                }
                else
                {
                    MensajeAdvertencia();
                    await Task.Delay(4000);
                    MensajeAdvertencia_Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:tt");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            boton_mostrarGuardar();
            panel_OcultarValidaciones();
        }
    }
}
