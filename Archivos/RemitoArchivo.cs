using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    internal class RemitoArchivo
    {
        public static ReadOnlyCollection<RemitoEntidad> Remitos => remitos.AsReadOnly();

        private static List<RemitoEntidad> remitos;

        static RemitoArchivo()
        {
            if (File.Exists(@"Datos\Remito.json"))
            {
                var contenido = File.ReadAllText(@"Datos\Remito.json");
                remitos = JsonConvert.DeserializeObject<List<RemitoEntidad>>(contenido);
            }
            else
            {
                remitos = new List<RemitoEntidad>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(remitos);
            File.WriteAllText(@"Datos\Remito.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

        public static void AgregarRemito(RemitoEntidad remito)
        {
            remitos.Add(remito);
        }
    }
}
