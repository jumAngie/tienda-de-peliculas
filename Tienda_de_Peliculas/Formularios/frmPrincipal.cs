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
            int posicionY = 72; // Margen de espacio entre el header y los botones

            foreach (var pantalla in pantallasPermitidas)
            {
                if (pantalla.pant_RutaImagen == "Icono_Registrar_Clientes")
                {
                    btnRegistroClientes.Visible = true;
                    btnRegistroClientes.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnRegistroClientes.Height + btnRegistroClientes.Margin.Top + btnRegistroClientes.Margin.Bottom;
                }
                else if (pantalla.pant_RutaImagen == "Icono_Registrar_Empleados")
                {
                    btnRegistroEmpleados.Visible = true;
                    btnRegistroEmpleados.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnRegistroEmpleados.Height + btnRegistroEmpleados.Margin.Top + btnRegistroEmpleados.Margin.Bottom;
                }
                else if (pantalla.pant_RutaImagen == "Icono_Registrar_Venta_Alquiler")
                {
                    btnVentaAlquiler.Visible = true;
                    btnVentaAlquiler.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnVentaAlquiler.Height + btnVentaAlquiler.Margin.Top + btnVentaAlquiler.Margin.Bottom;
                }
                else if (pantalla.pant_RutaImagen == "Icono_Inventario")
                {
                    btnInventario.Visible = true;
                    btnInventario.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnInventario.Height + btnInventario.Margin.Top + btnInventario.Margin.Bottom;
                }
                else if (pantalla.pant_RutaImagen == "Icono_Reportes")
                {
                    btnReportes.Visible = true;
                    btnReportes.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnReportes.Height + btnReportes.Margin.Top + btnReportes.Margin.Bottom;
                }
            }
        }

        //
        public frmPrincipal()
        {
            InitializeComponent();
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
