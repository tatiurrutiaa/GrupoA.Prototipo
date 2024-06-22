using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoA.Prototipo.DespachoSinTransportista
{
    internal class DespachoSinTransportistaModel
    {
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion = ArchivoOrdenPreparacion.OrdenesPreparacion.ToList();
        public List<Remito> remitos = ArchivoRemito.Remitos.ToList();
        public List<Stock> stock = ArchivoStock.Stocks.ToList();

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            var ordenes = ordenesPreparacion.Where(o => o.Estado == "en despacho"
            && o.DNITransportista == null).ToList();

            /*if (ordenes == null)
            {
                MessageBox.Show("No hay ordenes de preparación para despachar." +
                    "Por favor, intente nuevamente en unos minutos.");
                return null;
            }
            else
            {
                return ordenes;
            }*/
            return ordenes;
        }

        public void GenerarRemito(int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Obtener el último número de remito y sumarle uno
            int nuevoNroRemito = remitos.Any() ? remitos.Max(r => r.NroRemito) + 1 : 1;

            // Obtener el CUIT del cliente de la primera orden seleccionada
            var primeraOrden = ordenesPreparacion.FirstOrDefault(o => o.NroOrdenPrep == ordenesSeleccionadas.First());
            string cuitCliente = primeraOrden.CuitCliente;
            var deposito = primeraOrden.NroDeposito;

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
                    && s.Estado != "retirado" && s.CuitCliente == orden.CuitCliente);
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