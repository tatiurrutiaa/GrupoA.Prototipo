using GrupoA.Prototipo.OrdenPreparacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal static class ContratoArchivo
{
    public static ReadOnlyCollection<ContratoEntidad> Contratos => contratos.AsReadOnly();

    private static List<ContratoEntidad> contratos;

    static ContratoArchivo()
    {
        if (File.Exists(@"Datos\Contrato.json"))
        {
            var contenido = File.ReadAllText(@"Datos\Contrato.json");
            contratos = JsonConvert.DeserializeObject<List<ContratoEntidad>>(contenido);
        }
        else
        {
            contratos = new List<ContratoEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(contratos);
        File.WriteAllText(@"Datos\Contrato.json", contenido);
    }
    public static ValorCriticidad BuscarCriticidad(string cuit)
    {
        var contrato = Contratos.FirstOrDefault(c => c.CuitCliente == cuit);
        return contrato.Criticidad;
    }
}
