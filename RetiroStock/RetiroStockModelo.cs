using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.RetiroStock;

internal class RetiroStockModelo
{
    public List<int> OrdenesSelecPendientes()
    {
        return OrdenesSeleccionArchivo.Ordenes
            .Where(o => o.Estado == EstadosOrdenSeleccion.EnSeleccion )
            .Select(o => o.NroOrdenSelec)
            .Distinct()
            .ToList();
    }

    public List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)> MercaderiaARetirar(int nroOrden)
    {
        var ordenesPrepAsociadas = OrdenesSeleccionArchivo.Ordenes
            .Where(os => os.NroOrdenSelec == nroOrden)
            .SelectMany(os => os.NroOrdenesPreparacion)
            .Join(
                OrdenesPreparacionArchivo.Ordenes,
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
            var posiciones = StockArchivo.Stocks
                .Where(s => s.CuitCliente == item.CuitCliente
                            && s.CodProducto == item.CodProducto
                            && s.Estado == EstadosStock.Comprometido)
                .OrderBy(s => s.Posicion)
                .ToList();

            var descProducto = MercaderiaArchivo.Mercaderias.First(m => m.Codigo == item.CodProducto).Descripcion;

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
            var stockItem = stock.First(s => s.Posicion == item.Posicion && s.CodProducto == item.CodProducto);
            if (stockItem.Cantidad == item.Cantidad)
            {
                stockItem.Estado = "retirado";
                stockItem.Posicion = string.Empty;
            }
            else
            {
                int cantidadRetirada = item.Cantidad;
                stockItem.Cantidad -= cantidadRetirada;

                var stockRetirado = new Stock
                {
                    CuitCliente = stockItem.CuitCliente,
                    Posicion = string.Empty,
                    Cantidad = cantidadRetirada,
                    CodProducto = stockItem.CodProducto,
                    Estado = "retirado"
                };

                stock.Add(stockRetirado);
            }

            var ordenesSeleccionadas = ordenesSeleccion
                .Where(o => o.NroOrdenSelec == nroOrden)
                .ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                orden.Estado = "seleccionada";
            }

            var ordenesPrepAsociadas = ordenesSeleccion
                .Where(os => os.NroOrdenSelec == nroOrden)
                .SelectMany(os => os.NroOrdenesPreparacion)
                .Join(
                    ordenesPreparacion,
                    nroOrdenPrep => nroOrdenPrep,
                    op => op.NroOrdenPrep,
                    (nroOrdenPrep, op) => op)
                .ToList();

            foreach (var orden in ordenesPrepAsociadas)
            {
                orden.Estado = "seleccionada";
            }

            MessageBox.Show("La mercadería se descontó del almacén con éxito." +
            Environment.NewLine +
            "Por favor, entregar la mercadería al area de preparación.");
            return;
        }
    }
}

