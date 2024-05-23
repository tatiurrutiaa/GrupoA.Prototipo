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
        private List<EmpaquetadoModel.Orden> ordenes;
        private int indiceOrdenActual = 0;

        public EmpaquetadoForms()
        {
            InitializeComponent();
            ordenes = EmpaquetadoModel.DatosTemporales.ObtenerOrdenes(); // Obtener las órdenes desde la fuente de datos temporal
            MostrarOrdenActual();
        }

        private void MostrarOrdenActual()
        {
            if (indiceOrdenActual < ordenes.Count)
            {
                EmpaquetadoModel.Orden ordenActual = ordenes[indiceOrdenActual];
                NroOrdenLabel.Text = $"Nro de Orden: {ordenActual.Numero}";

                // Limpiar y llenar el ListBox con los productos de la orden actual
                EmpaquetarlistBox.Items.Clear();
                foreach (var producto in ordenActual.Productos)
                {
                    EmpaquetarlistBox.Items.Add(producto);
                }
            }
            else
            {
                MessageBox.Show("No hay más órdenes para empaquetar.");
                NroOrdenLabel.Text = "No hay más órdenes";
                EmpaquetarlistBox.Items.Clear();
                EmpaquetarButton.Enabled = false; // Desactivar el botón de empaquetar
            }
        }

        private void EmpaquetarButton_Click(object sender, EventArgs e)
        {
            if (indiceOrdenActual < ordenes.Count)
            {
                EmpaquetadoModel.Orden ordenActual = ordenes[indiceOrdenActual];
                MessageBox.Show($"La orden {ordenActual.Numero} ha sido empaquetada.");
                indiceOrdenActual++;
                MostrarOrdenActual();
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
