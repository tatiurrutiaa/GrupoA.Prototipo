using GrupoA.Prototipo.RetiroStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.RetiroStock;

internal class RetiroStockModelo
{
    public List<MercaderiaARetirar> MercaderiaARetirar = new()
    {
        new() {Posicion = "12-43-2", Cantidad = 800, Mercaderia = "bolsas de cemento" },
        new() {Posicion = "03-28-5", Cantidad = 200, Mercaderia = "termos 1lt"},
        new() {Posicion = "23-12-1", Cantidad = 50, Mercaderia = "bandejas de madera"},
        new() {Posicion = "07-19-3", Cantidad = 150, Mercaderia = "cajas de clavos" },
        new() {Posicion = "15-22-6", Cantidad = 300, Mercaderia = "latas de pintura" },
        new() {Posicion = "09-07-4", Cantidad = 20, Mercaderia = "rollos de cable" },
        new() {Posicion = "11-34-9", Cantidad = 450, Mercaderia = "tubos de PVC" },
        new() {Posicion = "20-18-2", Cantidad = 100, Mercaderia = "sacos de arena"}
    };

}
