using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.EmpaquetarMercaderia
{
    public class EmpaquetarMercaderiaModel
    {


        public List<OrdenesPreparacion> ordenesPreparacion = new()
        {
            new OrdenesPreparacion { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = "bolsas de cemento", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Cantidad = 500, Mercaderia = "ladrillos", Estado = "Sleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 36, CuitCliente = "27-41672496-8", Cantidad = 300, Mercaderia = "cemento cola", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 37, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "láminas de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 38, CuitCliente = "30-87654321-9", Cantidad = 300, Mercaderia = "pantalones", Estado = "Seleccionadas" }
        };

        public List<Mercaderias> Mercaderia = new()
        {
            new Mercaderias { NroOrdenPrep = 34, IdProducto = "A001", Mercaderia = "Bolsas de cemento", CantidadProducto = 700 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A002", Mercaderia = "ladrillos", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 36, IdProducto = "A003", Mercaderia = "cemento cola", CantidadProducto = 300 },
            new Mercaderias { NroOrdenPrep = 37, IdProducto = "A005", Mercaderia = "Láminas de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 38, IdProducto = "A011", Mercaderia = "Pantalones", CantidadProducto = 300 }

        };
        public List<OrdenesEmpaquetar> ObtenerOrdenesConMercaderias()
        {
            List<OrdenesEmpaquetar> ordenesConMercaderias = new List<OrdenesEmpaquetar>();

            foreach (var orden in ordenesPreparacion)
            {
                // Obtener las mercaderías asociadas a la orden actual
                var mercaderiasAsociadas = Mercaderia.Where(mercaderia => mercaderia.NroOrdenPrep == orden.NroOrdenPrep);

                // Crear una OrdenEmpaquetar para cada mercadería asociada
                foreach (var mercaderia in mercaderiasAsociadas)
                {
                    ordenesConMercaderias.Add(new OrdenesEmpaquetar
                    {
                        NroOrdenPrep = orden.NroOrdenPrep,
                        Mercaderia = mercaderia.Mercaderia,
                        IdProducto = mercaderia.IdProducto,
                        Cantidad = mercaderia.CantidadProducto,
                        Estado = orden.Estado
                    });
                }
            }

            return ordenesConMercaderias;
        }





    }
}
