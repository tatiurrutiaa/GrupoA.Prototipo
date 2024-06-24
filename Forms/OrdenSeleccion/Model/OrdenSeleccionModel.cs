using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Contrato;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Ordenes.OrdenSeleccion;
using GrupoA.Prototipo.Forms.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.OrdenSeleccion.Model
{
    internal class OrdenSeleccionModel
    {
        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();
            // Crear un diccionario que asocie cada CuitCliente con su criticidad
            var criticidadDict = ContratoArchivo.Contratos.ToDictionary(c => c.CuitCliente, c => c.Criticidad);

            int? deposito = null;

            //// Ordenar las órdenes por criticidad
            //var ordenesOrdenadas = OrdenPreparacionArchivo.OrdenesPreparacion
            //    .Where(o => o.Estado == EstadosOrdenPreparacion.Pendiente)
            //    .OrderByDescending(o => criticidadDict[o.CuitCliente])
            //    .ToList();

            // Agregar las órdenes al listBox
            foreach (var orden in OrdenPreparacionArchivo.OrdenesPreparacion
                            .Where(o => o.Estado == EstadosOrdenPreparacion.Pendiente))
            {
                if (deposito == null)
                {
                    deposito = orden.NroDeposito;
                }
                else if (orden.NroDeposito != deposito)
                {
                    MessageBox.Show("Seleccione órdenes del mismo depósito.");
                    return;
                }

                var criticidad = criticidadDict[orden.CuitCliente];
                listBox.Items.Add($"Orden {orden.NroOrdenPrep} - Prioridad: {criticidad}");
            }

            // Mostrar mensaje si no hay órdenes pendientes
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
                    var orden = OrdenPreparacionArchivo.OrdenesPreparacion.Where(o => o.Estado == EstadosOrdenPreparacion.Pendiente)
                        .FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        orden.Estado = EstadosOrdenPreparacion.EnSeleccion;
                        detalleOrden.Add(ordenNum);
                    }
                }

                // Obtener el número de orden de entrega más alto existente y sumar 1
                int nuevoNroOrdenEntrega = (OrdenSeleccionArchivo.OrdenesSeleccion.Any() ? OrdenSeleccionArchivo.OrdenesSeleccion
                    .Max(o => o.NroOrdenSelec) : 0) + 1;

                // Crear una nueva orden de seleccion
                OrdenSeleccionEntidad nuevaOrdenEntrega = new()
                {
                    NroOrdenSelec = nuevoNroOrdenEntrega,
                    NroOrdenesPreparacion = detalleOrden,
                    Estado = EstadosOrdenSeleccion.EnSeleccion
                };
                OrdenSeleccionArchivo.AgregarOrdenSeleccion(nuevaOrdenEntrega);

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
