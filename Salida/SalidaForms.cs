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
            // If textBoxDNI is enabled, lock it and update button text to "Editar DNI"
            if (textBoxDNI.Enabled)
            {

                if (textBoxDNI.Text.Length < 7 || textBoxDNI.Text.Length > 9)
                {
                    MessageBox.Show("El DNI debe contener entre 7 y 9 caracteres.");
                    return;
                }

                textBoxDNI.Enabled = false;
                buttonDNI.Text = "Editar DNI"; // Change button text
            }
            // If textBoxDNI is disabled, unlock it and update button text to "Confirmar DNI"
            else
            {
                textBoxDNI.Enabled = true;
                buttonDNI.Text = "Aplicar DNI"; // Change button text
            }
        }
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            if (textBoxDNI.Text.Length > 8)
            {
                // If the length exceeds 8, truncate the text to 8 characters
                textBoxDNI.Text = textBoxDNI.Text.Substring(0, 8);

                // Move the cursor to the end of the text
                textBoxDNI.SelectionStart = textBoxDNI.Text.Length;
            }
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            // Check if textBoxDNI is not locked but there is text
            if (textBoxDNI.Enabled && textBoxDNI.Text.Length > 0)
            {
                MessageBox.Show("Por favor valide el DNI.");
                return;
            }

            // Check if textBoxDNI is not locked and there is no text
            if (textBoxDNI.Enabled && textBoxDNI.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese y valide el DNI.");
                return;
            }
            // Check if there are any items selected in the ListBoxOrdenesPrep
            if (ListBoxOrdenesPrep.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se seleccionó ninguna orden.");
                return;
            }

            // Display the checked values
            DisplayCheckedValues();
        }
        private void DisplayCheckedValues()
        {
            StringBuilder sb = new StringBuilder();

            // Iterate through each item in the ListBoxOrdenesPrep
            for (int i = 0; i < ListBoxOrdenesPrep.Items.Count; i++)
            {
                // Check if the item is checked
                if (ListBoxOrdenesPrep.GetItemChecked(i))
                {
                    // Append the checked item to the StringBuilder
                    sb.AppendLine(ListBoxOrdenesPrep.Items[i].ToString());
                }
            }

            // Display the checked values
            MessageBox.Show("Se generará el remito, para las siguientes ordenes, con el DNI del transportista n°" + textBoxDNI.Text + "\n\n" + sb.ToString());
        }
    }
}
