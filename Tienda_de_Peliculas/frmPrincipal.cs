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
        public frmPrincipal()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        public int diasDeLaSemana(string diaSemana)
        {
            int dia = 0;
            switch (diaSemana)
            {
                case "Monday":          dia = 1; 
                    break;
                case "Tuesday":         dia = 2;
                    break;
                case "Wednesday":       dia = 3;
                    break;
                case "Thursday":        dia = 4;
                    break;
                case "Friday":          dia = 5;
                    break;
                case "Saturday":        dia = 6;
                    break;
                case "Sunday":          dia = 7;
                    break;
            }

            return dia;

        }

        #region
        public void mostrarDatosDashboard()
        { 
            DateTime fechaActual = DateTime.Now;
            var diaSemana = fechaActual.DayOfWeek;
            string dia = Convert.ToString(diaSemana);
            int numeroDia = diasDeLaSemana(dia);

            lblClientesRegistrados.Text = ClientesDAL.CantidadDeClientesRegistrdos();
            
        }
        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            mostrarDatosDashboard();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:tt");
        }
    }
}
