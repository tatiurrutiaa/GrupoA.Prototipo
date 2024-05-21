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
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-2", Cantidad = 500, Mercaderia = "bolsas de cemento" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-3", Cantidad = 500, Mercaderia = "bolsas de cemento" },
        new() {CuitCliente = "27-41672496-8", Posicion = "12-43-4", Cantidad = 500, Mercaderia = "bolsas de cemento" },
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-7", Cantidad = 400, Mercaderia = "termos 1lt"},
        new() {CuitCliente = "27-41672496-8", Posicion = "03-28-8", Cantidad = 200, Mercaderia = "termos 1lt"},
        new() {CuitCliente = "30-22465788-7", Posicion = "23-12-1", Cantidad = 50, Mercaderia = "bandejas de madera"},
        new() {CuitCliente = "30-22465788-7", Posicion = "07-19-3", Cantidad = 150, Mercaderia = "cajas de clavos" },
        new() {CuitCliente = "34-56564433-5", Posicion = "15-22-6", Cantidad = 300, Mercaderia = "latas de pintura" },
        new() {CuitCliente = "30-23456789-1", Posicion = "09-07-4", Cantidad = 20, Mercaderia = "rollos de cable" },
        new() {CuitCliente = "30-23456789-1", Posicion = "11-34-9", Cantidad = 450, Mercaderia = "tubos de PVC" },
        new() {CuitCliente = "30-23456789-1", Posicion = "20-18-2", Cantidad = 100, Mercaderia = "sacos de arena"}
    };

    public List<OrdenesPreparacion> ordenesPreparacion = new()
    {
        new() {NroOrdenPrep = 34, CuitCliente = "27-41672496-8", Cantidad = 700, Mercaderia = "bolsas de cemento", Estado = "en seleccion"},
        new() {NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Cantidad = 300, Mercaderia = "bolsas de cemento", Estado = "en seleccion"},
        new() {NroOrdenPrep = 35, CuitCliente = "27-41672496-8", Cantidad = 50, Mercaderia = "termos 1lt", Estado = "en seleccion"},
        new() {NroOrdenPrep = 37, CuitCliente = "27-41672496-8", Cantidad = 200, Mercaderia = "termos 1lt", Estado = "en seleccion"},
        new() {NroOrdenPrep = 38, CuitCliente = "27-41672496-8", Cantidad = 200, Mercaderia = "termos 1lt", Estado = "en seleccion"},
        new() {NroOrdenPrep = 39, CuitCliente = "30-22465788-7", Cantidad = 50, Mercaderia = "bandejas de madera", Estado = "en seleccion"},
        new() {NroOrdenPrep = 40, CuitCliente = "30-22465788-7", Cantidad = 150, Mercaderia = "cajas de clavos" , Estado = "en seleccion"},
        new() {NroOrdenPrep = 41, CuitCliente = "34-56564433-5", Cantidad = 300, Mercaderia = "latas de pintura" , Estado = "en seleccion"},
        new() {NroOrdenPrep = 42, CuitCliente = "30-23456789-1", Cantidad = 20, Mercaderia = "rollos de cable" , Estado = "en seleccion"},
        new() {NroOrdenPrep = 43, CuitCliente = "30-23456789-1", Cantidad = 450, Mercaderia = "tubos de PVC" , Estado = "en seleccion"},
        new() {NroOrdenPrep = 44, CuitCliente = "30-23456789-1", Cantidad = 100, Mercaderia = "sacos de arena", Estado = "en seleccion"}
    };

    public List<OrdenesSeleccion> ordenesSeleccion = new()
    {
        new() {NroOrdenSelec = 200, NroOrdenPrep = 34, Estado = "seleccionada"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 35, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 36, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 37, Estado = "en seleccion"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 38, Estado = "en seleccion"},
        new() {NroOrdenSelec = 201, NroOrdenPrep = 39, Estado = "seleccionada"},
        new() {NroOrdenSelec = 201, NroOrdenPrep = 40, Estado = "seleccionada"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 41, Estado = "seleccionada"},
        new() {NroOrdenSelec = 200, NroOrdenPrep = 42, Estado = "en seleccion"},
        new() {NroOrdenSelec = 202, NroOrdenPrep = 43, Estado = "en seleccion"},
        new() {NroOrdenSelec = 202, NroOrdenPrep = 44, Estado = "en seleccion"} 
    }; 

    public List<(string Posicion, int Cantidad, string Mercaderia)> MercaderiaARetirar()
    {
        // Buscar la orden de seleccion más vieja (la menor) en estado "en seleccion"
        var menorOrdenSeleccion = ordenesSeleccion
            .Where(o => o.Estado == "en seleccion")
            .OrderBy(o => o.NroOrdenSelec)
            .FirstOrDefault();

        if (menorOrdenSeleccion == null)
        {
            MessageBox.Show("No hay Ordenes de selección pendientes. Por favor, intente nuevamente en unos minutos.");
        }

        // Buscar las ordenes de preparacion asociadas a la orden de selección más vieja
        var ordenesPrepAsociadas = ordenesPreparacion
            .Where(o => (ordenesSeleccion.Where(o => o.Estado == "en seleccion"))
            .Any(os => os.NroOrdenSelec == menorOrdenSeleccion.NroOrdenSelec && os.NroOrdenPrep == o.NroOrdenPrep))
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

        // Buscar la posicion de donde retirar la mercadería por CUIT cliente y mercadería
        var resultado = new List<(string Posicion, int Cantidad, string Mercaderia)>();

        foreach (var item in mercaderiaAgrupada)
        {
            var cantidadRequerida = item.CantidadTotal;
            var posiciones = stock
                .Where(s => s.CuitCliente == item.CuitCliente && s.Mercaderia == item.Mercaderia)
                .OrderBy(s => s.Posicion)
                .ToList();

            //Buscar posiciones hasta alcanzar la cantidad requerida
            foreach (var pos in posiciones)
            {
                if (cantidadRequerida <= 0)
                {
                    break;
                }

                // Buscar cuanto retirar de mercadería por cada posición
                var cantidadARetirar = Math.Min(pos.Cantidad, cantidadRequerida);
                resultado.Add((pos.Posicion, cantidadARetirar, item.Mercaderia));
                cantidadRequerida -= cantidadARetirar;
            }
        }

        return resultado;
    }

    public void DescontarStockYActualizarOrden()
    {
        // Buscar la menor orden seleccion en estado "en seleccion"
        var menorOrdenSeleccion = ordenesSeleccion
            .Where(o => o.Estado == "en seleccion")
            .OrderBy(o => o.NroOrdenSelec)
            .FirstOrDefault();

        if (menorOrdenSeleccion == null)
        {
            MessageBox.Show("No hay Ordenes de selección pendientes. Por favor, intente nuevamente en unos minutos.");
        }

        // Obtener la lista de posiciones, cantidades y mercaderías
        var listaParaOrden = MercaderiaARetirar();

        // Descontar el stock
        foreach (var item in listaParaOrden)
        {
            var stockItem = stock.First(s => s.Posicion == item.Posicion && s.Mercaderia == item.Mercaderia);
            stockItem.Cantidad -= item.Cantidad;
        }

        // Actualizar el estado de la orden de seleccion de "en seleccion" a "seleccionada"
        var ordenesSeleccionadas = ordenesSeleccion
            .Where(o => o.NroOrdenSelec == menorOrdenSeleccion.NroOrdenSelec)
            .ToList();

        foreach (var orden in ordenesSeleccionadas)
        {
            orden.Estado = "seleccionada";
        }
    }
}

