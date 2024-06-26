﻿using GrupoA.Prototipo.Archivos.Estados;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos.Ordenes.OrdenSeleccion;
internal static class OrdenSeleccionArchivo
{
    public static ReadOnlyCollection<OrdenSeleccionEntidad> OrdenesSeleccion => ordenesseleccion.AsReadOnly();

    private static List<OrdenSeleccionEntidad> ordenesseleccion;

    static OrdenSeleccionArchivo()
    {
        if (File.Exists(@"Datos\OrdenSeleccion.json"))
        {
            var contenido = File.ReadAllText(@"Datos\OrdenSeleccion.json");
            ordenesseleccion = JsonConvert.DeserializeObject<List<OrdenSeleccionEntidad>>(contenido);
        }
        else
        {
            ordenesseleccion = new List<OrdenSeleccionEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(ordenesseleccion);
        File.WriteAllText(@"Datos\OrdenSeleccion.json", contenido);
    }

    public static void AgregarOrdenSeleccion(OrdenSeleccionEntidad ordenseleccion)
    {
        ordenesseleccion.Add(ordenseleccion);
    }
    public static void ModificarEstado(OrdenSeleccionEntidad orden, EstadosOrdenSeleccion estado)
    {
        orden.Estado = estado;
    }
}
