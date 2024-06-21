using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoRemito
    {
        public static ReadOnlyCollection<DespachoSinTransportista.Remito> Remitos => remitos.AsReadOnly();

        private static List<DespachoSinTransportista.Remito> remitos;

        static ArchivoRemito()
        {
            if (File.Exists(@"Remito.json"))
            {
                var contenido = File.ReadAllText(@"Remito.json");
                remitos = JsonConvert.DeserializeObject<List<DespachoSinTransportista.Remito>>(contenido);
            }
            else
            {
                remitos = new List<DespachoSinTransportista.Remito>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(remitos);
            File.WriteAllText("@Remito.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

        public static void AgregarRemito(DespachoSinTransportista.Remito remito)
        {
            remitos.Add(remito);
        }
    }
}
