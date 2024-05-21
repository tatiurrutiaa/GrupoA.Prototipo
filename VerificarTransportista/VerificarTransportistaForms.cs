using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class VerificarTransportistaForms : Form
    {
        public VerificarTransportistaForms()
        {
            InitializeComponent();
        }

        private void groupBoxOrdenesAEntregar_Enter(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void botonCrearRemito_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.RemitoForms remito = new();
            this.Hide();
            remito.Show();
        }
    }
}
