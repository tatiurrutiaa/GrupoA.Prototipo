using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoMercaderia
    {
        public static ReadOnlyCollection<RetiroStock.Mercaderia> Mercaderias => mercaderias.AsReadOnly();

        private static List<RetiroStock.Mercaderia> mercaderias;

        static ArchivoMercaderia()
        {
            if (File.Exists(@"Datos\Mercaderia.json"))
            {
                var contenido = File.ReadAllText(@"Datos\Mercaderia.json");
                mercaderias = JsonConvert.DeserializeObject<List<RetiroStock.Mercaderia>>(contenido);
            }
            else
            {
                mercaderias = new List<RetiroStock.Mercaderia>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(mercaderias);
            File.WriteAllText(@"Datos\Mercaderia.json", contenido);
        }
    }
}
