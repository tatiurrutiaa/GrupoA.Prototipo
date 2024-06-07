using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public partial class EmpaquetarMercaderiaForms : Form
    {
        private EmpaquetarMercaderiaModel modelo;
        private int numeroOrdenActual;

        public EmpaquetarMercaderiaForms()
        {
            InitializeComponent();
            modelo = new EmpaquetarMercaderiaModel();
            empaquetarButton.Enabled = false;
            CargarOrdenesComboBox();
        }

        private void CargarOrdenesComboBox()
        {
            buscarCombobox.Items.Clear();
            var ordenesSeleccionadas = modelo.ObtenerOrdenesSeleccionadas();
            foreach (var orden in ordenesSeleccionadas)
            {
                buscarCombobox.Items.Add(orden.NroOrdenPrep);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarCombobox.SelectedItem != null)
            {
                int nroOrdenSeleccionada = (int)buscarCombobox.SelectedItem;
                MostrarMercaderias(nroOrdenSeleccionada);
                empaquetarButton.Enabled = true;
            }
        }

        private void MostrarMercaderias(int nroOrden)
        {
            var orden = modelo.ObtenerOrdenesSeleccionadas().FirstOrDefault(o => o.NroOrdenPrep == nroOrden);
            if (orden != null)
            {
                empaquetarmercaderiaListview.Items.Clear();
                foreach (var mercaderia in orden.Mercaderias)
                {
                    var item = new ListViewItem(new[]
                    {
                        mercaderia.IdProducto,
                        mercaderia.Mercaderia,
                        mercaderia.CantidadProducto.ToString()
                    });
                    empaquetarmercaderiaListview.Items.Add(item);
                }
                nroordenLabel.Text = "Nro de orden: " + orden.NroOrdenPrep.ToString();
                numeroOrdenActual = orden.NroOrdenPrep;
            }
        }

        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            if (numeroOrdenActual > 0)
            {
                modelo.CambiarEstadoOrden(numeroOrdenActual, "Preparadas");
                MessageBox.Show("Orden empaquetada exitosamente.", "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empaquetarButton.Enabled = false;
                CargarOrdenesComboBox();
                empaquetarmercaderiaListview.Items.Clear();
                nroordenLabel.Text = "Nro de orden: ";
                numeroOrdenActual = 0;
            }
        }
    }





}