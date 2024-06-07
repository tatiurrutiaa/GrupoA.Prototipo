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
            new OrdenesPreparacion { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = "bolsas de arena", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = "ladrillos", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = "bolsa de piedras", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "láminas de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "placas de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "bobinas de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "hojas de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 35, CuitCliente = "30-87654321-9", Cantidad = 500, Mercaderia = "perfiles de metal", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 36, CuitCliente = "30-87654321-9", Cantidad = 300, Mercaderia = "pantalones", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 36, CuitCliente = "30-87654321-9", Cantidad = 300, Mercaderia = "chaquetas", Estado = "Seleccionadas" },
            new OrdenesPreparacion { NroOrdenPrep = 36, CuitCliente = "30-87654321-9", Cantidad = 300, Mercaderia = "zapatos", Estado = "Seleccionadas" }
        };
        public List<Mercaderias> Mercaderia = new()
        {
            new Mercaderias { NroOrdenPrep = 34, IdProducto = "A001", Mercaderia = "Bolsas de cemento", CantidadProducto = 700 },
            new Mercaderias { NroOrdenPrep = 34, IdProducto = "A002", Mercaderia = "Bolsas de arena", CantidadProducto = 700 },
            new Mercaderias { NroOrdenPrep = 34, IdProducto = "A003", Mercaderia = "Ladrillos", CantidadProducto = 700 },
            new Mercaderias { NroOrdenPrep = 34, IdProducto = "A004", Mercaderia = "Bolsa de piedras", CantidadProducto = 700 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A005", Mercaderia = "Láminas de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A006", Mercaderia = "Placas de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A007", Mercaderia = "Bobinas de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A008", Mercaderia = "Hojas de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 35, IdProducto = "A009", Mercaderia = "Perfiles de metal", CantidadProducto = 500 },
            new Mercaderias { NroOrdenPrep = 36, IdProducto = "A011", Mercaderia = "Pantalones", CantidadProducto = 300 },
            new Mercaderias { NroOrdenPrep = 36, IdProducto = "A012", Mercaderia = "Chaquetas", CantidadProducto = 300 },
            new Mercaderias { NroOrdenPrep = 36, IdProducto = "A013", Mercaderia = "Zapatos", CantidadProducto = 300 }
        };
        public List<OrdenesEmpaquetar> ObtenerOrdenesConMercaderias()
        {
            var ordenesConMercaderias = from orden in ordenesPreparacion
                                        join mercaderia in Mercaderia on orden.NroOrdenPrep equals mercaderia.NroOrdenPrep
                                        select new OrdenesEmpaquetar
                                        {
                                            NroOrdenPrep = orden.NroOrdenPrep,
                                            Mercaderia = orden.Mercaderia,
                                            IdProducto = mercaderia.IdProducto,
                                            Cantidad = mercaderia.CantidadProducto,
                                            Estado = orden.Estado
                                        };

            return ordenesConMercaderias.ToList();
        }


    }
}
