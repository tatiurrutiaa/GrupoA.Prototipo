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
                    new MercaderiasDetalle { IdProducto = "A001", Mercaderia = "bolsas de cemento", CantidadProducto = 700 },
                    new MercaderiasDetalle { IdProducto = "A002", Mercaderia = "ladrillos", CantidadProducto = 500 },
                    new MercaderiasDetalle { IdProducto = "A003", Mercaderia = "cemento cola", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 35,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionaas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                    new MercaderiasDetalle { IdProducto = "A005", Mercaderia = "láminas de metal", CantidadProducto = 500 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 36,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                    new MercaderiasDetalle { IdProducto = "A011", Mercaderia = "pantalones", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 37,
                    CuitCliente = "30-12345678-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = "B001", Mercaderia = "camisas", CantidadProducto = 200 },
                        new MercaderiasDetalle { IdProducto = "B002", Mercaderia = "pantalones", CantidadProducto = 150 },
                        new MercaderiasDetalle { IdProducto = "B003", Mercaderia = "chaquetas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 38,
                    CuitCliente = "30-87654321-0",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = "C001", Mercaderia = "sofás", CantidadProducto = 50 },
                        new MercaderiasDetalle { IdProducto = "C002", Mercaderia = "mesas de comedor", CantidadProducto = 30 },
                        new MercaderiasDetalle { IdProducto = "C003", Mercaderia = "sillas", CantidadProducto = 100 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 39,
                    CuitCliente = "30-11223344-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = "D001", Mercaderia = "televisores", CantidadProducto = 20 },
                        new MercaderiasDetalle { IdProducto = "D002", Mercaderia = "refrigeradores", CantidadProducto = 10 },
                        new MercaderiasDetalle { IdProducto = "D003", Mercaderia = "lavadoras", CantidadProducto = 15 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 40,
                    CuitCliente = "30-55667788-9",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = "E001", Mercaderia = "muñecas", CantidadProducto = 200 },
                        new MercaderiasDetalle { IdProducto = "E002", Mercaderia = "autos de juguete", CantidadProducto = 150 },
                        new MercaderiasDetalle { IdProducto = "E003", Mercaderia = "legos", CantidadProducto = 300 }
                    }
                },
                new OrdenesPreparacion
                {
                    NroOrdenPrep = 41,
                    CuitCliente = "30-99887766-5",
                    Estado = "Seleccionadas",
                    Mercaderias = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { IdProducto = "F001", Mercaderia = "novelas", CantidadProducto = 100 },
                        new MercaderiasDetalle { IdProducto = "F002", Mercaderia = "libros de texto", CantidadProducto = 80 },
                        new MercaderiasDetalle { IdProducto = "F003", Mercaderia = "diccionarios", CantidadProducto = 50 }
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
    }







}
