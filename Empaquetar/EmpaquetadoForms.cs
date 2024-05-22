using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.Empaquetar
{
    public partial class EmpaquetadoForms : Form
    {
        public EmpaquetadoForms()
        {
            InitializeComponent();

            // Crear órdenes de ejemplo
            var orden1 = new Orden("Orden 1", new List<string> { "Item A", "Item B", "Item C" });
            var orden2 = new Orden("Orden 2", new List<string> { "Item D", "Item E" });
            var orden3 = new Orden("Orden 3", new List<string> { "Item F", "Item G", "Item H" });

            // Agregar órdenes al ListBox
            EmpaquetarlistBox.Items.Add(orden1);
            EmpaquetarlistBox.Items.Add(orden2);
            EmpaquetarlistBox.Items.Add(orden3);

            // Configurar el evento Click del botón
            EmpaquetarButton.Click += EmpaquetarButton_Click;
        }
        private void EmpaquetarButton_Click(object sender, EventArgs e)
        {
            if (EmpaquetarlistBox.SelectedItem != null)
            {
                Orden selectedOrder = (Orden)EmpaquetarlistBox.SelectedItem;
                string items = string.Join(", ", selectedOrder.Items);
                MessageBox.Show($"La orden '{selectedOrder.Nombre}' con los items [{items}] se va a empaquetar.");
                EmpaquetarlistBox.Items.Remove(selectedOrder);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una orden de la lista.");
            }
        }

        private void EmpaquetadoForms_Load(object sender, EventArgs e)
        {

        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
            
        }
    }

}
