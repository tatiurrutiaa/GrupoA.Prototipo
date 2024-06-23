using GrupoA.Prototipo.Forms.Login.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GrupoA.Prototipo
{
    public partial class IniciarSesionForms : Form
    {
        IniciarSesionModel modelo;

        public IniciarSesionForms()
        {
            InitializeComponent();
        }

        private void IniciarSesionForms_Load(object sender, EventArgs e)
        {
            modelo = new();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
            }
        }

        private void Ingresar()
        {
            var usuario = new Usuario();
            usuario.UsuarioIngreso = this.textBoxUsuario.Text;
            usuario.Contraseña = this.textBoxContraseña.Text;

            string error = modelo.ValidarUsuario(usuario.UsuarioIngreso, usuario.Contraseña);

            if (error == null)
            {
                MessageBox.Show("¡Bienvenido!");
                GrupoA.Prototipo.MenuForms menu = new();
                this.Hide();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Show();
            }
            else
            {
                MessageBox.Show(error);
            }

        }

        // Cierra el proceso al cerrar la aplicación
        private void IniciarSesionForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
