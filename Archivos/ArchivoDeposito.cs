using GrupoA.Prototipo.OrdenPreparacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoDeposito
    {
        public static ReadOnlyCollection<OrdenPreparacion.Deposito> Depositos => depositos.AsReadOnly();

        private static List<OrdenPreparacion.Deposito> depositos;

        static ArchivoDeposito()
        {
            if (File.Exists(@"Deposito.json"))
            {
                var contenido = File.ReadAllText(@"Deposito.json");
                depositos = JsonConvert.DeserializeObject<List<OrdenPreparacion.Deposito>>(contenido);
            }
            else
            {
                depositos = new List<OrdenPreparacion.Deposito>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(depositos);
            File.WriteAllText(@"Deposito.json", contenido);
        }
    }
}
