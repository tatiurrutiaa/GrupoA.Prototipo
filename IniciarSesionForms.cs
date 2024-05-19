using GrupoA.Prototipo.Empaquetado;
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
        private readonly IniciarSesionModel modelo = new();
        public IniciarSesionForms()
        {
            InitializeComponent();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.UsuarioIngreso = this.textBoxUsuario.Text;
            usuario.Contraseña = this.textBoxContraseña.Text;

            string error = modelo.Validar(usuario);
            if (error == null)
            {
                MessageBox.Show("¡Bienvenido!");
                GrupoA.Prototipo.MenuForms menu = new();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show(error);
            }

        }
    }

}
