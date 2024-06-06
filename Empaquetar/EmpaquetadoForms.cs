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
            if (ordenActual < ordenes.Count && ordenActual >= 0)
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
                EmpaquetarButton.Enabled = true; // Asegurarse de que el botón está habilitado cuando hay una orden para mostrar
            }
            else
            {
                NroOrdenLabel.Text = "No hay más órdenes para empaquetar.";
                EmpaquetarListView.Items.Clear();
                EmpaquetarButton.Enabled = false; // Deshabilitar el botón solo cuando no hay más órdenes
            }
        }

        private void EmpaquetarButton_Click(object sender, EventArgs e)
        {
            if (ordenActual < ordenes.Count)
            {
                var orden = ordenes[ordenActual];
                string productos = string.Join("\n", orden.Productos.Select(p => p.ToString()));
                MessageBox.Show($"Orden #{orden.Numero} empaquetada con productos:\n{productos}");
                ordenes.RemoveAt(ordenActual);
                if (ordenActual >= ordenes.Count)
                {
                    ordenActual = ordenes.Count - 1;
                }
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
            anteriorButton.Enabled = ordenActual > 0 && ordenes.Count > 0;
            SiguienteButton.Enabled = ordenActual < ordenes.Count - 1;
            EmpaquetarButton.Enabled = ordenes.Count > 0;
        }

        private void EmpaquetadoForms_Load(object sender, EventArgs e)
        {

        }
                
        // Cierra el proceso al cerrar la aplicación
        private void EmpaquetadoForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
