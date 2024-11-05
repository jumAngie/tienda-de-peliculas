using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Peliculas.DAL;
using Tienda_de_Peliculas.Formularios;
using Tienda_de_Peliculas.Properties;
using Tienda_de_Peliculas.View_Models;

namespace Tienda_de_Peliculas
{
    public partial class frmPrincipal : Form
    {
        //
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;
        public DatosUsuarioViewModel UsuarioActual { get; set; }
        public List<PantallasViewModel> pantallasPermitidas   { get; set; }
        Dictionary<int, Form> formulariosPorPantalla = new Dictionary<int, Form>();


        private void InicializarFormularios()
        {
            formulariosPorPantalla = new Dictionary<int, Form>
            {
                { 1, new frmDatosGeneralesClientes() },
                { 2, new frmDatosGeneralesEmpleados() },
                { 3, new frmFactura() },
                { 4, new frmInventario() },
                { 5, new frmReportes() }
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DibujarMenu();
            if (UsuarioActual != null)
            {
                string mensajeBienvenida = "";
                lblNombre.Text = UsuarioActual.usua_Usuario;
                lblRol.Text = UsuarioActual.role_Descripcion;
                if (UsuarioActual.sexo_Id == 1) mensajeBienvenida = "Bienvenida";
                else mensajeBienvenida = "Bienvenido";

                lblMensajeBienvenida.Text = $"¡ {mensajeBienvenida}, {UsuarioActual.dato_NombreCompleto} !";
            }
        }

        private void DibujarMenu()
        {
            int posicionY = 72;

            foreach (var pantalla in pantallasPermitidas)
            {
                
                Button boton = new Button
                {
                    Text = pantalla.pant_NombrePantalla,
                    Size = new Size(220, 92),
                    Location = new Point(0, posicionY),
                    TextAlign = ContentAlignment.MiddleLeft,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(11, 2, 0, 0),
                    Margin = new Padding(3, 5, 3, 3),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Gainsboro,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    UseVisualStyleBackColor = true,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                    FlatAppearance = {BorderSize = 0}
                };

                if (pantalla.pant_RutaImagen == "Icono_Registrar_Clientes")
                    boton.Image = Properties.Resources.Icono_Registrar_Clientes;
                else if (pantalla.pant_RutaImagen == "Icono_Registrar_Empleados")
                    boton.Image = Properties.Resources.Icono_Registrar_Empleados;
                else if (pantalla.pant_RutaImagen == "Icono_Registrar_Venta_Alquiler")
                    boton.Image = Properties.Resources.Icono_Registrar_Venta_Alquiler;
                else if (pantalla.pant_RutaImagen == "Icono_Inventario")
                    boton.Image = Properties.Resources.Icono_Inventario;
                else if (pantalla.pant_RutaImagen == "Icono_Reportes")
                    boton.Image = Properties.Resources.Icono_Reportes;

               
                boton.Click += (sender, e) =>
                {
                   
                    if (formulariosPorPantalla != null && formulariosPorPantalla.ContainsKey(pantalla.pant_ID))
                    {
                        OpenChildForm(formulariosPorPantalla[pantalla.pant_ID], sender);
                    }
                    else
                    {
                        MessageBox.Show("no jala D:");
                    }
                };

                // Agrega el botón al panel
                panelMenu.Controls.Add(boton);
                posicionY += boton.Height + boton.Margin.Top + boton.Margin.Bottom;
            }
        }

        //
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarFormularios();
            tHora.Enabled = true;
            random = new Random();
            btnCloseChildForm.Visible = false;
        }

        //
        #region Diseño
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index) 
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); // Deshabilita el botón previamente activo
                    Color color = SelectThemeColor(); // Selecciona un color aleatorio
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Hide();
            }

            ActivateButton(btnSender); 
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltTitle.Text = childForm.Text;
        }
        #endregion

        #region Dashboard 
        public void mostrarDatosDashboard()
        { 
            DateTime fechaActual = DateTime.Now;
            var diaSemana = (int)DateTime.Now.DayOfWeek;
            DateTime fechaLunes = fechaActual.AddDays(-((diaSemana == 0 ? 7 : diaSemana) - 1));
            DateTime fechaDomingo = fechaLunes.AddDays(6);


            lblVentasSemanales.Text =      FacturaDAL.CantidadVentasSemanaActual(fechaLunes, fechaDomingo);
            lblClientesRegistrados.Text = ClientesDAL.CantidadDeClientesRegistrdos();
            lblAlquileresSemanales.Text = FacturaDAL.CantidadAlquileresSemanaActual(fechaLunes, fechaDomingo);
            
            
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            mostrarDatosDashboard();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void btnRegistroClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatosGeneralesClientes(), sender);

        }

        private void btnRegistroEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatosGeneralesEmpleados(), sender);
        }

        private void btnVentaAlquiler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmFactura(), sender);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmInventario(), sender);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmReportes(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activateForm != null)
                activateForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton(); // Resetea todos los botones a su estilo predeterminado
            lbltTitle.Text = "INICIO"; // Título predeterminado
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76); // Color original de la barra de título
            panelLogo.BackColor = Color.FromArgb(39, 39, 58); // Color original del panel del logo
            currentButton = null;
            btnCloseChildForm.Visible = false; // Oculta el botón de cerrar formulario
            mostrarDatosDashboard(); // Restaura el dashboard o el contenido inicial
        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
