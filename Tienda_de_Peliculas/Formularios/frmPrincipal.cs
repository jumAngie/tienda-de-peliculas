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

        private Dictionary<int, Form> formulariosPorPantalla;

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
            // Limpia cualquier botón previamente agregado al panel
           // panelMenu.Controls.Clear();

            foreach (var pantalla in pantallasPermitidas)
            {
                Button boton = new Button
                {
                    Text = pantalla.pant_NombrePantalla,
                    Size = new Size(220, 92),
                    Location = new Point(0, pantalla.PosicionY),
                    TextAlign = ContentAlignment.MiddleLeft,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(11, 2, 0, 0),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Gainsboro,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular)
                };

                // Cargar la imagen desde los recursos
                try
                {
                    boton.Image = (Image)Properties.Resources.ResourceManager.GetObject(pantalla.pant_RutaImagen);
                }
                catch
                {
                    // Manejo de errores si la imagen no se encuentra
                    boton.Image = Properties.Resources.alquiler; // Puedes usar un ícono predeterminado
                }

                // Asociar el evento Click al botón y pasarle el PantallaId
                boton.Click += (sender, e) =>
                {
                    // Verificar que el diccionario esté inicializado y que contenga el ID de la pantalla
                    if (formulariosPorPantalla != null && formulariosPorPantalla.ContainsKey(pantalla.pant_ID))
                    {
                        OpenChildForm(formulariosPorPantalla[pantalla.pant_ID], sender);
                    }
                    else
                    {
                        MessageBox.Show("Formulario no disponible para esta pantalla.");
                    }
                };

                // Agrega el botón al panel
                panelMenu.Controls.Add(boton);
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
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender) { 
                
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton= (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                if(previousBtn.GetType() == typeof(Button))
                    {
                        previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                        previousBtn.ForeColor = Color.Gainsboro;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }

        private Form formularioActual = null;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            DisableButton();
            lbltTitle.Text = "INICIO";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            mostrarDatosDashboard();
        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
