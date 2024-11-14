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
using Tienda_de_Peliculas.View_Models;

namespace Tienda_de_Peliculas
{
    public partial class frmInventario : Form
    {
        
        GeneroDAL ge = new GeneroDAL();
        IdiomasDAL          idi = new IdiomasDAL();
        ClasificacionesDAL  cl = new ClasificacionesDAL();
        FormatosDAL         frm = new FormatosDAL();
        EstadosDAL          est = new EstadosDAL();
        public DatosUsuarioViewModel UsuarioActual { get; }
        private int id_filaSeleccionada;

        public frmInventario()
        {
            InitializeComponent();
        }

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public bool ValidacionVacio()
        {
            bool esValido = false;
            // Mostrar error
            if(txtTitulo.Text == "")            pnlTitulo.Visible = true;
            if (txtAnioLanzamiento.Text == "")  pnlAnio.Visible = true;
            if(cboGeneros.SelectedIndex == 0 || cboGeneros.SelectedIndex == -1)   pnlGenero.Visible = true;
            if(cboIdiomas.SelectedIndex == 0 || cboIdiomas.SelectedIndex == -1) pnlIdioma.Visible = true;
            if(cboClasificacion.SelectedIndex == 0 || cboClasificacion.SelectedIndex == -1) pnlClasificacion.Visible = true;
            if (txtDuracion.Text == "") pnlDuracion.Visible = true;
            if (txtDescripcion.Text == "") pnlDesc.Visible = true;
            if (cboFormatos.SelectedIndex == 0 || cboFormatos.SelectedIndex == -1) pnlFormato.Visible = true;
            if (cboEstados.SelectedIndex == 0 || cboEstados.SelectedIndex == -1) pnlEstado.Visible = true;
            if (txtExistencias.Text == "") pnlExistencias.Visible = true;
            if (txtPrecio.Text == "") pnlPrecio.Visible = true;

            // Esconder error
            if (txtTitulo.Text != "")           pnlTitulo.Visible = false;
            if (txtAnioLanzamiento.Text != "")  pnlAnio.Visible = false;
            if (cboGeneros.SelectedIndex != 0 && cboGeneros.SelectedIndex != -1) pnlGenero.Visible=false;
            if (cboIdiomas.SelectedIndex != 0 && cboIdiomas.SelectedIndex != -1) pnlIdioma.Visible = false;
            if (cboClasificacion.SelectedIndex != 0 && cboClasificacion.SelectedIndex != -1) pnlClasificacion.Visible = false;
            if (txtDuracion.Text != "") pnlDuracion.Visible = false;
            if (txtDescripcion.Text != "") pnlDesc.Visible = false;
            if (cboFormatos.SelectedIndex != 0 && cboFormatos.SelectedIndex != -1) pnlFormato.Visible = false;
            if (cboEstados.SelectedIndex != 0 && cboEstados.SelectedIndex != -1) pnlEstado.Visible = false;
            if (txtExistencias.Text != "") pnlExistencias.Visible = false;
            if (txtPrecio.Text != "") pnlPrecio.Visible = false;

            if(txtTitulo.Text != "" && txtAnioLanzamiento.Text != "" && cboGeneros.SelectedIndex != 0 && cboGeneros.SelectedIndex != -1
                && cboIdiomas.SelectedIndex != 0 && cboIdiomas.SelectedIndex != -1 && cboClasificacion.SelectedIndex != 0 && cboClasificacion.SelectedIndex != -1
                && txtDuracion.Text != "" && txtDescripcion.Text != "" && cboFormatos.SelectedIndex != 0 && cboFormatos.SelectedIndex != -1
                && cboEstados.SelectedIndex != 0 && cboEstados.SelectedIndex != -1 && txtExistencias.Text != ""
                && txtPrecio.Text != "")
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
            pnlTitulo.Visible = false;
            pnlAnio.Visible = false;
            
            pnlGenero.Visible = false;
            pnlClasificacion.Visible = false;
            pnlIdioma.Visible = false;
            pnlDuracion.Visible = false;
            
            pnlDesc.Visible = false;
            
            pnlEstado.Visible = false;
            pnlPrecio.Visible = false;
            pnlFormato.Visible = false;
            pnlExistencias.Visible = false;
        }

