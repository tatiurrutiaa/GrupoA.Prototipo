using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoA.Prototipo.Salida
{
    public partial class Salida : Form
    {
        SalidaModel modelo;
        private string transportistaDNI;
        public Salida()
        {
            InitializeComponent();
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            modelo = new();
            CargarListbox();
        }

        private void CargarListbox()
        {
            var lista = modelo.MercaderiaARetirar();
            if (lista == null)
            {
                MessageBox.Show("No hay ordenes de preparación para despachar." +
                    "Por favor, intente nuevamente en unos minutos.");
                return;
            }
            foreach (var orden in lista)
            {
                ListBoxOrdenesPrep.Items.Add($"Orden {orden.NroOrdenPrep}");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void buttonDNI_Click(object sender, EventArgs e)
        {
            transportistaDNI = textBoxDNI.Text;
            string displayText = "Transportista con DNI " + transportistaDNI;
            labelAvisoDNI.Text = displayText;
        }
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
