﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Archivos;
internal class MercaderiaArchivo
{
    public static ReadOnlyCollection<MercaderiaEntidad> Mercaderias => mercaderias.AsReadOnly();

    private static List<MercaderiaEntidad> mercaderias;

    static MercaderiaArchivo()
    {
        if (File.Exists(@"Datos\Mercaderia.json"))
        {
            var contenido = File.ReadAllText(@"Datos\Mercaderia.json");
            mercaderias = JsonConvert.DeserializeObject<List<MercaderiaEntidad>>(contenido);
        }
        else
        {
            mercaderias = new List<MercaderiaEntidad>();
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(mercaderias);
        File.WriteAllText(@"Datos\Mercaderia.json", contenido);
    }
}
