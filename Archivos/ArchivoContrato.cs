using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoContrato
    {
        public static ReadOnlyCollection<OrdenSeleccion.Contrato> Contratos => contratos.AsReadOnly();

        private static List<OrdenSeleccion.Contrato> contratos;

        static ArchivoContrato()
        {
            if (File.Exists(@"Datos\Contrato.json"))
            {
                var contenido = File.ReadAllText(@"Datos\Contrato.json");
                contratos = JsonConvert.DeserializeObject<List<OrdenSeleccion.Contrato>>(contenido);
            }
            else
            {
                contratos = new List<OrdenSeleccion.Contrato>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(contratos);
            File.WriteAllText(@"Datos\Contrato.json", contenido);
        }

        public static string BuscarCriticidad(string cuitCliente)
        {
            var contrato = Contratos.FirstOrDefault(c => c.CuitCliente == cuitCliente);
            return contrato.Criticidad;
        }
    }
}
