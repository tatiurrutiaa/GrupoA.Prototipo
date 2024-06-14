﻿using GrupoA.Prototipo.RetiroStock;
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
            new OrdenesPreparacion { NroOrdenPrep = 15, CuitCliente = "27-41672496-8", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 16, CuitCliente = "27-41672496-8", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 17, CuitCliente = "27-41672496-8", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 18, CuitCliente = "27-41672496-8", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 19, CuitCliente = "30-22465788-7", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 20, CuitCliente = "30-22465788-7", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 21, CuitCliente = "34-56564433-5", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 22, CuitCliente = "34-56564433-5", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 23, CuitCliente = "30-23456789-1", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 24, CuitCliente = "30-23456789-1", Estado = "pendiente" },
            new OrdenesPreparacion { NroOrdenPrep = 25, CuitCliente = "30-23456789-1", Estado = "en despacho" }
        };

        public List<Contrato> CriticidadPorCliente = new()
        {
            new Contrato { CuitCliente = "27-41672496-8", Criticidad = "alta"},
            new Contrato { CuitCliente = "30-22465788-7", Criticidad = "media"},
            new Contrato { CuitCliente = "34-56564433-5", Criticidad = "baja"},
            new Contrato { CuitCliente = "30-23456789-1", Criticidad = "alta"},
        };

        private List<OrdenesSeleccion> ordenesSeleccion = new();

        public List<OrdenesPreparacion> OrdenesPendientes()
        {
            var criticidadPrioridad = new Dictionary<string, int>
            {
                { "alta", 1 },
                { "media", 2 },
                { "baja", 3 }
            };

            var criticidadDict = CriticidadPorCliente.ToDictionary(c => c.CuitCliente, c => c.Criticidad);

            return ordenesPreparacion
                .Where(o => o.Estado == "pendiente")
                .OrderBy(o => criticidadPrioridad[criticidadDict[o.CuitCliente]])
                .ToList();
        }

        public void AgregarOrdenesAlListBox(CheckedListBox listBox)
        {
            listBox.Items.Clear();
            var criticidadDict = CriticidadPorCliente.ToDictionary(c => c.CuitCliente, c => c.Criticidad);

            foreach (var orden in OrdenesPendientes())
            {
                var criticidad = criticidadDict[orden.CuitCliente];
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
