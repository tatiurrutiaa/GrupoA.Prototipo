using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos
{
    public static class ArchivoCliente
    {
        public static ReadOnlyCollection<OrdenPreparacion.Cliente> Clientes => clientes.AsReadOnly();

        private static List<OrdenPreparacion.Cliente> clientes;

        static ArchivoCliente()
        {
            if (File.Exists(@"Datos\Cliente.json"))
            {
                var contenido = File.ReadAllText(@"Datos\Cliente.json");
                clientes = JsonConvert.DeserializeObject<List<OrdenPreparacion.Cliente>>(contenido);
            }
            else
            {
                clientes = new List<OrdenPreparacion.Cliente>();
            }
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(clientes);
            File.WriteAllText(@"Datos\Cliente.json", contenido);
        }

        //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE
    }
}
