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
        public List<OrdenesPreparacion> OrdenesPreparacion { get; set; }

        public EmpaquetarMercaderiaModel()
        {
            OrdenesPreparacion = new List<OrdenesPreparacion>
            {   
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 34,
                    CuitCliente = "27-41672496-8",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "bolsas de cemento", CantidadProducto = 700 },
                        new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "ladrillos", CantidadProducto = 500 },
                        new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "cemento cola", CantidadProducto = 300 },
                        new MercaderiasDetalle { IdProducto = 4 , Mercaderia = "bolsas de arena", CantidadProducto = 1000 },
                        new MercaderiasDetalle { IdProducto = 5 , Mercaderia = "bolsas de cal", CantidadProducto = 800 },
                        new MercaderiasDetalle { IdProducto = 6 , Mercaderia = "vigas de madera", CantidadProducto = 200 },
                        new MercaderiasDetalle { IdProducto = 7 , Mercaderia = "tejas", CantidadProducto = 400 },
                        new MercaderiasDetalle { IdProducto = 8 , Mercaderia = "cable eléctrico", CantidadProducto = 600 },
                        new MercaderiasDetalle { IdProducto = 9 , Mercaderia = "tubos de PVC", CantidadProducto = 300 }

                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 35,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionaas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "láminas de metal", CantidadProducto = 500 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 36,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "pantalones", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 37,
                    CuitCliente = "30-12345678-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1, Mercaderia = "camisas", CantidadProducto = 200 },
                        new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "pantalones", CantidadProducto = 150 },
                        new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "chaquetas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 38,
                    CuitCliente = "30-87654321-0",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "sofás", CantidadProducto = 50 },
                        new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "mesas de comedor", CantidadProducto = 30 },
                        new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "sillas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 39,
                    CuitCliente = "30-11223344-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "televisores", CantidadProducto = 20 },
                        new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "refrigeradores", CantidadProducto = 10 },
                        new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "lavadoras", CantidadProducto = 15 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 40,
                    CuitCliente = "30-55667788-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto =  1 , Mercaderia = "muñecas", CantidadProducto = 200 },
                        new MercaderiasDetalle { IdProducto =  2 , Mercaderia = "autos de juguete", CantidadProducto = 150 },
                        new MercaderiasDetalle { IdProducto =  3 , Mercaderia = "legos", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 41,
                    CuitCliente = "30-99887766-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = 1 , Mercaderia = "novelas", CantidadProducto = 100 },
                        new MercaderiasDetalle { IdProducto = 2 , Mercaderia = "libros de texto", CantidadProducto = 80 },
                        new MercaderiasDetalle { IdProducto = 3 , Mercaderia = "diccionarios", CantidadProducto = 50 }
                    }
                }

            };
        }

        public List<OrdenesPreparacion> ObtenerOrdenesSeleccionadas()
        {
            return OrdenesPreparacion.Where(o => o.Estado == "Seleccionadas").ToList();
        }

        public void CambiarEstadoOrden(int nroOrdenPrep, string nuevoEstado)
        {
            var orden = OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrdenPrep);
            if (orden != null)
            {
                orden.Estado = nuevoEstado;
            }
        }
        public string ObtenerCuitCliente(int nroOrden)
        {
            // Buscar la orden correspondiente al número de orden proporcionado
            var orden = OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrden);

            // Si se encontró la orden, devolver el CUIT del cliente; de lo contrario, devolver una cadena vacía
            return orden != null ? orden.CuitCliente : "";
        }
    }
}
