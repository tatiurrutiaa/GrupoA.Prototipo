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
            public static List<OrdenEmpaquetar> ObtenerOrdenes()
            {
                // Aquí creas las órdenes y sus productos
                var ordenes = new List<OrdenEmpaquetar>();


                // Orden 1
                var productosOrden1 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "AA11", NombreProducto = "Bolsas de cemento", CantidadProducto = 5 },
                    new Mercaderia { IdProducto = "BB22", NombreProducto = "Ladrillos", CantidadProducto = 100 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 1, Productos = productosOrden1 });

                // Orden 2
                var productosOrden2 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "DD44", NombreProducto = "Clavos", CantidadProducto = 200 },
                    new Mercaderia { IdProducto = "EE55", NombreProducto = "Martillos", CantidadProducto = 10 },
                    new Mercaderia { IdProducto = "FF66", NombreProducto = "Serruchos", CantidadProducto = 15 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 2, Productos = productosOrden2 });

                // Orden 3
                var productosOrden3 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "CC33", NombreProducto = "Madera", CantidadProducto = 50 },
                    new Mercaderia { IdProducto = "GG77", NombreProducto = "Pintura blanca", CantidadProducto = 20 },
                    new Mercaderia { IdProducto = "HH88", NombreProducto = "Rodillos de pintura", CantidadProducto = 25 },
                    new Mercaderia { IdProducto = "II99", NombreProducto = "Brochas", CantidadProducto = 30 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 3, Productos = productosOrden3 });

                // Orden 4
                var productosOrden4 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "JJ00", NombreProducto = "Tubos PVC", CantidadProducto = 40 },
                    new Mercaderia { IdProducto = "KK11", NombreProducto = "Codos PVC", CantidadProducto = 50 },
                    new Mercaderia { IdProducto = "LL22", NombreProducto = "Conexiones PVC", CantidadProducto = 60 },
                    new Mercaderia { IdProducto = "DD44", NombreProducto = "Clavos", CantidadProducto = 100 },
                    new Mercaderia { IdProducto = "EE55", NombreProducto = "Martillos", CantidadProducto = 5 },
                    new Mercaderia { IdProducto = "FF66", NombreProducto = "Serruchos", CantidadProducto = 10 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 4, Productos = productosOrden4 });

                // Orden 5
                var productosOrden5 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "MM33", NombreProducto = "Cables eléctricos", CantidadProducto = 100 },
                    new Mercaderia { IdProducto = "NN44", NombreProducto = "Interruptores", CantidadProducto = 20 },
                    new Mercaderia { IdProducto = "OO55", NombreProducto = "Enchufes", CantidadProducto = 30 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 5, Productos = productosOrden5 });

                //Orden 6
                var produtosOrden6 = new List<Mercaderia>
                {
                    new Mercaderia { IdProducto = "OO55", NombreProducto = "Enchufes", CantidadProducto = 30 },
                    new Mercaderia { IdProducto = "MM33", NombreProducto = "Cables eléctricos", CantidadProducto = 100 },
                    new Mercaderia { IdProducto = "A123", NombreProducto = "Cable USB", CantidadProducto = 50 },
                    new Mercaderia { IdProducto = "B456", NombreProducto = "Adaptador HDMI", CantidadProducto = 20 },
                    new Mercaderia { IdProducto = "C789", NombreProducto = "Cargador Inalámbrico", CantidadProducto = 15 },
                    new Mercaderia { IdProducto = "D012", NombreProducto = "Teclado Mecánico", CantidadProducto = 10 },
                    new Mercaderia { IdProducto = "E345", NombreProducto = "Mouse Inalámbrico", CantidadProducto = 25 },
                    new Mercaderia { IdProducto = "F678", NombreProducto = "Monitor LED", CantidadProducto = 5 },
                    new Mercaderia { IdProducto = "G901", NombreProducto = "Impresora Láser", CantidadProducto = 8 },
                    new Mercaderia { IdProducto = "H234", NombreProducto = "Altavoces Bluetooth", CantidadProducto = 18 },
                    new Mercaderia { IdProducto = "I567", NombreProducto = "Auriculares", CantidadProducto = 22 }
                };
                ordenes.Add(new OrdenEmpaquetar { Numero = 6, Productos = produtosOrden6 });

                return ordenes;
            }
        }
    }
}
