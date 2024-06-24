using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.Archivos.Estados;
using GrupoA.Prototipo.Archivos.Mercaderias;
using GrupoA.Prototipo.Archivos.Ordenes.OrdenSeleccion;
using GrupoA.Prototipo.Archivos.Stock;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Forms.RetiroStock.Model;

internal class RetiroStockModelo
{
    public List<int> OrdenesSelecPendientes()
    {
        return OrdenSeleccionArchivo.OrdenesSeleccion
            .Where(o => o.Estado == EstadosOrdenSeleccion.EnSeleccion)
            .Select(o => o.NroOrdenSelec)
            .Distinct()
            .ToList();
    }

    public List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)> MercaderiaARetirar(int nroOrden)
    {
        var ordenesPrepAsociadas = OrdenSeleccionArchivo.OrdenesSeleccion
            .Where(os => os.NroOrdenSelec == nroOrden)
            .SelectMany(os => os.NroOrdenesPreparacion)
            .Join(
                OrdenPreparacionArchivo.OrdenesPreparacion,
                nroOrdenPrep => nroOrdenPrep,
                op => op.NroOrdenPrep,
                (nroOrdenPrep, op) => op)
            .ToList();

        var mercaderiaAgrupada = ordenesPrepAsociadas
            .SelectMany(o => o.mercaderiaDetalle, (o, m) => new { o.CuitCliente, m.CodProducto, m.CantidadProducto })
            .GroupBy(x => new { x.CuitCliente, x.CodProducto })
            .Select(g => new
            {
                g.Key.CuitCliente,
                g.Key.CodProducto,
                CantidadTotal = g.Sum(x => x.CantidadProducto)
            })
            .ToList();

        var resultado = new List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)>();

        foreach (var item in mercaderiaAgrupada)
        {
            var cantidadRequerida = item.CantidadTotal;
            int deposito = ordenesPrepAsociadas.First().NroDeposito;
            var posiciones = StockArchivo.Stocks
                .Where(s => s.CuitCliente == item.CuitCliente
                            && s.NroDeposito == deposito
                            && s.CodProducto == item.CodProducto
                            && s.Estado == EstadosStock.Comprometido)
                .OrderBy(s => s.Posicion)
                .ToList();

            var descProducto = MercaderiaArchivo.Mercaderias.First(m => m.CodProducto == item.CodProducto).DescProducto;

            foreach (var pos in posiciones)
            {
                if (cantidadRequerida <= 0)
                {
                    break;
                }

                var cantidadARetirar = Math.Min(pos.Cantidad, cantidadRequerida);
                resultado.Add((pos.Posicion, cantidadARetirar, item.CodProducto, descProducto));
                cantidadRequerida -= cantidadARetirar;
            }
        }
        return resultado;
    }

    public void ActualizarStockYOrden(int nroOrden)
    {
        var listaParaOrden = MercaderiaARetirar(nroOrden);

        foreach (var item in listaParaOrden)
        {
            var stockItem = StockArchivo.Stocks.First(s => s.Posicion == item.Posicion && s.CodProducto == item.CodProducto);
            if (stockItem.Cantidad == item.Cantidad)
            {
                StockArchivo.CambiarEstado(stockItem, EstadosStock.Retirado);
                StockArchivo.EliminarPosicion(stockItem);
                //stockItem.Estado = EstadosStock.Retirado;
                //stockItem.Posicion = string.Empty;
            }
            else
            {
                int cantidadRetirada = item.Cantidad;
                StockArchivo.CambiarCantidad(stockItem, cantidadRetirada);
                //stockItem.Cantidad -= cantidadRetirada;

                var stockRetirado = new StockEntidad
                {
                    CuitCliente = stockItem.CuitCliente,
                    Posicion = string.Empty,
                    Cantidad = cantidadRetirada,
                    CodProducto = stockItem.CodProducto,
                    Estado = EstadosStock.Retirado
                };

                StockArchivo.AgregarStock(stockRetirado);
            }

            var ordenesSeleccionadas = OrdenSeleccionArchivo.OrdenesSeleccion
                .Where(o => o.NroOrdenSelec == nroOrden)
                .ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                OrdenSeleccionArchivo.ModificarEstado(orden, EstadosOrdenSeleccion.Seleccionada);
            }

            var ordenesPrepAsociadas = OrdenSeleccionArchivo.OrdenesSeleccion
                .Where(os => os.NroOrdenSelec == nroOrden)
                .SelectMany(os => os.NroOrdenesPreparacion)
                .Join(
                    OrdenPreparacionArchivo.OrdenesPreparacion,
                    nroOrdenPrep => nroOrdenPrep,
                    op => op.NroOrdenPrep,
                    (nroOrdenPrep, op) => op)
                .ToList();

            foreach (var orden in ordenesPrepAsociadas)
            {
                OrdenPreparacionArchivo.ModificarEstado(orden, EstadosOrdenPreparacion.Seleccionada);
            }

            MessageBox.Show("La mercadería se descontó del almacén con éxito." +
            Environment.NewLine +
            "Por favor, entregar la mercadería al area de preparación.");
            return;
        }
    }
}

