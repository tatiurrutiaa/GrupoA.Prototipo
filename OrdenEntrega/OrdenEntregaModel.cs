using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoA.Prototipo.OrdenEntrega;
using GrupoA.Prototipo.RetiroStock;

namespace GrupoA.Prototipo.OrdenesdeEntrega
{
    internal class OrdenEntregaModel
    {
        public List<OrdenesPreparacion> ordenesPreparación = new()
        {
            new OrdenesPreparacion { NroOrdenPrep = 15, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 16, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 17, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 18, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 20, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 21, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 22, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 23, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 24, Estado = "preparada" },
            new OrdenesPreparacion { NroOrdenPrep = 25, Estado = "en despacho" }
        };

        private List<GrupoA.Prototipo.OrdenEntrega.OrdenEntrega> ordenesEntrega = new();

        public List<OrdenesPreparacion> OrdenesPreparadas()
        {
            return ordenesPreparación
                .Where(o => o.Estado == "preparada")
                .ToList();
        }

        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var orden in OrdenesPreparadas())
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
                List<OrdenesPreparacion> detalleOrden = new List<OrdenesPreparacion>();

                foreach (var item in selectedOrders)
                {
                    var ordenNum = int.Parse(item.Split(' ')[1]);
                    var orden = OrdenesPreparadas().FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        orden.Estado = "En despacho";
                        detalleOrden.Add(orden);
                    }
                }

                // Obtener el número de orden de entrega más alto existente y sumar 1
                int nuevoNroOrdenEntrega = (ordenesEntrega.Any() ? ordenesEntrega.Max(o => o.NroOrdenEntrega) : 0) + 1;

                // Crear una nueva orden de entrega
                GrupoA.Prototipo.OrdenEntrega.OrdenEntrega nuevaOrdenEntrega = new()
                {
                    NroOrdenEntrega = nuevoNroOrdenEntrega,
                    DetalleOrden = detalleOrden
                };
                ordenesEntrega.Add(nuevaOrdenEntrega);

                // Mostrar el mensaje con las órdenes en líneas separadas
                string selectedOrdersString = string.Join(Environment.NewLine, selectedOrders);
                MessageBox.Show($"Orden de Entrega {nuevoNroOrdenEntrega} creada. \n" +
                    $"Detalle de la orden:" +
                    $"\n{selectedOrdersString}");

                // Actualiza el estado de las órdenes en el ListBox
                AgregarOrdenesAlListBox(listBox);
            }
        }
    }
}
