using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.DespachoConTransportista
{
    internal class DespachoConTransportistaModel
    {
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion { get; set;}

        public DespachoConTransportistaModel()
        {
            ordenesPreparacion = new List<RetiroStock.OrdenPreparacion>
            {
                new() { NroOrdenPrep = 30, CuitCliente = "27-41672496-8", DNITransportista = 30000100, Estado = "preparada" },
                new() { NroOrdenPrep = 31, CuitCliente = "27-41672496-8", DNITransportista = 30100200, Estado = "preparada" },
                new() { NroOrdenPrep = 32, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "preparada" },
                new() { NroOrdenPrep = 33, CuitCliente = "27-41672496-8", DNITransportista = 30200300, Estado = "preparada" },
                new() { NroOrdenPrep = 34, CuitCliente = "27-41672496-8", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 35, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 36, CuitCliente = "30-22465788-7", DNITransportista = 30400500, Estado = "preparada" },
                new() { NroOrdenPrep = 37, CuitCliente = "34-56564433-5", DNITransportista = 35101021, Estado = "preparada" },
                new() { NroOrdenPrep = 38, CuitCliente = "30-23456789-1", DNITransportista = 40900745, Estado = "preparada" },
                new() { NroOrdenPrep = 39, CuitCliente = "30-23456789-1", DNITransportista = 40504002, Estado = "preparada" },
                new() { NroOrdenPrep = 40, CuitCliente = "30-23456789-1", DNITransportista = 37568798, Estado = "preparada" }
            };
        }

        public List<Archi> MercaderiaARetirar()
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista.HasValue).ToList();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "preparada" && orden.DNITransportista == dniTransportista).ToList();
        }

        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = RemitoArchivo.Remitos.Any() ? RemitoArchivo.Remitos.Max(r => r.NroRemito) + 1 : 1;
            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
            string cuitCliente = primeraOrden.CuitCliente;
            var deposito = primeraOrden.NroDeposito;
            // Crear un nuevo remito
            var nuevoRemito = new RemitoEntidad
            {
                NroRemito = nuevoNroRemito,
                CuitCliente = cuitCliente,
                Fecha = DateTime.Now,
                DNITransportista = dniTransportista,
                NroOrdenPreparacion = ordenesSeleccionadas,
                NroDeposito = deposito
            };

            RemitoArchivo.AgregarRemito(nuevoRemito);
        }
        public void ActualizarStock(List<int> ordenesSeleccionadas)
        {
            var lista = OrdenPreparacionArchivo.ObtenerOrdenesPreparacionPorNumero(ordenesSeleccionadas);

            foreach (var orden in lista)
            {
                foreach (var item in orden.mercaderiaDetalle)
                {
                    var stockItem = StockArchivo.Stocks.First(s => s.Posicion == "" && s.CodProducto == item.CodProducto
                    && s.Estado == EstadosStock.Retirado && s.CuitCliente == orden.CuitCliente);
                    if (stockItem.Cantidad == item.CantidadProducto)
                    {
                        StockArchivo.CambiarEstado(stockItem, EstadosStock.Despachado);
                    }
                    else
                    {
                        int cantidadRetirada = item.CantidadProducto;
                        // stockItem.Cantidad -= cantidadRetirada;
                        StockArchivo.CambiarCantidad(stockItem, cantidadRetirada);

                        var stockRetirado = new StockEntidad
                        {
                            CuitCliente = stockItem.CuitCliente,
                            Posicion = string.Empty,
                            Cantidad = cantidadRetirada,
                            CodProducto = stockItem.CodProducto,
                            Estado = EstadosStock.Despachado,
                            NroDeposito = stockItem.NroDeposito
                        };

                        // stock.Add(stockRetirado);
                        StockArchivo.AgregarStock(stockRetirado);
                    }
                    OrdenPreparacionArchivo.ModificarEstado(orden, EstadoOrdenPreparacion.Despachada);
                }
            }
        }
    }
}