        public void ValidacionNumerica()
        {
            // necesito capturar los error providers que estén activos para evitar q pueda presionar el boton guardar
        }

        public void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAnioLanzamiento.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtExistencias.Clear();
            txtPrecio.Clear();
            cboGeneros.SelectedIndex = 0;
            cboEstados.SelectedIndex = 0;
            cboFormatos.SelectedIndex = 0;
            cboIdiomas.SelectedIndex = 0;
            cboClasificacion.SelectedIndex = 0;
            errorAnioLanzamiento.Clear();
            errorDuracion.Clear();
            errorExistencias.Clear();
            errorPrecio.Clear();
        }
        #endregion

        #region MENSAJES
        public void MensajeAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }
        public void MensajeAdvertencia_Hide()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion

        #region DISEÑO
        private void LoadTheme()
        {
            btnGuardar.BackColor = ThemeColor.PrimaryColor;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnCancelar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            lblPrecioHNL.ForeColor = Color.White;
            lblPrecioHNL.BackColor = ThemeColor.PrimaryColor;
            btnEditar.ForeColor = Color.White;
            btnEditar.BackColor = ThemeColor.SecondaryColor;
            btnEditar.FlatAppearance.BorderColor = ThemeColor.PrimaryColor;
        }
        #endregion

        #region CRUD
        public void Listado_Inventario()
        {
            dgInventario.DataSource = InventarioDAL.ListarInventario();
        }

        public void Insertar_Inventario()
        {
            Inventario inve = new Inventario
            {
                inve_Titulo = txtTitulo.Text,
                inve_Anio = txtAnioLanzamiento.Text,
                gene_Id = Convert.ToInt32(cboGeneros.SelectedValue),
                inve_Duracion = Convert.ToInt32(txtDuracion.Text),
                form_Id = Convert.ToInt32(cboFormatos.SelectedValue),
                esta_Id = Convert.ToInt32(cboEstados.SelectedValue),
                inve_Descripcion = txtDescripcion.Text,
                idio_Id = Convert.ToInt32(cboIdiomas.SelectedValue),
                inve_Cantidad = Convert.ToInt32(txtExistencias.Text),
                inve_Precio = Convert.ToDecimal(txtPrecio.Text),
                clas_Id = Convert.ToInt32(cboClasificacion.SelectedValue),
                usua_UsuarioCreacion = UsuarioActual.usua_Id,
                inve_FechaCreacion = DateTime.Now,
            };

            string resultados = InventarioDAL.InsertarInventario(inve);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Editar_CargarDatos(int inve_Id)
        {
            Inventario inve = InventarioDAL.Editar_CargarDatos(inve_Id);
            if (inve != null)
            {
                txtTitulo.Text = inve.inve_Titulo;
                txtAnioLanzamiento.Text = inve.inve_Anio;
                cboGeneros.SelectedValue = inve.gene_Id;
                cboIdiomas.SelectedValue = inve.idio_Id;
                cboClasificacion.SelectedValue = inve.clas_Id;
                txtDescripcion.Text = inve.inve_Descripcion;
                txtDuracion.Text = Convert.ToString(inve.inve_Duracion);
                cboEstados.SelectedValue = inve.esta_Id;
                cboFormatos.SelectedValue = inve.form_Id;
                txtExistencias.Text = Convert.ToString(inve.inve_Cantidad);
                txtPrecio.Text = Convert.ToString(inve.inve_Precio);
            }
        }

        public void Editar_Inventario(int inve_Id)
        {
            Inventario inve = new Inventario
            {
                inve_Id = inve_Id,
                inve_Titulo = txtTitulo.Text,
                inve_Anio = txtAnioLanzamiento.Text,
                inve_Cantidad = Convert.ToInt32(txtExistencias.Text),
                inve_Descripcion = txtDescripcion.Text,
                inve_Duracion = Convert.ToInt32(txtDuracion.Text),
                inve_Precio = Convert.ToDecimal(txtPrecio.Text),

                gene_Id = Convert.ToInt32(cboGeneros.SelectedValue),
                idio_Id = Convert.ToInt32(cboIdiomas.SelectedValue),
                clas_Id = Convert.ToInt32(cboClasificacion.SelectedValue),
                form_Id = Convert.ToInt32(cboFormatos.SelectedValue),
                esta_Id = Convert.ToInt32(cboEstados.SelectedValue),

                usua_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                inve_FechaModificacion = DateTime.Now
            };

            string resultado = InventarioDAL.EditarInventario(inve);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region COMBOBOXS
        public void CargarGeneros()
        {
            cboGeneros.DataSource = ge.CargarGeneros();
            cboGeneros.ValueMember = "gene_Id";
            cboGeneros.DisplayMember = "gene_Descripcion";
        }

        public void CargarIdiomas()
        {
            cboIdiomas.DataSource = idi.CargaIdiomas();
            cboIdiomas.ValueMember = "idio_Id";
            cboIdiomas.DisplayMember = "idio_Descripcion";
        }

        public void CargarClasificaciones()
        {
            cboClasificacion.DataSource = cl.CargarClasificaciones();
            cboClasificacion.ValueMember = "clas_Id";
            cboClasificacion.DisplayMember = "clas_Descripcion";
        }

        public void CargarFormatos()
        {
            cboFormatos.DataSource = frm.CargarFormatos();
            cboFormatos.ValueMember = "form_Id";
            cboFormatos.DisplayMember = "form_Descripcion";
        }

        public void CargarEstados()
        {
            cboEstados.DataSource = est.CargarEstados();
            cboEstados.ValueMember = "esta_Id";
            cboEstados.DisplayMember = "esta_Descripcion";
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void frmInventario_Load(object sender, EventArgs e)
        {
            LoadTheme();
            txtTitulo.Focus();
            boton_mostrarGuardar();
            MessageBox.Show(UsuarioActual.usua_Id + " " + UsuarioActual.dato_NombreCompleto);
            // Añadiendo el boton al comenzar cada registro pq si queda al final no se ve y le es más dificil
            // al usuario desplazarse hasta el final para eliminar un registro  (?

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acciones";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 70;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            btnEliminar.DefaultCellStyle.ForeColor = Color.White;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.DefaultCellStyle.Font = new Font("Nobile", 7, FontStyle.Regular);
            dgInventario.Columns.Add(btnEliminar);

            Listado_Inventario();
            CargarGeneros();
            CargarIdiomas();
            CargarClasificaciones();
            CargarFormatos();
            CargarEstados();

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionVacio();
            if (esValido)
            {
                Insertar_Inventario();
                Listado_Inventario();
                LimpiarCampos();
                boton_mostrarGuardar();
            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            boton_mostrarGuardar();
            panel_OcultarValidaciones();
        }

        ErrorProvider errorAnioLanzamiento = new ErrorProvider();
        private void txtAnioLanzamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorAnioLanzamiento.SetError(txtAnioLanzamiento, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorAnioLanzamiento.Clear();
            }
        }

        ErrorProvider errorExistencias = new ErrorProvider();
        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorExistencias.SetError(txtExistencias, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorExistencias.Clear();
            }
        }

        ErrorProvider errorPrecio = new ErrorProvider();
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumerosPrecio(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorPrecio.SetError(txtPrecio, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorPrecio.Clear();
            }
        }

        ErrorProvider errorDuracion = new ErrorProvider();
        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorDuracion.SetError(txtDuracion, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorDuracion.Clear();
            }
        }

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgInventario.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                int inve_Id = Convert.ToInt32(dgInventario.Rows[e.RowIndex].Cells["inve_Id"].Value);
                var result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Eliminar_Ciudades(ciud_Id);
                    Listado_Inventario();
                    LimpiarCampos();
                }
            }
            else if (e.RowIndex >= 0)
            {
                boton_mostrarEditar();
                DataGridViewRow fila = dgInventario.Rows[e.RowIndex];

                int inve_Id = Convert.ToInt32(fila.Cells["inve_Id"].Value);
                id_filaSeleccionada = inve_Id;

                LimpiarCampos();
                panel_OcultarValidaciones();
                Editar_CargarDatos(inve_Id);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidacionVacio();
                if (esValido)
                {
                    Editar_Inventario(id_filaSeleccionada);
                    Listado_Inventario();
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
        #endregion
    }
}
