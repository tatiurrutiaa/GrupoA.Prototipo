using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class OrdenPreparacionArchivo
{
    public static ReadOnlyCollection<OrdenPreparacionEntidad> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

    private static List<OrdenPreparacionEntidad> ordenespreparacion;

    static OrdenPreparacionArchivo()
    {
        if (File.Exists(@"OrdenPreparacion.json"))
        {
            var contenido = File.ReadAllText(@"OrdenPreparacion.json");
            ordenespreparacion = JsonConvert.DeserializeObject<List<OrdenPreparacionEntidad>>(contenido);
        }
        else
        {
            ordenespreparacion = new List<OrdenPreparacionEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(ordenespreparacion);
        File.WriteAllText(@"OrdenPreparacion.json", contenido);
    }

    public static void AgregarOrdenPreparacion(OrdenPreparacionEntidad ordenpreparacion)
    {
        ordenespreparacion.Add(ordenpreparacion);
    }
    public static void ModificarEstado(OrdenPreparacionEntidad orden, EstadoOrdenPreparacion estado)
    {
        orden.Estado = estado;
    }

    public static List<OrdenPreparacionEntidad> ObtenerOrdenesPreparacionPorNumero(List<int> nroOrdenesPrepList)
    {
        return ordenespreparacion
            .Where(op => nroOrdenesPrepList.Contains(op.NroOrdenPrep))
            .ToList();
    }
}
