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

namespace Tienda_de_Peliculas
{
    public partial class frmPrincipal : Form
    {
        //
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        //
        public frmPrincipal()
        {
            InitializeComponent();
            tHora.Enabled = true;
            random = new Random();
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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
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
            ActivateButton(sender);

        }

        private void btnRegistroEmpleados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnVentaAlquiler_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmInventario(), sender);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
