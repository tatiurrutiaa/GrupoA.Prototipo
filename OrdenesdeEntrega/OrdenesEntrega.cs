using System;
using System.Linq;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    public partial class OrdenesEntrega : Form
    {
        public OrdenesEntrega()
        {
            InitializeComponent();

            // Llenar la lista con los números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                listBoxOrdenesPrep.Items.Add("Orden " + i);
            }

            // Permitir selección múltiple
            listBoxOrdenesPrep.SelectionMode = SelectionMode.MultiExtended;
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms();
            this.Hide();
            menu.Show();
        }

        private void BotonGenerarOrdenDeEntrega_Click(object sender, EventArgs e)
        {
            if (listBoxOrdenesPrep.SelectedItems.Count > 0)
            {
                var selectedOrders = listBoxOrdenesPrep.SelectedItems.Cast<string>();
                string selectedOrdersString = string.Join(", ", selectedOrders);
                MessageBox.Show($"Orden de entrega generada para: {selectedOrdersString}");
            }
            else
            {
                MessageBox.Show("Seleccione al menos una orden de preparación primero.");
            }
        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms();
            this.Hide();
            menu.Show();
        }
    }
}
