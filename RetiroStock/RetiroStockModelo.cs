using GrupoA.Prototipo.Archivos;
using GrupoA.Prototipo.EmpaquetarMercaderia;
using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.RetiroStock;

internal class RetiroStockModelo
{
    public List<Stock> stock = ArchivoStock.Stocks.ToList();
    public List<OrdenPreparacion> ordenesPreparacion = ArchivoOrdenPreparacion.OrdenesPreparacion.ToList();
    public List<OrdenSeleccion> ordenesSeleccion = ArchivoOrdenSeleccion.OrdenesSeleccion.ToList();
    public List<Mercaderia> mercaderia = ArchivoMercaderia.Mercaderias.ToList();

    public List<int> OrdenesSelecPendientes()
    {
        return ArchivoOrdenSeleccion.OrdenesSeleccion
            .Where(o => o.Estado == "en seleccion")
            .Select(o => o.NroOrdenSelec)
            .Distinct()
            .ToList();
    }

    public List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)> MercaderiaARetirar(int nroOrden)
    {
        var ordenesPrepAsociadas = ArchivoOrdenSeleccion.OrdenesSeleccion
            .Where(os => os.NroOrdenSelec == nroOrden)
            .SelectMany(os => os.NroOrdenesPreparacion)
            .Join(
                ordenesPreparacion,
                nroOrdenPrep => nroOrdenPrep,
                op => op.NroOrdenPrep,
                (nroOrdenPrep, op) => op)
            .ToList();

        //MessageBox.Show(($"Ordenes de preparación asociadas: {ordenesPrepAsociadas.Count}"));

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

        //MessageBox.Show($"Mercaderia agrupada: {mercaderiaAgrupada.Count}");

        var resultado = new List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)>();

        foreach (var item in mercaderiaAgrupada)
        {
            var cantidadRequerida = item.CantidadTotal;
            var posiciones = ArchivoStock.Stocks
                .Where(s => s.CuitCliente == item.CuitCliente
                            && s.CodProducto == item.CodProducto
                            && s.Estado == "comprometido")
                .OrderBy(s => s.Posicion)
                .ToList();

            //var descProducto = mercaderia.First(m => m.CodProducto == item.CodProducto).DescProducto;
            var descProducto = ArchivoMercaderia.BuscarDescripcion(item.CodProducto);

            //MessageBox.Show($"Posiciones encontradas para {item.CodProducto}: {posiciones.Count}");
            //MessageBox.Show($"Descripción del producto {item.CodProducto}: {descProducto}");

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

        //MessageBox.Show($"Resultado final: {resultado.Count} elementos");

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
                ArchivoStock.CambiarEstado(stockItem, "retirado");
                ArchivoStock.EliminarPosicion(stockItem);
            }
            else
            {
                int cantidadRetirada = item.Cantidad;
                //stockItem.Cantidad -= cantidadRetirada;
                ArchivoStock.CambiarCantidad(stockItem, cantidadRetirada);

                var stockRetirado = new Stock
                {
                    CuitCliente = stockItem.CuitCliente,
                    Posicion = string.Empty,
                    Cantidad = cantidadRetirada,
                    CodProducto = stockItem.CodProducto,
                    Estado = "retirado",
                    NroDeposito = stockItem.NroDeposito
                };

                //stock.Add(stockRetirado);
                ArchivoStock.AgregarStock(stockRetirado);
            }

            var ordenesSeleccionadas = ordenesSeleccion
                .Where(o => o.NroOrdenSelec == nroOrden)
                .ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                //orden.Estado = "seleccionada";
                ArchivoOrdenSeleccion.ModificarEstado(orden, "seleccionada");
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
                //orden.Estado = "seleccionada";
                ArchivoOrdenPreparacion.ModificarEstado(orden, "seleccionada");
            }

            MessageBox.Show("La mercadería se descontó del almacén con éxito." +
            Environment.NewLine +
            "Por favor, entregar la mercadería al area de preparación.");
            return;
        }
    }
}

