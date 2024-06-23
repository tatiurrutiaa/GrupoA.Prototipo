using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class ClienteArchivo
{
    public static ReadOnlyCollection<ClienteEntidad> Clientes => clientes.AsReadOnly();

    private static List<ClienteEntidad> clientes;

    static ClienteArchivo()
    {
        if (File.Exists(@"Datos\Cliente.json"))
        {
            var contenido = File.ReadAllText(@"Datos\Cliente.json");
            clientes = JsonConvert.DeserializeObject<List<ClienteEntidad>>(contenido);
        }
        else
        {
            clientes = new List<ClienteEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(clientes);
        File.WriteAllText(@"Datos\Cliente.json", contenido);
    }

}
