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
    public List<Stock> stock = new()
    {
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-2", Cantidad = 800, CodProducto = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-3", Cantidad = 500, CodProducto = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-4", Cantidad = 500, CodProducto = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-7", Cantidad = 400, CodProducto = 2, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-8", Cantidad = 200, CodProducto = 2, Estado = "comprometido"},
        new() {CuitCliente = "30-22465788-7", Posicion = "23-12-1", Cantidad = 50, CodProducto = 3, Estado = "comprometido"},
        new() {CuitCliente = "30-22465788-7", Posicion = "07-19-3", Cantidad = 150, CodProducto = 4, Estado = "comprometido"},
        new() {CuitCliente = "34-56564433-5", Posicion = "15-22-6", Cantidad = 300, CodProducto = 5, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "09-07-4", Cantidad = 20, CodProducto = 6, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "11-34-9", Cantidad = 450, CodProducto = 7, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "20-18-2", Cantidad = 100, CodProducto = 8, Estado = "comprometido"}
    };

    public List<OrdenesPreparacion> ordenesPreparacion = new()
    {
        new OrdenesPreparacion
        {
            NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 700 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 300 },
                new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 50 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 36, CuitCliente = "27-41672496-8", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 1, CantidadProducto = 300 },
                new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 50 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 37, CuitCliente = "27-41672496-8", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 200 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 38, CuitCliente = "27-41672496-8", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 2, CantidadProducto = 200 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 39, CuitCliente = "30-22465788-7", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 3, CantidadProducto = 50 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 40, CuitCliente = "30-22465788-7", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 4, CantidadProducto = 150 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 41, CuitCliente = "34-56564433-5", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 5, CantidadProducto = 300 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 42, CuitCliente = "30-23456789-1", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 6, CantidadProducto = 20 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 43, CuitCliente = "30-23456789-1", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 7, CantidadProducto = 450 }
            }
        },
        new OrdenesPreparacion
        {
            NroOrdenPrep = 44, CuitCliente = "30-23456789-1", Estado = "en seleccion",
            Mercaderias = new List<MercaderiasDetalle>
            {
                new MercaderiasDetalle { CodProducto = 8, CantidadProducto = 100 }
            }
        }
    };

    List<OrdenesSeleccion> ordenesSeleccion = new()
    {
            new()
            {
                NroOrdenSelec = 200,
                NroOrdenesPreparacion = new List<int> { 34, 35, 36 },
                Estado = "en seleccion"
            },
            new()
            {
                NroOrdenSelec = 201,
                NroOrdenesPreparacion = new List<int> { 37, 38, 39 },
                Estado = "en seleccion"
            },
            new()
            {
                NroOrdenSelec = 202,
                NroOrdenesPreparacion = new List<int> { 40, 41, 42 },
                Estado = "en seleccion"
            },
            new()
            {
                NroOrdenSelec = 203,
                NroOrdenesPreparacion = new List<int> { 43, 44 },
                Estado = "en seleccion"
            }
    };

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

    public List<int> OrdenesSelecPendientes()
    {
        return ordenesSeleccion
            .Where(o => o.Estado == "en seleccion")
            .Select(o => o.NroOrdenSelec)
            .Distinct()
            .ToList();
    }

    public List<(string Posicion, int Cantidad, int CodProducto, string DescProducto)> MercaderiaARetirar(int nroOrden)
    {
        var ordenesPrepAsociadas = ordenesSeleccion
            .Where(os => os.NroOrdenSelec == nroOrden)
            .SelectMany(os => os.NroOrdenesPreparacion)
            .Join(
                ordenesPreparacion,
                nroOrdenPrep => nroOrdenPrep,
                op => op.NroOrdenPrep,
                (nroOrdenPrep, op) => op)
            .ToList();

        var mercaderiaAgrupada = ordenesPrepAsociadas
            .SelectMany(o => o.Mercaderias, (o, m) => new { o.CuitCliente, m.CodProducto, m.CantidadProducto })
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
            var posiciones = stock
                .Where(s => s.CuitCliente == item.CuitCliente
                            && s.CodProducto == item.CodProducto
                            && s.Estado == "comprometido")
                .OrderBy(s => s.Posicion)
                .ToList();

            var descProducto = mercaderia.First(m => m.CodProducto == item.CodProducto).DescProducto;

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

