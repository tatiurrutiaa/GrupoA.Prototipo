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
    public partial class OrdenDeEntregaForms : Form
    {
        public OrdenDeEntregaForms()
        {
            InitializeComponent();
        }

        private void groupBoxOrdenPreparación_Enter(object sender, EventArgs e)
        {

        }
        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void textBoxCantidad1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
