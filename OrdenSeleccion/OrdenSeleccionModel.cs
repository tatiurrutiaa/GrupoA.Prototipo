using GrupoA.Prototipo.Archivos;
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
        //private List<RetiroStock.OrdenSeleccion> ordenesSeleccion = new();

        public List<RetiroStock.OrdenPreparacion> OrdenesPendientes()
        {
            var criticidadPrioridad = new Dictionary<string, int>
            {
                { "alta", 1 },
                { "media", 2 },
                { "baja", 3 }
            };

            var criticidadDict = ArchivoContrato.Contratos.ToDictionary(c => c.CuitCliente, c => c.Criticidad);

            return ArchivoOrdenPreparacion.OrdenesPreparacion
                .Where(o => o.Estado == "pendiente")
                .OrderBy(o => criticidadPrioridad[criticidadDict[o.CuitCliente]])
                .ToList();
        }

        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();

            foreach (var orden in OrdenesPendientes())
            {
                var criticidad = ArchivoContrato.BuscarCriticidad(orden.CuitCliente);
                listBox.Items.Add($"Orden {orden.NroOrdenPrep} - Prioridad: {criticidad}");
            }

            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("No hay órdenes de preparación pendientes para seleccionar." +
                    Environment.NewLine +
                    "Por favor, intente nuevamente en unos minutos.");
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
                List<int> detalleOrden = new List<int>();

                foreach (var item in selectedOrders)
                {
                    var ordenNum = int.Parse(item.Split(' ')[1]);
                    var orden = OrdenesPendientes()
                        .FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        orden.Estado = "en seleccion";
                        detalleOrden.Add(ordenNum);
                    }
                    ArchivoOrdenPreparacion.ModificarEstado(orden, "en selección");
                }

                // Obtener el número de orden de entrega más alto existente y sumar 1
                int nuevoNroOrdenEntrega = (ArchivoOrdenSeleccion.OrdenesSeleccion.Any() ? ArchivoOrdenSeleccion.OrdenesSeleccion
                    .Max(o => o.NroOrdenSelec) : 0) + 1;

                // Crear una nueva orden de seleccion
                RetiroStock.OrdenSeleccion nuevaOrdenSeleccion = new()
                {
                    NroOrdenSelec = nuevoNroOrdenEntrega,
                    NroOrdenesPreparacion = detalleOrden,
                    Estado = "en seleccion"
                };
                if (nuevaOrdenSeleccion == null)
                {
                    throw new ArgumentNullException(nameof(nuevaOrdenSeleccion), "El objeto orden no puede ser null");
                }
                ArchivoOrdenSeleccion.AgregarOrdenSeleccion(nuevaOrdenSeleccion);

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
