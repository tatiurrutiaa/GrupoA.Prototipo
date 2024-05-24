using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    internal class EmpaquetadoModel
    {

        public static class DatosTemporales
        {
            public static List<Orden> ObtenerOrdenes()
            {
                // Aquí creas las órdenes y sus productos
                var ordenes = new List<Orden>();


                // Orden 1
                var productosOrden1 = new List<Producto>
                {
                    new Producto { IdProducto = "AA11", NombreProducto = "Bolsas de cemento", CantidadProducto = 5 },
                    new Producto { IdProducto = "BB22", NombreProducto = "Ladrillos", CantidadProducto = 100 }
                };
                ordenes.Add(new Orden { Numero = 1, Productos = productosOrden1 });

                // Orden 2
                var productosOrden2 = new List<Producto>
                {
                    new Producto { IdProducto = "DD44", NombreProducto = "Clavos", CantidadProducto = 200 },
                    new Producto { IdProducto = "EE55", NombreProducto = "Martillos", CantidadProducto = 10 },
                    new Producto { IdProducto = "FF66", NombreProducto = "Serruchos", CantidadProducto = 15 }
                };
                ordenes.Add(new Orden { Numero = 2, Productos = productosOrden2 });

                // Orden 3
                var productosOrden3 = new List<Producto>
                {
                    new Producto { IdProducto = "CC33", NombreProducto = "Madera", CantidadProducto = 50 },
                    new Producto { IdProducto = "GG77", NombreProducto = "Pintura blanca", CantidadProducto = 20 },
                    new Producto { IdProducto = "HH88", NombreProducto = "Rodillos de pintura", CantidadProducto = 25 },
                    new Producto { IdProducto = "II99", NombreProducto = "Brochas", CantidadProducto = 30 }
                };
                ordenes.Add(new Orden { Numero = 3, Productos = productosOrden3 });

                // Orden 4
                var productosOrden4 = new List<Producto>
                {
                    new Producto { IdProducto = "JJ00", NombreProducto = "Tubos PVC", CantidadProducto = 40 },
                    new Producto { IdProducto = "KK11", NombreProducto = "Codos PVC", CantidadProducto = 50 },
                    new Producto { IdProducto = "LL22", NombreProducto = "Conexiones PVC", CantidadProducto = 60 },
                    new Producto { IdProducto = "DD44", NombreProducto = "Clavos", CantidadProducto = 100 },
                    new Producto { IdProducto = "EE55", NombreProducto = "Martillos", CantidadProducto = 5 },
                    new Producto { IdProducto = "FF66", NombreProducto = "Serruchos", CantidadProducto = 10 }
                };
                ordenes.Add(new Orden { Numero = 4, Productos = productosOrden4 });

                // Orden 5
                var productosOrden5 = new List<Producto>
                {
                    new Producto { IdProducto = "MM33", NombreProducto = "Cables eléctricos", CantidadProducto = 100 },
                    new Producto { IdProducto = "NN44", NombreProducto = "Interruptores", CantidadProducto = 20 },
                    new Producto { IdProducto = "OO55", NombreProducto = "Enchufes", CantidadProducto = 30 }
                };
                ordenes.Add(new Orden { Numero = 5, Productos = productosOrden5 });


                return ordenes;
            }
        }
    }
}
