using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.OrdenSeleccion
{
    internal class OrdenSeleccionModel
    {
        public List<OrdenesPreparacion> ordenesPreparacion = new()
        {
            new OrdenesPreparacion { NroOrdenPrep = 15, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 16, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 17, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 18, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 19, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 20, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 21, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 22, Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 23, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 24, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 25, Estado = "en despacho" }
        };

        private List<OrdenesSeleccion> ordenesSeleccion = new();

        public List<OrdenesPreparacion> OrdenesPendientes()
        {
            return ordenesPreparacion
                .Where(o => o.Estado == "pendiente")
                .ToList();
        }

        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var orden in OrdenesPendientes())
            {
                listBox.Items.Add($"Orden {orden.NroOrdenPrep}");
            }

            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparación pendientes para seleccionar." +
                    Environment.NewLine +
                    $"Por favor, intente nuevamente en unos minutos.");
            }
        }

        public void GenerarOrdenDeSeleccion(CheckedListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparación pendientes para seleccionar" +
                    Environment.NewLine +
                    $"Por favor, intente nuevamente en unos minutos.");
                return;
            }

            if (listBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden de preparación.");
                return;
            }

            if (listBox.CheckedItems.Count > 0)
            {
                var selectedOrders = listBox.CheckedItems.Cast<string>();
                List<OrdenesPreparacion> detalleOrden = new List<OrdenesPreparacion>();

                foreach (var item in selectedOrders)
                {
                    var ordenNum = int.Parse(item.Split(' ')[1]);
                    var orden = OrdenesPendientes()
                        .FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        orden.Estado = "En despacho";
                        detalleOrden.Add(orden);
                    }
                }

                // Obtener el número de orden de entrega más alto existente y sumar 1
                int nuevoNroOrdenEntrega = (ordenesSeleccion.Any() ? ordenesSeleccion
                    .Max(o => o.NroOrdenSelec) : 0) + 1;

                // Crear una nueva orden de seleccion
                OrdenesSeleccion nuevaOrdenEntrega = new()
                {
                    NroOrdenSelec = nuevoNroOrdenEntrega,
                    DetalleOrdenSeleccion = detalleOrden
                };
                ordenesSeleccion.Add(nuevaOrdenEntrega);

                // Mostrar el mensaje con las órdenes en líneas separadas
                string selectedOrdersString = string.Join(Environment.NewLine, selectedOrders);
                MessageBox.Show($"Orden de Selección {nuevoNroOrdenEntrega} creada. \n" +
                    $"Detalle de la orden:" +
                    $"\n{selectedOrdersString}");

                // Actualiza el estado de las órdenes en el ListBox
                AgregarOrdenesAlListBox(listBox);
            }
        }
    }
}
