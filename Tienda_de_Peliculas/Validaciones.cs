using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Peliculas
{
    public class Validaciones
    {
        public static bool soloNumeros(KeyPressEventArgs valorTecla)
        {
            if(Char.IsNumber(valorTecla.KeyChar)) 
            {
                valorTecla.Handled = false;
                return true;
            }
            else if(Char.IsControl(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else
            {
                valorTecla.Handled = true;
                return false;
            }
        }

        public static bool soloNumerosPrecio(KeyPressEventArgs valorTecla)
        {
            char valor = valorTecla.KeyChar;
            if (Char.IsNumber(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else if (Char.IsControl(valorTecla.KeyChar))
            {
                valorTecla.Handled = false;
                return true;
            }
            else if(valor == '.')
            {
                valorTecla.Handled = false;
                return true;
            }
            else
            {
                valorTecla.Handled = true;
                return false;
            }
        }

        public static bool formatoMoneda(string txtPrecio)
        {
            return txtPrecio != null && Regex.IsMatch(txtPrecio, "^$[0-9]{1,3}([\\.][0-9]{2})");
        }
    }
}
