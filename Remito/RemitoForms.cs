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
    public partial class RemitoForms : Form
    {
        public RemitoForms()
        {
            InitializeComponent();
        }

        private void RemitoForms_Load(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.VerificarTransportistaForms transportista = new();
            this.Hide();
            transportista.Show();
        }
    }
}
