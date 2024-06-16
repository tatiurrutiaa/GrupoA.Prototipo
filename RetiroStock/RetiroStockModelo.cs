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
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-2", Cantidad = 500, Mercaderia = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-3", Cantidad = 500, Mercaderia = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-4", Cantidad = 500, Mercaderia = 1, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-7", Cantidad = 400, Mercaderia = 2, Estado = "comprometido" },
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-8", Cantidad = 200, Mercaderia = 2, Estado = "comprometido"},
        new() {CuitCliente = "30-22465788-7", Posicion = "23-12-1", Cantidad = 50, Mercaderia = 3, Estado = "comprometido"},
        new() {CuitCliente = "30-22465788-7", Posicion = "07-19-3", Cantidad = 150, Mercaderia = 4, Estado = "comprometido"},
        new() {CuitCliente = "34-56564433-5", Posicion = "15-22-6", Cantidad = 300, Mercaderia = 5, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "09-07-4", Cantidad = 20, Mercaderia = 6, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "11-34-9", Cantidad = 450, Mercaderia = 7, Estado = "comprometido"},
        new() {CuitCliente = "30-23456789-1", Posicion = "20-18-2", Cantidad = 100, Mercaderia = 8, Estado = "comprometido"}
    };

    public List<OrdenesPreparacion> ordenesPreparacion = new()
    {
        new() {NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = 1, Estado = "en seleccion"},
        new() {NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Cantidad = 300, Mercaderia = 1, Estado = "en seleccion"},
        new() {NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Cantidad = 50, Mercaderia = 2, Estado = "en seleccion"},
        new() {NroOrdenPrep = 37, CuitCliente = "27-41672496-8", Cantidad = 200, Mercaderia = 2, Estado = "en seleccion"},
        new() {NroOrdenPrep = 38, CuitCliente = "27-41672496-8", Cantidad = 200, Mercaderia = 2, Estado = "en seleccion"},
        new() {NroOrdenPrep = 39, CuitCliente = "30-22465788-7", Cantidad = 50, Mercaderia = 3, Estado = "en seleccion"},
        new() {NroOrdenPrep = 40, CuitCliente = "30-22465788-7", Cantidad = 150, Mercaderia = 4 , Estado = "en seleccion"},
        new() {NroOrdenPrep = 41, CuitCliente = "34-56564433-5", Cantidad = 300, Mercaderia = 5 , Estado = "en seleccion"},
        new() {NroOrdenPrep = 42, CuitCliente = "30-23456789-1", Cantidad = 20, Mercaderia = 6 , Estado = "en seleccion"},
        new() {NroOrdenPrep = 43, CuitCliente = "30-23456789-1", Cantidad = 450, Mercaderia = 7 , Estado = "en seleccion"},
        new() {NroOrdenPrep = 44, CuitCliente = "30-23456789-1", Cantidad = 100, Mercaderia = 8, Estado = "en seleccion"}
    };

    public List<OrdenesSeleccion> ordenesSeleccion = new()
    {
        new() {NroOrdenSelec = 200, NroOrdenPrep = 34, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 35, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 36, Estado = "en seleccion"},
        new() {NroOrdenSelec = 201, NroOrdenPrep = 37, Estado = "seleccionada"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 38, Estado = "en seleccion"},
        new() {NroOrdenSelec = 201, NroOrdenPrep = 39, Estado = "seleccionada"},
        new() {NroOrdenSelec = 201, NroOrdenPrep = 40, Estado = "seleccionada"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 41, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 42, Estado = "en seleccion"},
        new() {NroOrdenSelec = 202, NroOrdenPrep = 43, Estado = "en seleccion"},
        new() {NroOrdenSelec = 202, NroOrdenPrep = 44, Estado = "seleccionada"}
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

    public List<(string Posicion, int Cantidad, int Mercaderia, string DescProducto)> MercaderiaARetirar(int nroOrden)
    {
        // Buscar las ordenes de preparacion asociadas a la orden de selección
        var ordenesPrepAsociadas = ordenesPreparacion
            .Where(o => ordenesSeleccion
            .Any(os => os.NroOrdenSelec == nroOrden
            && os.NroOrdenPrep == o.NroOrdenPrep))
            .ToList();

        // Unificar la cantidad y mercaderia de todas las ordenes de preparación en la orden de selección
        var mercaderiaAgrupada = ordenesPrepAsociadas
            .GroupBy(o => new { o.CuitCliente, o.Mercaderia })
            .Select(g => new
            {
                g.Key.CuitCliente,
                g.Key.Mercaderia,
                CantidadTotal = g.Sum(o => o.Cantidad)
            })
            .ToList();

        // Buscar la posición y descripción del producto de donde retirar la mercadería por CUIT cliente y mercadería en estado comprometida
        var resultado = new List<(string Posicion, int Cantidad, int Mercaderia, string DescProducto)>();

        foreach (var item in mercaderiaAgrupada)
        {
            var cantidadRequerida = item.CantidadTotal;
            var posiciones = stock
                .Where(s => s.CuitCliente == item.CuitCliente && s.Mercaderia == item.Mercaderia
                && s.Estado == "comprometido")
                .OrderBy(s => s.Posicion)
                .ToList();

            var descProducto = mercaderia.First(m => m.CodProducto == item.Mercaderia).DescProducto;

            //Buscar posiciones hasta alcanzar la cantidad requerida
            foreach (var pos in posiciones)
            {
                if (cantidadRequerida <= 0)
                {
                    break;
                }

                // Buscar cuanto retirar de mercadería por cada posición
                var cantidadARetirar = Math.Min(pos.Cantidad, cantidadRequerida);
                resultado.Add((pos.Posicion, cantidadARetirar, item.Mercaderia, descProducto));
                cantidadRequerida -= cantidadARetirar;
            }
        }
        return resultado;
    }

    public void ActualizarStockYOrden(int nroOrden)
    {
        // Obtener la lista de posiciones, cantidades y mercaderías
        var listaParaOrden = MercaderiaARetirar(nroOrden);

        // "Descontar" stock: 
        foreach (var item in listaParaOrden)
        {
            //cuando retiramos todo el stock de una posición
            var stockItem = stock.First(s => s.Posicion == item.Posicion && s.Mercaderia == item.Mercaderia);
            if (stockItem.Cantidad == item.Cantidad)
            {
                stockItem.Estado = "retirado"; //cambia estado de la posición a retirado
                stockItem.Posicion = string.Empty; // Vaciar la posición
            }
            else //cuando el retiro es parcial
            {
                //descuenta la mercadería retirada de la posición
                int cantidadRetirada = item.Cantidad;
                stockItem.Cantidad -= cantidadRetirada;

                // Crea una nueva fila para el stock retirado, sin posición y en estado "retirado"
                var stockRetirado = new Stock
                {
                    CuitCliente = stockItem.CuitCliente,
                    Posicion = string.Empty, // Vaciar la posición
                    Cantidad = cantidadRetirada,
                    Mercaderia = stockItem.Mercaderia,
                    Estado = "retirado"
                };

                stock.Add(stockRetirado);
            }

            // Actualizar el estado de la orden de seleccion a "seleccionada"
            var ordenesSeleccionadas = ordenesSeleccion
            .Where(o => o.NroOrdenSelec == nroOrden)
            .ToList();

            foreach (var orden in ordenesSeleccionadas)
            {
                orden.Estado = "seleccionada";
            }

            // Actualizar el estado de las ordenes de preparación a "seleccionada"
            var ordenesPrepAsociadas = ordenesPreparacion
                .Where(o => ordenesSeleccion
                .Any(os => os.NroOrdenSelec == nroOrden
                && os.NroOrdenPrep == o.NroOrdenPrep))
                .ToList();

            foreach (var orden in ordenesPrepAsociadas)
            {
                orden.Estado = "seleccionada";
            }

            //Mensaje de éxito
            MessageBox.Show("La mercadería se descontó del almacén con éxito." +
            Environment.NewLine +
            "Por favor, entregar la mercadería al area de preparación.");
            return;
        }
    }
}

