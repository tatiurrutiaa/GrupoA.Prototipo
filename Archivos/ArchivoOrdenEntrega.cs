using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoOrdenEntrega
    {
        public static ReadOnlyCollection<OrdenEntrega.OrdenEntrega> OrdenesEntrega => ordenesentrega.AsReadOnly();

        private static List<OrdenEntrega.OrdenEntrega> ordenesentrega;

        static ArchivoOrdenEntrega()
        {
            if (File.Exists(@"Datos\OrdenEntrega.json"))
            {
                var contenido = File.ReadAllText(@"Datos\OrdenEntrega.json");
                ordenesentrega = JsonConvert.DeserializeObject<List<OrdenEntrega.OrdenEntrega>>(contenido);
            }
            else
            {
                ordenesentrega = new List<OrdenEntrega.OrdenEntrega>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesentrega);
            File.WriteAllText(@"Datos\OrdenEntrega.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

        public static void AgregarOrdenEntrega(OrdenEntrega.OrdenEntrega orden)
        {
            ordenesentrega.Add(orden);
        }
    }
}
