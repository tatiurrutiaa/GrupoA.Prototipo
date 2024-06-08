using GrupoA.Prototipo.RetiroStock;
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

namespace GrupoA.Prototipo.DespachoConTransportista
{
    public partial class DespachoConTransportistaForms : Form
    {
        private DespachoConTransportistaModel modelo;
        public DespachoConTransportistaForms()
        {
            InitializeComponent();
            modelo = new DespachoConTransportistaModel();
            textBoxDNI.EnabledChanged += new EventHandler(ControlStateChanged);
            ListBoxOrdenesPrep.ItemCheck += new ItemCheckEventHandler(ListBoxOrdenesPrep_ItemCheck);
        }
        private void DespachoConTransportistaForms_Load(object sender, EventArgs e)
        {
            modelo = new();
            CargarListbox();
            UpdateButtonState();
        }
        private void ActualizarListbox(List<OrdenesPreparacion> ordenes)
        {
            ListBoxOrdenesPrep.Items.Clear();
            foreach (var orden in ordenes)
            {
                ListBoxOrdenesPrep.Items.Add($"Orden {orden.NroOrdenPrep}");
            }
        }

        private void CargarListbox()
        {
            var lista = modelo.MercaderiaARetirar();
            if (lista == null || !lista.Any())
            {
                MessageBox.Show("No hay órdenes de preparación para despachar. Por favor, intente nuevamente en unos minutos.");
                return;
            }

            ActualizarListbox(lista);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void buttonDNI_Click(object sender, EventArgs e)
        {
            // Si textBoxDNI está habilitado, lo bloquea y actualiza el texto del botón a "Editar DNI"
            if (textBoxDNI.Enabled)
            {
                string dniText = textBoxDNI.Text.Trim();

                // Validar que el DNI no esté vacío
                if (string.IsNullOrWhiteSpace(dniText))
                {
                    MessageBox.Show("El DNI no puede estar vacío.");
                    return;
                }

                // Validar que el DNI tenga entre 7 y 9 caracteres
                if (dniText.Length < 7 || dniText.Length > 9)
                {
                    MessageBox.Show("El DNI debe contener entre 7 y 9 caracteres.");
                    return;
                }

                // Validar que el DNI contenga solo números
                if (!int.TryParse(dniText, out int dni))
                {
                    MessageBox.Show("El DNI debe contener solo números.");
                    return;
                }

                textBoxDNI.Enabled = false;
                ListBoxOrdenesPrep.Enabled = true;

                buttonDNI.Text = "Editar DNI"; // Cambiar el texto del botón

                // Filtrar las órdenes de preparación por el DNI ingresado y actualizar la ListBox
                var ordenesFiltradas = modelo.ObtenerOrdenesPorDNI(dni);
                ActualizarListbox(ordenesFiltradas);
            }
            else
            {
                textBoxDNI.Enabled = true;
                ListBoxOrdenesPrep.Enabled = false;
                buttonDNI.Text = "Aplicar DNI"; // Cambiar el texto del botón


                // Restaurar la lista completa de órdenes de preparación si se está editando el DNI
                CargarListbox();
            }

            // Actualizar el estado del botón
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

        private void ButtonCrearRemito_Click(object sender, EventArgs e)
        {
            /*GrupoA.Prototipo.RemitoForms remito = new();
            this.Hide();
            remito.Show();*/
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

        private void ControlStateChanged(object? sender, EventArgs e)
        {
            // Update the button state whenever relevant control states change
            UpdateButtonState();
        }

        private void ListBoxOrdenesPrep_ItemCheck(object? sender, ItemCheckEventArgs e)
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
            buttonCrearRemito.Enabled = isDniDisabled && isItemSelected;
        }

        private void groupBoxOrdenEntrega_Enter(object sender, EventArgs e)
        {

        }

        private void ListBoxOrdenesPrep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Cierra el proceso al cerrar la aplicación
        private void DespachoConTransportistaForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Enabled)
            {
                CargarListbox();
            }
            else
            {
                // Filter and update the list by the DNI in textBoxDNI
                if (int.TryParse(textBoxDNI.Text.Trim(), out int dni))
                {
                    var ordenesFiltradas = modelo.ObtenerOrdenesPorDNI(dni);
                    ActualizarListbox(ordenesFiltradas);
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido.");
                }
            }
        }
    }
}
