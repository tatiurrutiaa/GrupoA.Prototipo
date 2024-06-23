using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Stock;
using GrupoA.Prototipo.Forms.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.DespachoConTransportista.Model
{
    internal class DespachoConTransportistaModel
    {
        public List<OrdenPreparacion> MercaderiaARetirar()
        {
            var ordenes = new List<OrdenPreparacion>();
            foreach (var OrdenPreparacionEntidad in OrdenPreparacionArchivo.OrdenesPreparacion
                      .Where(o => o.Estado == EstadosOrdenPreparacion.EnDespacho
                      && o.DNITransportista != null).ToList())
            {
                var orden = new OrdenPreparacion();
                orden.NroOrdenPrep = OrdenPreparacionEntidad.NroOrdenPrep;
                orden.CuitCliente = OrdenPreparacionEntidad.CuitCliente;
                orden.Estado = OrdenPreparacionEntidad.Estado;
                orden.Fecha = OrdenPreparacionEntidad.Fecha;
                orden.DNITransportista = OrdenPreparacionEntidad.DNITransportista;
                orden.NroDeposito = OrdenPreparacionEntidad.NroDeposito;
                orden.mercaderiaDetalle = OrdenPreparacionEntidad.mercaderiaDetalle;

                ordenes.Add(orden);
            }
            return ordenes;
        }

        public List<OrdenPreparacion> ObtenerOrdenesPorDNI(int dniTransportista)
        {
            var ordenes = new List<OrdenPreparacion>();
            foreach (var OrdenPreparacionEntidad in OrdenPreparacionArchivo.OrdenesPreparacion
                      .Where(o => o.Estado == EstadosOrdenPreparacion.EnDespacho
                      && o.DNITransportista == dniTransportista).ToList())
            {
                var orden = new OrdenPreparacion();
                orden.NroOrdenPrep = OrdenPreparacionEntidad.NroOrdenPrep;
                orden.CuitCliente = OrdenPreparacionEntidad.CuitCliente;
                orden.Estado = OrdenPreparacionEntidad.Estado;
                orden.Fecha = OrdenPreparacionEntidad.Fecha;
                orden.DNITransportista = OrdenPreparacionEntidad.DNITransportista;
                orden.NroDeposito = OrdenPreparacionEntidad.NroDeposito;
                orden.mercaderiaDetalle = OrdenPreparacionEntidad.mercaderiaDetalle;

                ordenes.Add(orden);
            }
            return ordenes;
        }

        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = RemitoArchivo.Remitos.Any() ? RemitoArchivo.Remitos.Max(r => r.NroRemito) + 1 : 1;
            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = OrdenPreparacionArchivo.OrdenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
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
                    var stockItem = StockArchivo.Stocks.FirstOrDefault(s => s.Posicion == "" && s.CodProducto == item.CodProducto && s.Estado == EstadosStock.Retirado && s.CuitCliente == orden.CuitCliente);
                    if (stockItem != null)
                    {
                        StockArchivo.Stocks.FirstOrDefault(s => s.Posicion == "" && s.CodProducto == item.CodProducto && s.Estado == EstadosStock.Retirado && s.CuitCliente == orden.CuitCliente);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el stock");
                    }
                    if (stockItem != null)
                    {
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
                    }
                }
            }
        }
        public void ActualizarEstadoOrdenes(int nroorden)
        {
            var orden = OrdenPreparacionArchivo.OrdenesPreparacion
                    .FirstOrDefault(o => o.NroOrdenPrep == nroorden);
            if (orden != null)
            {
                OrdenPreparacionArchivo.ModificarEstado(orden, EstadosOrdenPreparacion.Despachada);
            }
        }
    }
}
