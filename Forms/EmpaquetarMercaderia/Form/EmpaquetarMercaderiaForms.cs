using GrupoA.Prototipo.Forms.EmpaquetarMercaderia.Model;
using GrupoA.Prototipo.Forms.RetiroStock;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public partial class EmpaquetarMercaderiaForms : Form
    {
        private EmpaquetarMercaderiaModel modelo;

        public EmpaquetarMercaderiaForms()
        {
            InitializeComponent();
        }

        private void EmpaquetarMercaderiaForms_Load(object sender, EventArgs e)
        {
            modelo = new EmpaquetarMercaderiaModel();

            int numeroOrdenActual = modelo.OrdenEnPantalla();

            // Mostrar la primera orden al abrir el formulario
            MostrarMercaderias(numeroOrdenActual);

            // Verificar si hay una orden seleccionada al inicio y habilitar el botón "Empaquetar" en consecuencia
            VerificarOrdenSeleccionada();
        }

        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            int numeroOrdenActual = modelo.OrdenEnPantalla();
            if (numeroOrdenActual > 0)
            {
                // Empaquetar la orden actual
                modelo.CambiarEstadoOrden(numeroOrdenActual);
                //string cuitCliente = modelo.ObtenerCuitCliente(numeroOrdenActual);
                string mensaje = $"El número de orden {numeroOrdenActual} fue empaquetado correctamente."; //\nCUIT del cliente: {cuitCliente}";
                MessageBox.Show(mensaje, "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Encontrar la siguiente orden disponible y mostrarla
                var ordenesDisponibles = EmpaquetarMercaderiaModel.ObtenerOrdenesSeleccionadas();
                var siguienteOrden = ordenesDisponibles.FirstOrDefault(o => o.NroOrdenPrep > numeroOrdenActual);
                if (siguienteOrden != null)
                {
                    numeroOrdenActual = siguienteOrden.NroOrdenPrep;
                    MostrarMercaderias(numeroOrdenActual);
                }
                else
                {
                    // No hay más órdenes disponibles, deshabilitar el botón de empaquetado
                    empaquetarmercaderiaListview.Items.Clear();
                    nroordenLabel.Text = "Nro de orden: ";
                    empaquetarButton.Enabled = false;
                    MessageBox.Show("No hay ordenes pendientes para empaquetar. \n" +
                        "Por favor, intente nuevamente en unos minutos.");
                    return;
                }
            }
        }

        private void MostrarMercaderias(int nroOrden)
        {
            var orden = EmpaquetarMercaderiaModel.ObtenerOrdenesSeleccionadas().FirstOrDefault(o => o.NroOrdenPrep == nroOrden);
            if (orden != null)
            {
                empaquetarmercaderiaListview.Items.Clear();
                foreach (var mercaderia in orden.mercaderiaDetalle)
                {
                    var item = new ListViewItem(new[]
                    {
                    mercaderia.CodProducto.ToString(),
                    modelo.BuscarDescProducto(mercaderia.CodProducto),
                    mercaderia.CantidadProducto.ToString()
                    });
                    empaquetarmercaderiaListview.Items.Add(item);
                }
                nroordenLabel.Text = "Nro de orden: " + orden.NroOrdenPrep.ToString();
                int numeroOrdenActual = modelo.OrdenEnPantalla();
                numeroOrdenActual = orden.NroOrdenPrep;

                // Verificar si hay una orden seleccionada y habilitar/deshabilitar el botón "Empaquetar" en consecuencia
                VerificarOrdenSeleccionada();
            }
            else
            {
                empaquetarmercaderiaListview.Items.Clear();
                empaquetarButton.Enabled = false;
                MessageBox.Show("No hay ordenes pendientes para empaquetar. \n" +
                    "Por favor, intente nuevamente en unos minutos.");
            }
        }

        private void VerificarOrdenSeleccionada()
        {
            var ordenesDisponibles = EmpaquetarMercaderiaModel.ObtenerOrdenesSeleccionadas();
            int numeroOrdenActual = modelo.OrdenEnPantalla();
            var ordenSeleccionada = ordenesDisponibles.FirstOrDefault(o => o.NroOrdenPrep == numeroOrdenActual);
            empaquetarButton.Enabled = ordenSeleccionada != null;
        }

        private void EmpaquetarMercaderiaForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menuForm = new MenuForms();
            this.Hide();
            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Location = this.Location;
            menuForm.Show();
        }

        private void EmpaquetarMercaderiaForms_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }

}