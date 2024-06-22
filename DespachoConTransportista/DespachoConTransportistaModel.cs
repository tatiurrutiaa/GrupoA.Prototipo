using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.DespachoSinTransportista;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.DespachoConTransportista
{
    internal class DespachoConTransportistaModel
    {
        public DespachoConTransportistaModel()
        { }
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion = ArchivoOrdenPreparacion.OrdenesPreparacion.ToList();
        public List<Remito> remitos = ArchivoRemito.Remitos.ToList();

        public List<Stock> stock = ArchivoStock.Stocks.ToList();

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "en despacho" && orden.DNITransportista.HasValue).ToList();
        }

        public List<RetiroStock.OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            return ordenesPreparacion.Where(orden => orden.Estado == "en despacho" && orden.DNITransportista == dniTransportista).ToList();
        }
        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = remitos.Any() ? remitos.Max(r => r.NroRemito) + 1 : 1;

            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = ordenesPreparacion
                .FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
            var deposito = primeraOrden.NroDeposito;
            string cuitCliente = primeraOrden.CuitCliente;

            // Crear un nuevo remito
            var nuevoRemito = new Remito
            {
                NroRemito = nuevoNroRemito,
                CuitCliente = cuitCliente,
                Fecha = DateTime.Now,
                DNITransportista = dniTransportista,
                NroOrdenPreparacion = ordenesSeleccionadas,
                NroDeposito = deposito
            };

            //remitos.Add(nuevoRemito);
            ArchivoRemito.AgregarRemito(nuevoRemito);
        }

        public void ActualizarStock(List<int> ordenesSeleccionadas)
        {
            var lista = ArchivoOrdenPreparacion.ObtenerOrdenesPreparacionPorNumero(ordenesSeleccionadas);

            foreach (var orden in lista)
            {
                foreach (var item in orden.mercaderiaDetalle)
                {
                    var stockItem = stock.First(s => s.Posicion == "" && s.CodProducto == item.CodProducto
                    && s.Estado == "retirado" && s.CuitCliente == orden.CuitCliente);
                    if (stockItem.Cantidad == item.CantidadProducto)
                    {
                        ArchivoStock.CambiarEstado(stockItem, "despachado");
                    }
                    else
                    {
                        int cantidadRetirada = item.CantidadProducto;
                        // stockItem.Cantidad -= cantidadRetirada;
                        ArchivoStock.CambiarCantidad(stockItem, cantidadRetirada);

                        var stockRetirado = new Stock
                        {
                            CuitCliente = stockItem.CuitCliente,
                            Posicion = string.Empty,
                            Cantidad = cantidadRetirada,
                            CodProducto = stockItem.CodProducto,
                            Estado = "despachado",
                            NroDeposito = stockItem.NroDeposito
                        };

                        // stock.Add(stockRetirado);
                        ArchivoStock.AgregarStock(stockRetirado);
                    }
                    ArchivoOrdenPreparacion.ModificarEstado(orden, "despachada");
                }
            }
        }
    }
}

