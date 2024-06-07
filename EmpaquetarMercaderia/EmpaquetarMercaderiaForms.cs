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
        private EmpaquetarMercaderiaModel modelo; // Debes tener una instancia de tu modelo

        public EmpaquetarMercaderiaForms()
        {
            InitializeComponent();
            modelo = new EmpaquetarMercaderiaModel(); // Inicializar el modelo
        }

        private void EmpaquetarMercaderiaForms_Load(object sender, EventArgs e)
        {
            CargarComboBoxOrdenes();
        }

        private void CargarComboBoxOrdenes()
        {
            buscarCombobox.Items.Clear(); // Limpiar ComboBox
            foreach (var orden in modelo.ObtenerOrdenesConMercaderias().Where(o => o.Estado == "Seleccionadas"))
            {
                buscarCombobox.Items.Add(orden.NroOrdenPrep); // Agregar NroOrdenPrep al ComboBox
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            if (buscarCombobox.SelectedItem != null)
            {
                int nroOrdenSeleccionado = Convert.ToInt32(buscarCombobox.SelectedItem);

                // Filtrar las mercaderías asociadas al NroOrdenPrep seleccionado
                var mercaderiasOrdenActual = modelo.ObtenerOrdenesConMercaderias()
                    .Where(orden => orden.NroOrdenPrep == nroOrdenSeleccionado);

                // Limpiar el ListView antes de agregar nuevos elementos
                empaquetarmercaderiaListview.Items.Clear();

                // Agregar las mercaderías al ListView
                foreach (var mercaderia in mercaderiasOrdenActual)
                {
                    var item = new ListViewItem(new[]
                    {
                        mercaderia.IdProducto,
                        mercaderia.Mercaderia,
                        mercaderia.Cantidad.ToString()
                    });

                    empaquetarmercaderiaListview.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un NroOrdenPrep para buscar.", "Buscar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            MenuForms menu = new MenuForms(); // Crear instancia del formulario de menú
            this.Hide();
            menu.Show();
        }

        private void empaquetarmercaderiaListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento se puede utilizar para manejar la selección de elementos en el ListView si es necesario
        }

        private void nroordenLabel_Click(object sender, EventArgs e)
        {
            // Este evento se puede utilizar para manejar clics en el Label si es necesario
        }
        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            if (buscarCombobox.SelectedItem != null)
            {
                int nroOrdenSeleccionado = Convert.ToInt32(buscarCombobox.SelectedItem);

                // Obtener las órdenes seleccionadas asociadas al NroOrdenPrep seleccionado
                var ordenesSeleccionadas = modelo.ObtenerOrdenesConMercaderias()
                    .Where(orden => orden.NroOrdenPrep == nroOrdenSeleccionado && orden.Estado == "Seleccionadas");

                if (ordenesSeleccionadas.Any())
                {
                    // Cambiar el estado de las órdenes seleccionadas a "Preparadas"
                    foreach (var orden in ordenesSeleccionadas)
                    {
                        orden.Estado = "Preparadas";
                    }

                    // Mostrar un MessageBox con las mercaderías empaquetadas
                    var mensaje = "Productos Empaquetados:\n\n";
                    foreach (var mercaderia in ordenesSeleccionadas)
                    {
                        mensaje += $"{mercaderia.Mercaderia} - Estado: {mercaderia.Estado}\n";
                    }

                    MessageBox.Show(mensaje, "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quitar la orden empaquetada del ComboBox
                    buscarCombobox.Items.Remove(nroOrdenSeleccionado);
                    buscarCombobox.SelectedItem = null; // Desseleccionar el ítem del ComboBox

                    // Actualizar el ListView
                    buscarButton_Click(sender, e); // Ejecutar la búsqueda nuevamente para actualizar el ListView
                }
                else
                {
                    MessageBox.Show("No hay órdenes seleccionadas para empaquetar.", "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un NroOrdenPrep para empaquetar.", "Empaquetar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}