using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.RetiroStock;

namespace GrupoA.Prototipo.OrdenesdeEntrega
{
    internal class OrdenEntregaModel
    {
        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var orden in OrdenPreparacionArchivo.OrdenesPreparacion.Where(o => o.Estado == EstadoOrdenPreparacion.Preparada))
            {
                listBox.Items.Add($"Orden {orden.NroOrdenPrep}");
            }

            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparación pendientes para entregar" +
                    Environment.NewLine +
                    $"Por favor, intente nuevamente en unos minutos.");
            }
        }

        public void GenerarOrdenDeEntrega(CheckedListBox listBox)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparación pendientes para entregar" +
                    Environment.NewLine +
                    $"Por favor, intente nuevamente en unos minutos.");
                return;
            }

            if(listBox.SelectedItems.Count == 0)
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
                    var orden = OrdenPreparacionArchivo.OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        //orden.Estado = "en despacho";
                        OrdenPreparacionArchivo.ModificarEstado(orden, EstadoOrdenPreparacion.EnDespacho);
                        detalleOrden.Add(ordenNum);
                    }
                }

                // Obtener el número de orden de entrega más alto existente y sumar 1
                int nuevoNroOrdenEntrega = (OrdenEntregaArchivo.OrdenesEntrega.Any() ? OrdenEntregaArchivo.OrdenesEntrega.Max(o => o.NroOrdenEntrega) : 0) + 1;

                // Crear una nueva orden de entrega
                OrdenEntregaEntidad nuevaOrdenEntrega = new()
                {
                    NroOrdenEntrega = nuevoNroOrdenEntrega,
                    NroOrdenPreparacion = detalleOrden
                };
                //ordenesEntrega.Add(nuevaOrdenEntrega);
                OrdenEntregaArchivo.AgregarOrdenEntrega(nuevaOrdenEntrega);

                // Mostrar el mensaje con las órdenes en líneas separadas
                string selectedOrdersString = string.Join(Environment.NewLine,
                    detalleOrden.Select(num => $"Orden {num}"));
                MessageBox.Show($"Orden de Entrega {nuevoNroOrdenEntrega} creada. \n" +
                    $"Detalle de la orden:" +
                    $"\n{selectedOrdersString}");

                // Actualiza el estado de las órdenes en el ListBox
                AgregarOrdenesAlListBox(listBox);
            }
        }
    }
}
