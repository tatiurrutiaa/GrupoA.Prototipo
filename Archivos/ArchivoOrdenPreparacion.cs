using GrupoA.Prototipo.RetiroStock;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;

public static class ArchivoOrdenPreparacion
{
    public static ReadOnlyCollection<RetiroStock.OrdenPreparacion> OrdenesPreparacion => ordenespreparacion.AsReadOnly();

    private static List<RetiroStock.OrdenPreparacion> ordenespreparacion;

    static ArchivoOrdenPreparacion()
    {
        if (File.Exists(@"OrdenPreparacion.json"))
        {
            var contenido = File.ReadAllText(@"OrdenPreparacion.json");
            ordenespreparacion = JsonConvert.DeserializeObject<List<RetiroStock.OrdenPreparacion>>(contenido);
        }
        else
        {
            ordenespreparacion = new List<RetiroStock.OrdenPreparacion>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(ordenespreparacion);
        File.WriteAllText(@"OrdenPreparacion.json", contenido);
    }

    //TODAS LAS MODIFICACIONES LAS HACEMOS A TRAVES DE METODOS EN ESTA CLASE

    public static void AgregarOrdenPreparacion(RetiroStock.OrdenPreparacion ordenpreparacion)
    {
        ordenespreparacion.Add(ordenpreparacion);
    }
}
