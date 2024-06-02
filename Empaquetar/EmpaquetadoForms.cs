using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrupoA.Prototipo.Empaquetar.EmpaquetadoModel;

namespace GrupoA.Prototipo.Empaquetar
{
    public partial class EmpaquetadoForms : Form
    {
        private List<OrdenEmpaquetar> ordenes;
        private int ordenActual = 0;

        public EmpaquetadoForms()
        {
            InitializeComponent();
            ordenes = DatosTemporales.ObtenerOrdenes();
            MostrarOrden();
            ActualizarBotones();
        }

        private void MostrarOrden()
        {
            if (ordenActual < ordenes.Count)
            {
                var orden = ordenes[ordenActual];
                NroOrdenLabel.Text = $"Orden #{orden.Numero}";
                EmpaquetarListView.Items.Clear();
                foreach (var producto in orden.Productos)
                {
                    var item = new ListViewItem(producto.IdProducto);
                    item.SubItems.Add(producto.NombreProducto);
                    item.SubItems.Add(producto.CantidadProducto.ToString());
                    EmpaquetarListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No hay más órdenes para empaquetar.");
                EmpaquetarButton.Enabled = false;
            }
        }

        private void EmpaquetarButton_Click(object sender, EventArgs e)
        {
            if (ordenActual < ordenes.Count)
            {
                var orden = ordenes[ordenActual];
                string productos = string.Join("\n", orden.Productos.Select(p => p.ToString()));
                MessageBox.Show($"Orden #{orden.Numero} empaquetada con productos:\n{productos}");
                ordenActual++;
                MostrarOrden();
                ActualizarBotones();
            }
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            GrupoA.Prototipo.MenuForms menu = new();
            this.Hide();
            menu.Show();
        }

        private void anteriorButton_Click(object sender, EventArgs e)
        {
            if (ordenActual > 0)
            {
                ordenActual--;
                MostrarOrden();
                ActualizarBotones();
            }
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            if (ordenActual < ordenes.Count - 1)
            {
                ordenActual++;
                MostrarOrden();
                ActualizarBotones();
            }
        }
        private void ActualizarBotones()
        {
            anteriorButton.Enabled = ordenActual > 0;
            SiguienteButton.Enabled = ordenActual < ordenes.Count - 1;
        }

        private void EmpaquetadoForms_Load(object sender, EventArgs e)
        {

        }
    }
}
