using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoOrdenSeleccion
    {
        public static ReadOnlyCollection<RetiroStock.OrdenSeleccion> OrdenesSeleccion => ordenesseleccion.AsReadOnly();

        private static List<RetiroStock.OrdenSeleccion> ordenesseleccion;

        static ArchivoOrdenSeleccion()
        {
            if (File.Exists(@"OrdenSeleccion.json"))
            {
                var contenido = File.ReadAllText(@"OrdenSeleccion.json");
                ordenesseleccion = JsonConvert.DeserializeObject<List<RetiroStock.OrdenSeleccion>>(contenido);
            }
            else
            {
                ordenesseleccion = new List<RetiroStock.OrdenSeleccion>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesseleccion);
            File.WriteAllText(@"OrdenSeleccion.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

        public static void AgregarOrdenSeleccion(RetiroStock.OrdenSeleccion ordenseleccion)
        {
            ordenesseleccion.Add(ordenseleccion);
        }
        public static void ModificarEstado(RetiroStock.OrdenSeleccion orden, string estado)
        {
            orden.Estado = estado;
        }
    }
}
