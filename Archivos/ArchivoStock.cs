using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoStock
    {
        public static ReadOnlyCollection<RetiroStock.Stock> Stocks => stocks.AsReadOnly();

        private static List<RetiroStock.Stock> stocks;

        static ArchivoStock()
        {
            if (File.Exists(@"Datos\Stock.json"))
            {
                var contenido = File.ReadAllText(@"Datos\Stock.json");
                stocks = JsonConvert.DeserializeObject<List<RetiroStock.Stock>>(contenido);
            }
            else
            {
                stocks = new List<RetiroStock.Stock>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(stocks);
            File.WriteAllText(@"Datos\Stock.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

        public static void AgregarStock(RetiroStock.Stock stock)
        {
            stocks.Add(stock);
        }

        public static void CambiarEstado(RetiroStock.Stock stock, string estado)
        {
            stock.Estado = estado;
        }

        public static void EliminarPosicion(RetiroStock.Stock stock)
        {
            stock.Posicion = null;
        }

        public static void CambiarCantidad(RetiroStock.Stock stock, int mercaderiaretirada)
        {
            stock.Cantidad -= mercaderiaretirada; 
        }
    }
}
