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
        private Button currenButton;
        private Random random;
        private int tempIndex;

        //
        public frmPrincipal()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        //
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object sender)
        {

        }

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

    }
}
