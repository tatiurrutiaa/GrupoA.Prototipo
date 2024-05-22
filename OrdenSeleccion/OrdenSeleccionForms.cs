using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo
{
    // FormularioPrincipal.cs
    public partial class OrdenSeleccionForms : Form
   {
        private List<Orden> ordenes;
        public OrdenSeleccionForms()
        {
            InitializeComponent();
            CargarOrdenes();
            MostrarOrdenes();
        }

        private void CargarOrdenes()
        {
            // Simula la carga de órdenes desde una base de datos
            ordenes = new List<Orden>
        {
            new Orden { OrdenId = 1, Estado = "Seleccion", Productos = new List<Producto>
            {
                new Producto { ProductoId = 1, Nombre = "Producto A", CantidadRequerida = 10, CantidadDisponible = 15, UbicacionAlmacen = "A1" },
                new Producto { ProductoId = 2, Nombre = "Producto B", CantidadRequerida = 5, CantidadDisponible = 3, UbicacionAlmacen = "B1" }
            }},
            new Orden { OrdenId = 2, Estado = "Seleccion", Productos = new List<Producto>
            {
                new Producto { ProductoId = 3, Nombre = "Producto C", CantidadRequerida = 8, CantidadDisponible = 10, UbicacionAlmacen = "C1" }
            }}
        };
        }

        private void MostrarOrdenes()
        {
            foreach (var orden in ordenes)
            {
                if (orden.Estado == "Seleccion")
                {
                    lstOrdenes.Items.Add($"Orden ID: {orden.OrdenId}");
                }
            }
        }

 
    private void btnGenerarOrdenSeleccion_Click(object sender, EventArgs e)
    {
        if (lstOrdenes.SelectedItem != null)
        {
            int ordenIdSeleccionada = int.Parse(lstOrdenes.SelectedItem.ToString().Split(':')[1].Trim());
            Orden ordenSeleccionada = ordenes.Find(o => o.OrdenId == ordenIdSeleccionada);

            if (ordenSeleccionada != null)
            {
                var ordenSeleccion = new OrdenSeleccion
                {
                    OrdenId = ordenSeleccionada.OrdenId,
                    ProductosSeleccionados = new List<ProductoSeleccionado>()
                };

                foreach (var producto in ordenSeleccionada.Productos)
                {
                    if (producto.CantidadDisponible >= producto.CantidadRequerida)
                    {
                        ordenSeleccion.ProductosSeleccionados.Add(new ProductoSeleccionado
                        {
                            ProductoId = producto.ProductoId,
                            CantidadARecoger = producto.CantidadRequerida,
                            UbicacionAlmacen = producto.UbicacionAlmacen
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Producto {producto.Nombre} no tiene suficiente stock. Requiere {producto.CantidadRequerida}, disponible {producto.CantidadDisponible}.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Aquí se van a guardar la selección en una base de datos o procesarla como se requieran
                MessageBox.Show("Orden de selección generada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Por favor selecciona una orden de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

    private void botonAtras_Click(object sender, EventArgs e)
    {
        GrupoA.Prototipo.MenuForms menu = new();
        this.Hide();
        menu.Show();
    }
}