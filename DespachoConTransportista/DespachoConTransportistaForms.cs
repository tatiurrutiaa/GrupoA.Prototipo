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

        // Carga el formulario
        private void DespachoConTransportistaForms_Load(object sender, EventArgs e)
        {
            modelo = new();
            CargarListbox();
            UpdateButtonState();
        }

        // Actualiza la lista de órdenes de preparación
        private void ActualizarListbox(List<RetiroStock.OrdenPreparacion> ordenes)
        {
            ListBoxOrdenesPrep.Items.Clear();
            foreach (var orden in ordenes)
            {
                ListBoxOrdenesPrep.Items.Add($"Orden {orden.NroOrdenPrep}");
            }
        }

        // Carga la lista de órdenes de preparación
        private void CargarListbox()
        {
            List<RetiroStock.OrdenPreparacion> lista;

            if (!textBoxDNI.Enabled && int.TryParse(textBoxDNI.Text.Trim(), out int dni))
            {
                lista = modelo.ObtenerOrdenesPorDNI(dni);
            }
            else
            {
                lista = modelo.MercaderiaARetirar();
            }

            if (lista == null || !lista.Any())
            {
                MessageBox.Show("No hay órdenes de preparación para despachar. Por favor, intente nuevamente en unos minutos.");
                return;
            }

            ActualizarListbox(lista);
        }


        // Vuelve al menú principal
        private void buttonAtras_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
        }

        // Verificaciones del DNI ingresado
        private void buttonDNI_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Enabled)
            {
                string dniText = textBoxDNI.Text.Trim();

                if (string.IsNullOrWhiteSpace(dniText))
                {
                    MessageBox.Show("El DNI no puede estar vacío.");
                    return;
                }

                if (dniText.Length < 7 || dniText.Length > 9)
                {
                    MessageBox.Show("El DNI debe contener entre 7 y 9 caracteres.");
                    return;
                }

                if (!int.TryParse(dniText, out int dni))
                {
                    MessageBox.Show("El DNI debe contener solo números.");
                    return;
                }

                textBoxDNI.Enabled = false;
                ListBoxOrdenesPrep.Enabled = true;

                buttonDNI.Text = "Editar DNI";

                var ordenesFiltradas = modelo.ObtenerOrdenesPorDNI(dni);
                ActualizarListbox(ordenesFiltradas);
            }
            else
            {
                textBoxDNI.Enabled = true;
                ListBoxOrdenesPrep.Enabled = false;
                buttonDNI.Text = "Aplicar DNI";

                CargarListbox(); // Esto se puede ajustar para que limpie la lista
            }

            UpdateButtonState();
        }


        // Comportamientos del DNI ingresado en el TextBox por Seba
        /*
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
        */

        // imposibilidad de pegar texto no numerico en el textbox
        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            textBoxDNI.Text = new string(textBoxDNI.Text.Where(char.IsDigit).ToArray());
        }

        // Crear remito
        private void ButtonCrearRemito_Click(object sender, EventArgs e)
        {
            /*GrupoA.Prototipo.RemitoForms remito = new();
            this.Hide();
            remito.Show();*/

            int dnitransportista;
            int.TryParse(textBoxDNI.Text, out dnitransportista);

            modelo.GenerarRemito(dnitransportista, ObtenerOrdenesSeleccionadas());
            modelo.ActualizarStock(ObtenerOrdenesSeleccionadas());

            DisplayCheckedValues();
        }

        // Método para mostrar las ordenes seleccionadas
        // Actualiza el estado de las ordenes a "despachada"
        private void DisplayCheckedValues()
        {
            StringBuilder sb = new StringBuilder();
            List<int> ordenesProcesadas = new List<int>();

            for (int i = 0; i < ListBoxOrdenesPrep.Items.Count; i++)
            {
                if (ListBoxOrdenesPrep.GetItemChecked(i))
                {
                    sb.AppendLine(ListBoxOrdenesPrep.Items[i].ToString());

                    string? itemText = ListBoxOrdenesPrep.Items[i].ToString();
                    if (itemText != null)
                    {
                        int orderNumber = int.Parse(itemText.Replace("Orden ", ""));
                        UpdateOrderEstado(orderNumber, "despachada");
                        ordenesProcesadas.Add(orderNumber);
                    }
                }
            }

            MessageBox.Show("Se generará el remito, para las siguientes ordenes, con el DNI del transportista n°" + textBoxDNI.Text + "\n\n" + sb.ToString());

            // Eliminar las órdenes procesadas de la ListBox
            foreach (int orderNumber in ordenesProcesadas)
            {
                ListBoxOrdenesPrep.Items.Remove($"Orden {orderNumber}");
            }

            // Actualizar el estado de los botones
            UpdateButtonState();
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

        // Métodos para actualizar el estado de las ordenes
        private void ControlStateChanged(object? sender, EventArgs e)
        {
            UpdateButtonState();
        }

        private void ListBoxOrdenesPrep_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                UpdateButtonState();
            });
        }

        private void UpdateButtonState()
        {
            bool isDniDisabled = !textBoxDNI.Enabled;
            bool isItemSelected = ListBoxOrdenesPrep.CheckedItems.Count > 0;

            buttonCrearRemito.Enabled = isDniDisabled && isItemSelected;
        }

        // Cierra el proceso al cerrar la aplicación
        private void DespachoConTransportistaForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Actualiza la lista de órdenes de preparación
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Enabled)
            {
                // Si el TextBox de DNI está habilitado, cargar todas las órdenes
                CargarListbox();
            }
            else
            {
                // Si el TextBox de DNI está deshabilitado, intentar filtrar por el DNI actualmente ingresado
                if (int.TryParse(textBoxDNI.Text.Trim(), out int dni))
                {
                    var ordenesFiltradas = modelo.ObtenerOrdenesPorDNI(dni);
                    ActualizarListbox(ordenesFiltradas);

                    // Mostrar mensaje si no quedan órdenes
                    if (ordenesFiltradas == null || !ordenesFiltradas.Any())
                    {
                        MessageBox.Show("No hay órdenes de preparación para despachar. Por favor, intente nuevamente en unos minutos.");
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido.");
                }
            }
        }

    }
}
