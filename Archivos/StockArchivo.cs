using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class StockArchivo
{
    public static ReadOnlyCollection<StockEntidad> Stocks => stocks.AsReadOnly();

    private static List<StockEntidad> stocks;

    static StockArchivo()
    {
        if (File.Exists(@"Datos\Stock.json"))
        {
            var contenido = File.ReadAllText(@"Datos\Stock.json");
            stocks = JsonConvert.DeserializeObject<List<StockEntidad>>(contenido);
        }
        else
        {
            stocks = new List<StockEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stocks);
        File.WriteAllText(@"Datos\Stock.json", contenido);
    }

    public static void AgregarStock(StockEntidad stock)
    {
        stocks.Add(stock);
    }
    public static void CambiarEstado(StockEntidad stock, EstadosStock estado)
    {
        stock.Estado = estado;
    }

    public static void EliminarPosicion(StockEntidad stock)
    {
        stock.Posicion = null;
    }

    public static void CambiarCantidad(StockEntidad stock, int mercaderiaretirada)
    {
        stock.Cantidad -= mercaderiaretirada;
    }
}
