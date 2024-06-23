using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class DepositoArchivo
{
    public static ReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

    private static List<DepositoEntidad> depositos;

    static DepositoArchivo()
    {
        if (File.Exists(@"Datos\Deposito.json"))
        {
            var contenido = File.ReadAllText(@"Datos\Deposito.json");
            depositos = JsonConvert.DeserializeObject<List<DepositoEntidad>>(contenido);
        }
        else
        {
            depositos = new List<DepositoEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(depositos);
        File.WriteAllText(@"Datos\Deposito.json", contenido);
    }
}
