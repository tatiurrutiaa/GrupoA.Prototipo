using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GrupoA.Prototipo.RetiroStock;

namespace GrupoA.Prototipo.OrdenesdeEntrega
{
    public class OrdendeEntregaModel
    {
        private List<OrdenesPreparacion> ordenesPreparacion;

        public OrdendeEntregaModel()
        {
            ordenesPreparacion = new List<OrdenesPreparacion>
            {
                new OrdenesPreparacion {NroOrdenPrep = 15, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 16, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 17, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 18, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 20, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 21, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 22, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 23, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 24, Estado = "preparada"},
                new OrdenesPreparacion {NroOrdenPrep = 25, Estado = "preparada"}
            };
        }

        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            foreach (var orden in ordenesPreparacion)
            {
                listBox.Items.Add($"Orden {orden.NroOrdenPrep}: {orden.Estado}");
            }
        }

        public void GenerarOrdenDeEntrega(CheckedListBox listBox)
        {
            if (listBox.CheckedItems.Count > 0)
            {
                var selectedOrders = listBox.CheckedItems.Cast<string>();
                string selectedOrdersString = string.Join(", ", selectedOrders);

                // Actualiza el estado de las órdenes seleccionadas a "En despacho"
                foreach (var item in selectedOrders)
                {
                    var ordenNum = int.Parse(item.Split(' ')[1].TrimEnd(':'));
                    var orden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenNum);
                    if (orden != null)
                    {
                        orden.Estado = "En despacho";
                    }
                }

                MessageBox.Show($"Orden de entrega generada para: {selectedOrdersString}");

                // Actualiza el estado de las órdenes en el ListBox
                listBox.Items.Clear();
                AgregarOrdenesAlListBox(listBox);
            }
            else
            {
                MessageBox.Show("Seleccione al menos una orden de preparación primero.");
            }
        }
    }
}
