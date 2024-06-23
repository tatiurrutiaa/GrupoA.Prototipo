using System;
using System.Windows.Forms;
using GrupoA.Prototipo.Forms.OrdenEntrega.Model;

namespace GrupoA.Prototipo
{
    public partial class OrdenEntregaForms : Form
    {
        private OrdenEntregaModel _model;

        public OrdenEntregaForms()
        {
            InitializeComponent();
            _model = new();
            _model.AgregarOrdenesAlListBox(ListBoxOrdenesPrep);
            ListBoxOrdenesPrep.ItemCheck += new ItemCheckEventHandler(ListBoxOrdenesPrep_ItemCheck);
        }

        private void BotonGenerarOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            _model.GenerarOrdenDeEntrega(ListBoxOrdenesPrep);
            UpdateButtonState();
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms();
            this.Hide();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
        }

        private void ListBoxOrdenesPrep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el evento si es necesario
        }

        // Código para habilitar el botón de generar orden de entrega unicamente cuando hay algún item seleccionado
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
            // Check if at least one item is selected in the ListBoxOrdenesPrep
            bool isItemSelected = ListBoxOrdenesPrep.CheckedItems.Count > 0;

            // Enable or disable the button based on the conditions
            botonGenerarOrdenDeEntrega.Enabled = isItemSelected;
        }
        //

        private void OrdenesEntrega_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
