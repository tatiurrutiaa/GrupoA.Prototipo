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
                // Obtener la fecha y hora actual
                DateTime fechaHoraActual = DateTime.Now;

                // Cambiar el estado de la orden actual a "preparada"
                modelo.CambiarEstadoOrden(numeroOrdenActual, "preparada");

                // Obtener el CUIT del cliente para la orden actual
                string cuitCliente = modelo.ObtenerCuitCliente(numeroOrdenActual);

                // Mensaje a mostrar en el MessageBox
                string mensaje = $"El número de orden {numeroOrdenActual} fue empaquetado.\nFecha y hora: {fechaHoraActual}\nCUIT del cliente: {cuitCliente}\nEstado: preparada";

                // Mostrar el MessageBox con el mensaje y los detalles
                MessageBox.Show(mensaje, "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Deshabilitar el botón de empaquetado
                empaquetarButton.Enabled = false;

                // Actualizar la lista de órdenes en el ComboBox
                CargarOrdenesComboBox();

                // Limpiar el ListView de mercaderías
                empaquetarmercaderiaListview.Items.Clear();

                // Restaurar el texto del Label de número de orden
                nroordenLabel.Text = "Nro de orden: ";

                // Reiniciar el número de orden actual a 0
                numeroOrdenActual = 0;
            }
        }

        // Cierra el proceso al cerrar la aplicación
        private void EmpaquetarMercaderiaForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menuForm = new MenuForms();
            // Mostrar el formulario MenuForms
            menuForm.StartPosition = FormStartPosition.Manual;
            menuForm.Location = this.Location;
            menuForm.Show();
            // Cerrar el formulario actual EmpaquetarMercaderiaForms
            this.Close();
        }
    }





}