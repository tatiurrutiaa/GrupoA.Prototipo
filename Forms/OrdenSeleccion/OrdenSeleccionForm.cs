using GrupoA.Prototipo.Forms.OrdenSeleccion;
using GrupoA.Prototipo.Forms.OrdenEntrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.OrdenSeleccion
{
    public partial class OrdenSeleccionForm : Form
    {
        private OrdenSeleccionModel modelo;

        public OrdenSeleccionForm()
        {
            InitializeComponent();
            modelo = new();
            modelo.AgregarOrdenesAlListBox(ListBoxOrdenesPrep);
            ListBoxOrdenesPrep.ItemCheck += new ItemCheckEventHandler(ListBoxOrdenesPrep_ItemCheck);
        }

        private void botonGenerarOrdenSeleccion_Click(object sender, EventArgs e)
        {
            modelo.GenerarOrdenDeSeleccion(ListBoxOrdenesPrep);
            ListBoxOrdenesPrep.ItemCheck += new ItemCheckEventHandler(ListBoxOrdenesPrep_ItemCheck);
            UpdateButtonState();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms();
            this.Hide();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
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
            botonGenerarOrdenSeleccion.Enabled = isItemSelected;
        }

        private void OrdenesEntrega_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OrdenSeleccionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
