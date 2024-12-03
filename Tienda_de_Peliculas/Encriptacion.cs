using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Tienda_de_Peliculas
{
    public class Encriptacion
    {
        public static byte[] Encrip(string contrasenia)
        {
            if (string.IsNullOrEmpty(contrasenia))
            {
                throw new ArgumentException("La contraseña no puede ser nula o vacía");
            }

            using (SHA512 sha512 = SHA512.Create())
            {
               
                byte[] bytesContrasenia = Encoding.Unicode.GetBytes(contrasenia);
                
                return sha512.ComputeHash(bytesContrasenia);
            }
        }
    }
}
