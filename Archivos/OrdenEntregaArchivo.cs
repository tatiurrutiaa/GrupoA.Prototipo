using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class OrdenEntregaArchivo
{
    public static ReadOnlyCollection<OrdenEntregaEntidad> OrdenesEntrega => ordenesentrega.AsReadOnly();

    private static List<OrdenEntregaEntidad> ordenesentrega;

    static OrdenEntregaArchivo()
    {
        if (File.Exists(@"Datos\OrdenEntrega.json"))
        {
            var contenido = File.ReadAllText(@"Datos\OrdenEntrega.json");
            ordenesentrega = JsonConvert.DeserializeObject<List<OrdenEntregaEntidad>>(contenido);
        }
        else
        {
            ordenesentrega = new List<OrdenEntregaEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(ordenesentrega);
        File.WriteAllText(@"Datos\OrdenEntrega.json", contenido);
    }

    public static void AgregarOrdenEntrega(OrdenEntregaEntidad ordenpreparacion)
    {
        ordenesentrega.Add(ordenpreparacion);
    }
}
