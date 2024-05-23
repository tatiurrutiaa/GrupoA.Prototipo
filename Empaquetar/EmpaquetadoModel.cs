using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetar
{
    internal class EmpaquetadoModel
    {
        public class Producto
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }

            // Otros atributos del producto

            public override string ToString()
            {
                return $"[ID: {Id}], Producto: {Nombre}, (Cantidad: {Cantidad})";
            }
        }

        public class Orden
        {
            public int Numero { get; set; }
            public List<Producto> Productos { get; set; }

            public override string ToString()
            {
                return $"Orden #{Numero}";
            }
        }

        public static class DatosTemporales
        {
            public static List<Orden> ObtenerOrdenes()
            {
                // Aquí creas las órdenes y sus productos
                var ordenes = new List<Orden>();


                // Orden 1
                var productosOrden1 = new List<Producto>
                {
                    new Producto { Id = "AA11", Nombre = "Bolsas de cemento", Cantidad = 5 },
                    new Producto { Id = "BB22", Nombre = "Ladrillos", Cantidad = 100 },
                    new Producto { Id = "CC33", Nombre = "Madera", Cantidad = 50 }
                };
                ordenes.Add(new Orden { Numero = 1, Productos = productosOrden1 });

                // Orden 2
                var productosOrden2 = new List<Producto>
                {
                    new Producto { Id = "DD44", Nombre = "Clavos", Cantidad = 200 },
                    new Producto { Id = "EE55", Nombre = "Martillos", Cantidad = 10 },
                    new Producto { Id = "FF66", Nombre = "Serruchos", Cantidad = 15 }
                };
                ordenes.Add(new Orden { Numero = 2, Productos = productosOrden2 });

                // Orden 3
                var productosOrden3 = new List<Producto>
                {
                    new Producto { Id = "GG77", Nombre = "Pintura blanca", Cantidad = 20 },
                    new Producto { Id = "HH88", Nombre = "Rodillos de pintura", Cantidad = 25 },
                    new Producto { Id = "II99", Nombre = "Brochas", Cantidad = 30 }
                };
                ordenes.Add(new Orden { Numero = 3, Productos = productosOrden3 });

                // Orden 4
                var productosOrden4 = new List<Producto>
                {
                    new Producto { Id = "JJ00", Nombre = "Tubos PVC", Cantidad = 40 },
                    new Producto { Id = "KK11", Nombre = "Codos PVC", Cantidad = 50 },
                    new Producto { Id = "LL22", Nombre = "Conexiones PVC", Cantidad = 60 }
                };
                ordenes.Add(new Orden { Numero = 4, Productos = productosOrden4 });

                // Orden 5
                var productosOrden5 = new List<Producto>
                {
                    new Producto { Id = "MM33", Nombre = "Cables eléctricos", Cantidad = 100 },
                    new Producto { Id = "NN44", Nombre = "Interruptores", Cantidad = 20 },
                    new Producto { Id = "OO55", Nombre = "Enchufes", Cantidad = 30 }
                };
                ordenes.Add(new Orden { Numero = 5, Productos = productosOrden5 });


                return ordenes;
            }
        }
    }
}
