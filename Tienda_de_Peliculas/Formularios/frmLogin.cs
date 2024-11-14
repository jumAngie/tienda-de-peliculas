using System;
using System.Windows.Forms;
using System.Drawing;
using Tienda_de_Peliculas.DAL;
using Tienda_de_Peliculas.Clases;
using Tienda_de_Peliculas.View_Models;
using System.Collections.Generic;

namespace Tienda_de_Peliculas
{
    public partial class frmLogin : Form
    {
        LoginDAL login = new LoginDAL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ErrorProvider txtusuarioError = new ErrorProvider();
        ErrorProvider txtContraseniaError = new ErrorProvider();
        
        public bool ValidarVacio()
        {
            bool esValido = false;  
                // Mostrar advertencias
                if(txtUsuario.Text == "")
                {
                    pnlValidarUsuario.Visible = true;
                    txtusuarioError.SetError(txtUsuario, "Usuario inválido.");
                }
                if (txtContrasenia.Text == "")
                {
                    pnlValidarContra.Visible = true;
                    txtContraseniaError.SetError(txtContrasenia, "Contraseña inválida.");
                }

                // Quitar advertencias
                if (txtUsuario.Text != "")
                {
                    pnlValidarUsuario.Visible = false;
                    txtusuarioError.Clear();
                }
                if (txtContrasenia.Text != "")
                {
                    pnlValidarContra.Visible = false;
                    txtContraseniaError.Clear();
                }

                if(txtUsuario.Text != "" && txtContrasenia.Text != "") esValido = true;

                return esValido;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
        }

        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.White;
            pnlUsuario.BackColor = Color.White;
        }

        private void pbxUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            txtUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
        }

        private void pbxContrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = false;
            txtContrasenia.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.White;
            pnlUsuario.BackColor = Color.White;
        }

        private void pbxContrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           bool puedeAutenticar = ValidarVacio();
            if (puedeAutenticar)
            { 
                string Usuario = txtUsuario.Text;
                string Contrasenia = txtContrasenia.Text;
                DatosUsuarioViewModel usuarioAutenticado = login.AutenticarUsuario(Usuario, Contrasenia);
                if(usuarioAutenticado != null)
                {
                    lblError.Visible = false;
                    List<PantallasViewModel> pantallasPermitidas = login.ObtenerPantallasPermitidas(usuarioAutenticado.role_Id);
                    frmPrincipal formularioPrincipal = new frmPrincipal
                    {
                        UsuarioActual = usuarioAutenticado,
                        pantallasPermitidas = pantallasPermitidas
                    };
                    formularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
