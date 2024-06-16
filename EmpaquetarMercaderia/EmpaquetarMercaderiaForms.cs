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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public partial class EmpaquetarMercaderiaForms : Form
    {
        private EmpaquetarMercaderiaModel modelo;
        private int numeroOrdenActual = 34; // Inicializar con el número de la primera orden

        public EmpaquetarMercaderiaForms()
        {
            InitializeComponent();
            modelo = new EmpaquetarMercaderiaModel();

            // Mostrar la primera orden al abrir el formulario
            MostrarMercaderias(numeroOrdenActual);

            // Verificar si hay una orden seleccionada al inicio y habilitar el botón "Empaquetar" en consecuencia
            VerificarOrdenSeleccionada();
        }

        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            if (numeroOrdenActual > 0)
            {
                // Empaquetar la orden actual
                DateTime fechaHoraActual = DateTime.Now;
                modelo.CambiarEstadoOrden(numeroOrdenActual, "preparada");
                string cuitCliente = modelo.ObtenerCuitCliente(numeroOrdenActual);
                string mensaje = $"El número de orden {numeroOrdenActual} fue empaquetado.\nFecha y hora: {fechaHoraActual}\nCUIT del cliente: {cuitCliente}\nEstado: preparada";
                MessageBox.Show(mensaje, "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Encontrar la siguiente orden disponible y mostrarla
                var ordenesDisponibles = modelo.ObtenerOrdenesSeleccionadas();
                var siguienteOrden = ordenesDisponibles.FirstOrDefault(o => o.NroOrdenPrep > numeroOrdenActual);
                if (siguienteOrden != null)
                {
                    numeroOrdenActual = siguienteOrden.NroOrdenPrep;
                    MostrarMercaderias(numeroOrdenActual);
                }
                else
                {
                    // No hay más órdenes disponibles, deshabilitar el botón de empaquetado
                    empaquetarButton.Enabled = false;
                }
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
                    mercaderia.CodProducto.ToString(),
                    mercaderia.DescProducto,
                    mercaderia.CantidadProducto.ToString()
                });
                    empaquetarmercaderiaListview.Items.Add(item);
                }
                nroordenLabel.Text = "Nro de orden: " + orden.NroOrdenPrep.ToString();
                numeroOrdenActual = orden.NroOrdenPrep;

                // Verificar si hay una orden seleccionada y habilitar/deshabilitar el botón "Empaquetar" en consecuencia
                VerificarOrdenSeleccionada();
            }
        }

        private void VerificarOrdenSeleccionada()
        {
            var ordenesDisponibles = modelo.ObtenerOrdenesSeleccionadas();
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