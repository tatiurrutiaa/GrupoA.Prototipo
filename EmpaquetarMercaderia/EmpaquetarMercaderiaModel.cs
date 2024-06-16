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
        public List<RetiroStock.OrdenPreparacion> OrdenesPreparacion { get; set; }

        public EmpaquetarMercaderiaModel()
        {
            OrdenesPreparacion = new List<RetiroStock.OrdenPreparacion>
            {
                /*new OrdenesPreparacion
                {
                    NroOrdenPrep = 34,
                    CuitCliente = "27-41672496-8",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "bolsas de cemento", CantidadProducto = 700 },
                        new MercaderiasDetalle { CodProducto = 2 , DescProducto = "ladrillos", CantidadProducto = 500 },
                        new MercaderiasDetalle { CodProducto = 3 , DescProducto = "cemento cola", CantidadProducto = 300 },
                        new MercaderiasDetalle { CodProducto = 4 , DescProducto = "bolsas de arena", CantidadProducto = 1000 },
                        new MercaderiasDetalle { CodProducto = 5 , DescProducto = "bolsas de cal", CantidadProducto = 800 },
                        new MercaderiasDetalle { CodProducto = 6 , DescProducto = "vigas de madera", CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto = 7 , DescProducto = "tejas", CantidadProducto = 400 },
                        new MercaderiasDetalle { CodProducto = 8 , DescProducto = "cable eléctrico", CantidadProducto = 600 },
                        new MercaderiasDetalle { CodProducto = 9 , DescProducto = "tubos de PVC", CantidadProducto = 300 }

                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 35,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionaas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "láminas de metal", CantidadProducto = 500 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 36,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "pantalones", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 37,
                    CuitCliente = "30-12345678-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, DescProducto = "camisas", CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto = 2 , DescProducto = "pantalones", CantidadProducto = 150 },
                        new MercaderiasDetalle { CodProducto = 3 , DescProducto = "chaquetas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 38,
                    CuitCliente = "30-87654321-0",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "sofás", CantidadProducto = 50 },
                        new MercaderiasDetalle { CodProducto = 2 , DescProducto = "mesas de comedor", CantidadProducto = 30 },
                        new MercaderiasDetalle { CodProducto = 3 , DescProducto = "sillas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 39,
                    CuitCliente = "30-11223344-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "televisores", CantidadProducto = 20 },
                        new MercaderiasDetalle { CodProducto = 2 , DescProducto = "refrigeradores", CantidadProducto = 10 },
                        new MercaderiasDetalle { CodProducto = 3 , DescProducto = "lavadoras", CantidadProducto = 15 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 40,
                    CuitCliente = "30-55667788-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto =  1 , DescProducto = "muñecas", CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto =  2 , DescProducto = "autos de juguete", CantidadProducto = 150 },
                        new MercaderiasDetalle { CodProducto =  3 , DescProducto = "legos", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 41,
                    CuitCliente = "30-99887766-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1 , DescProducto = "novelas", CantidadProducto = 100 },
                        new MercaderiasDetalle { CodProducto = 2 , DescProducto = "libros de texto", CantidadProducto = 80 },
                        new MercaderiasDetalle { CodProducto = 3 , DescProducto = "diccionarios", CantidadProducto = 50 }
                    }
                }*/

            };
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesSeleccionadas()
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
