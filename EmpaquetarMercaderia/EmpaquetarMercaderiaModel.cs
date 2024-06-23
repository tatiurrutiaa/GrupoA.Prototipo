using GrupoA.Prototipo.Archivos;
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
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 34,
                    CuitCliente = "27-41672496-8",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 700 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 500 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 300 },
                        new MercaderiasDetalle { CodProducto = 4, CantidadProducto = 1000 },
                        new MercaderiasDetalle { CodProducto = 5, CantidadProducto = 800 },
                        new MercaderiasDetalle { CodProducto = 6, CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto = 7, CantidadProducto = 400 },
                        new MercaderiasDetalle { CodProducto = 8, CantidadProducto = 600 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 35,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 500 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 36,
                    CuitCliente = "30-87654321-9",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 300 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 37,
                    CuitCliente = "30-12345678-9",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 150 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 100 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 38,
                    CuitCliente = "30-87654321-0",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 50 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 30 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 100 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 39,
                    CuitCliente = "30-11223344-5",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 20 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 10 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 15 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 40,
                    CuitCliente = "30-55667788-9",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 200 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 150 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 300 }
                    }
                },
                new RetiroStock.OrdenPreparacion
                {
                    NroOrdenPrep = 41,
                    CuitCliente = "30-99887766-5",
                    Estado = "Seleccionadas",
                    mercaderiaDetalle = new List<MercaderiasDetalle>
                    {
                        new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 100 },
                        new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 80 },
                        new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 50 }
                    }
                }
            };
        }

        public int OrdenEnPantalla()
        {
            return OrdenPreparacionArchivo.OrdenesPreparacion
                .Where(o => o.Estado == EstadoOrdenPreparacion.Seleccionada)
                .OrderBy(o => o.NroOrdenPrep)
                .Select(o => o.NroOrdenPrep)
                .FirstOrDefault();
        }

        public List<Mercaderia> mercaderia = new()
        {
            new() {CodProducto = 1, DescProducto = "bolsas de cemento"},
            new() {CodProducto = 2, DescProducto = "termos 1lt"},
            new() {CodProducto = 3, DescProducto = "bandejas de madera"},
            new() {CodProducto = 4, DescProducto = "tubos PVC"},
            new() {CodProducto = 5, DescProducto = "sacos de arena"},
            new() {CodProducto = 6, DescProducto = "latas de pintura"},
            new() {CodProducto = 7, DescProducto = "ladrillos"},
            new() {CodProducto = 8, DescProducto = "heladeras"},
        };

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesSeleccionadas()
        {
            var ordenesSeleccionadas = OrdenesPreparacion.Where(o => o.Estado == "Seleccionadas").ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                foreach (var mercaderiaDetalle in orden.mercaderiaDetalle)
                {
                    var descProducto = mercaderia.FirstOrDefault(m => m.CodProducto
                    == mercaderiaDetalle.CodProducto)?.DescProducto;
                    mercaderiaDetalle.DescProducto = descProducto ?? "Descripción no encontrada";
                }
            }
            return ordenesSeleccionadas;
        }

        public void CambiarEstadoOrden(int nroOrdenPrep, string nuevoEstado)
        {
            var orden = OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrdenPrep);
            if (orden != null)
            {
                orden.Estado = nuevoEstado;
            }
        }

        /*public string ObtenerCuitCliente(int nroOrden)
        {
            // Buscar la orden correspondiente al número de orden proporcionado
            var orden = OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == nroOrden);

            // Si se encontró la orden, devolver el CUIT del cliente; de lo contrario, devolver una cadena vacía
            return orden != null ? orden.CuitCliente : "";
        }*/
    }
}
