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

namespace GrupoA.Prototipo.DespachoSinTransportista
{
    public partial class DespachoSinTransportistaForms : Form
    {
        DespachoSinTransportistaModel modelo;
        public DespachoSinTransportistaForms()
        {
            InitializeComponent();
            // Initialize components and add event handlers
            textBoxDNI.EnabledChanged += new EventHandler(ControlStateChanged);
            ListBoxOrdenesPrep.ItemCheck += new ItemCheckEventHandler(ListBoxOrdenesPrep_ItemCheck);
        }

        private void DespachoSinTransportistaForms_Load(object sender, EventArgs e)
        {
            modelo = new();
            CargarListbox();
            // Call the method initially to set the button state correctly on form load
            UpdateButtonState();
        }

        private void CargarListbox()
        {
            // Retrieve the list of orders
            var lista = modelo.MercaderiaARetirar();

            // Clear the ListBox before adding new items
            ListBoxOrdenesPrep.Items.Clear();

            // Check if the list is null or empty and show a message if it is
            if (lista == null || !lista.Any())
            {
                MessageBox.Show("No hay ordenes de preparación para despachar. Por favor, intente nuevamente en unos minutos.");
                return;
            }

            // Iterate through the list and add each order to the ListBox
            foreach (var orden in lista)
            {
                ListBoxOrdenesPrep.Items.Add($"Orden {orden.NroOrdenPrep}");
            }
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
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
                ListBoxOrdenesPrep.Enabled = true;

                buttonDNI.Text = "Editar DNI"; // Change button text
            }
            // If textBoxDNI is disabled, unlock it and update button text to "Confirmar DNI"
            else
            {
                textBoxDNI.Enabled = true;
                ListBoxOrdenesPrep.Enabled = false;
                buttonDNI.Text = "Aplicar DNI"; // Change button text
            }

            // Update the button state
            UpdateButtonState();
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

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            // Remove any non-digit characters from the text (This will make impossible to paste non numeric characters)
            textBoxDNI.Text = new string(textBoxDNI.Text.Where(char.IsDigit).ToArray());
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            // Code not being used since commit 7973765. Conditions will never be met due to button being disabled beforehand
            /*
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
            */
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

                    // Get the order number from the item string (assuming it's in the format "Orden {NroOrdenPrep}")
                    string itemText = ListBoxOrdenesPrep.Items[i].ToString();
                    int orderNumber = int.Parse(itemText.Replace("Orden ", ""));

                    // Update the Estado of the corresponding order
                    UpdateOrderEstado(orderNumber, "despachada");
                }
            }

            int dnitransportista;
            int.TryParse(textBoxDNI.Text, out dnitransportista);

            modelo.GenerarRemito(dnitransportista, ObtenerOrdenesSeleccionadas());

            // Display the checked values
            MessageBox.Show("Se generará el remito, para las siguientes ordenes," +
                "con el DNI del transportista n°" + textBoxDNI.Text 
                + "\n\n" + sb.ToString());

            // Refresh the ListBox to show updated states
            CargarListbox();
        }

        private List<int> ObtenerOrdenesSeleccionadas()
        {
            // Crear una lista para almacenar los números de orden seleccionados
            List<int> ordenesSeleccionadas = new List<int>();

            // Iterar sobre los elementos seleccionados del ListBox
            foreach (var item in ListBoxOrdenesPrep.SelectedItems)
            {
                // Extraer el número de orden de la cadena del ListBox
                string itemString = item.ToString();
                string numeroOrdenString = itemString.Split(' ')[1];

                // Convertir el número de orden a int y añadirlo a la lista
                if (int.TryParse(numeroOrdenString, out int numeroOrden))
                {
                    ordenesSeleccionadas.Add(numeroOrden);
                }
            }

            return ordenesSeleccionadas;
        }

        // Method to update the Estado of an order
        private void UpdateOrderEstado(int nroOrdenPrep, string newEstado)
        {
            var order = modelo.ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrdenPrep);
            if (order != null)
            {
                order.Estado = newEstado;
            }
        }

        private void ControlStateChanged(object sender, EventArgs e)
        {
            // Update the button state whenever relevant control states change
            UpdateButtonState();
        }

        private void ListBoxOrdenesPrep_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Handle the item check state change before it's applied
            this.BeginInvoke((MethodInvoker)delegate
            {
                UpdateButtonState();
            });
        }

        private void UpdateButtonState()
        {
            // Check if the dni TextBox is not enabled
            bool isDniDisabled = !textBoxDNI.Enabled;
            // Check if at least one item is selected in the ListBoxOrdenesPrep
            bool isItemSelected = ListBoxOrdenesPrep.CheckedItems.Count > 0;

            // Enable or disable the button based on the conditions
            botonConfirmar.Enabled = isDniDisabled && isItemSelected;
        }

        private void Salida_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            CargarListbox();
        }
    }
}
