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
        public List<RetiroStock.OrdenPreparacion> ordenesPreparacion = new()
        {
        new() {NroOrdenPrep = 15, CuitCliente = "27-41672496-8", DNITransportista = 41672496,  Estado = "preparada"},
        new() {NroOrdenPrep = 16, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 17, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 18, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 19, CuitCliente = "27-41672496-8", DNITransportista = null, Estado = "ingresada"},
        new() {NroOrdenPrep = 20, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 21, CuitCliente = "30-22465788-7", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 22, CuitCliente = "34-56564433-5", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 23, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 24, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"},
        new() {NroOrdenPrep = 25, CuitCliente = "30-23456789-1", DNITransportista = null, Estado = "preparada"}
        };

        public List<RetiroStock.OrdenPreparacion> MercaderiaARetirar()
        {
            var ordenes = ordenesPreparacion.Where(o => o.Estado == "preparada"
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